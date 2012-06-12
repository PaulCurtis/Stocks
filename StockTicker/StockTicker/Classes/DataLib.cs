using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using StockTicker.Datasets;

namespace StockTicker.Classes
{
    public delegate void FileCompleteEventHandler(
        object sender, 
        EventArgs e,
        string sSymbol
    );
    public delegate void StockDayCompleteEventHandler(
        object sender,
        EventArgs e,
        string sSymbol,
        DateTime dtDay
    );

    public class DataLib
    {
        public event FileCompleteEventHandler FileComplete;
        public event StockDayCompleteEventHandler StockDayComplete;

        private string sPath = "";
        private string[] sFileEntries;
        private StockDataContext db;
        private int iCurrentFile = 0;
        private int iTotalFiles = 0;
        private int iFileRows = 0;
        private int iCurrentRow = 0;

        public DataLib()
        {
            this.Init();
        }
        public DataLib(string sPath)
        {
            this.sPath = sPath;
            this.Init();

            this.sFileEntries = Directory.GetFiles(this.sPath);
            this.iTotalFiles = this.sFileEntries.Length;
//            this.db.ExecuteCommand("truncate table StockData");
            this.iCurrentFile = 1;
        }

        private void Init()
        {
            this.db = new StockDataContext(); 
        
        }
        

        /// <summary>
        /// Gets the current file number that is being worked on.
        /// </summary>
        public int CurrentFile
        {
            get
            {
                return this.iCurrentFile;
            }
        }
        public int CurrentStockDay
        {
            get
            {
                return this.iCurrentRow;
            }
        }
        /// <summary>
        /// Gets the total number of files in the directory specified
        /// on class initialization.
        /// </summary>
        public int TotalFiles
        {
            get
            {
                return this.iTotalFiles;
            }
        }
        public int TotalStockDays
        {
            get
            {
                return this.iFileRows;
            }
        }

        public void LoadFile(string sFilename)
        {
            string sSymbol = this.GetSymbol(sFilename);
            List<string[]> lCurrentFile = this.ParseFile(sFilename);
            this.iFileRows = lCurrentFile.Count;
            this.iCurrentRow = 1;
            this.ParseStockList(sSymbol, lCurrentFile);
        }
        public void LoadAllData()
        {
            if (this.sFileEntries == null)
            {
                throw new Exception("File Entries for path: '" + sPath + "' is empty");
            }

            foreach (string sFilename in this.sFileEntries)
            {
                this.LoadFile(sFilename);
            }
        }

        private List<string[]> ParseFile(string sFullyQualifiedName)
        {
            List<string[]> lParsedData = new List<string[]>();

            try
            {
                using (StreamReader readFile = new StreamReader(sFullyQualifiedName))
                {
                    string line;
                    string[] row;

                    while ((line = readFile.ReadLine()) != null)
                    {
                        row = line.Split(',');
                        lParsedData.Add(row);
                    }
                }
            }
            catch (Exception)
            {
                throw new Exception("Problem parsing CSV file: " + sFullyQualifiedName);
            }

            return lParsedData;
        }
        private void ParseStockList(string sSymbol, List<string[]> lStockInfo)
        {
            var currentStock = from cs in db.StockDatas
                               where cs.Symbol == sSymbol
                               select cs;
            db.StockDatas.DeleteAllOnSubmit(currentStock);
            db.SubmitChanges();

            foreach (string[] sStockDay in lStockInfo)
            {
                DateTime dtDate = DateTime.Parse(sStockDay[0]);

                StockData sd = new StockData();
                sd.Id = Guid.NewGuid();
                sd.Symbol = sSymbol;
                sd.Day = dtDate;
                sd.Price_Open = decimal.Parse(sStockDay[1]);
                sd.Price_High = decimal.Parse(sStockDay[2]);
                sd.Price_Low = decimal.Parse(sStockDay[3]);
                sd.Price_Close = decimal.Parse(sStockDay[4]);
                sd.Volume = int.Parse(sStockDay[5]);
                sd.Unknown_Value = decimal.Parse(sStockDay[6]);

                db.StockDatas.InsertOnSubmit(sd);
                this.OnStockDayComplete(new EventArgs(), sSymbol, dtDate);
            }

            db.SubmitChanges();
            this.OnFileComplete(new EventArgs(), sSymbol);
            this.iCurrentFile++;
        }

        private void LoadStockList()
        {
            
        }



        protected virtual void OnFileComplete(EventArgs e, string sSymbol)
        {
            if (this.FileComplete != null)
            {
                this.FileComplete(this, e, sSymbol);
            }
        }
        protected virtual void OnStockDayComplete(EventArgs e, string sSymbol, DateTime dtDate)
        {
            if (this.StockDayComplete != null)
            {
                this.StockDayComplete(this, e, sSymbol, dtDate);
            }
        }

        private string GetSymbol(string sFilename)
        {
            int iLastSlash = sFilename.LastIndexOf('\\');
            int iUnderscore = sFilename.LastIndexOf('_');
            if (iUnderscore == -1)
            {
                iUnderscore = sFilename.LastIndexOf('.');
            }

            return sFilename.Substring(iLastSlash + 1, iUnderscore - (iLastSlash + 1));
        }
    }
}
