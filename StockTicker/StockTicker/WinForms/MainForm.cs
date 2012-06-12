using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using StockTicker.Classes;

namespace StockTicker.WinForms
{
    public partial class MainForm : Form
    {
        private DataLib dlLib;
        private DBConnect db;

        public MainForm()
        {
            InitializeComponent();
            this.fbdOpen.SelectedPath = "C:\\Users\\Postal\\Documents\\Visual Studio 2008\\Projects\\StockTicker\\StockTicker";
            this.ofdOpen.InitialDirectory = "C:\\Users\\Postal\\Documents\\Visual Studio 2008\\Projects\\StockTicker\\StockTicker";

            this.ClearFields();

            this.db = new DBConnect();
            this.db.Init("stocksim.signaturepens.ca", "signaturepens_stocksim", "stockbot", "SBHelloWorld");
        }

        private void tsmiExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// This event handler is called when a file parsing has been
        /// completed in the DataLib class. This is called from a
        /// separate thread, so we must tell the BackgroundWorker to
        /// report progress in order to update Windows Forms fields.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <param name="sSymbol"></param>
        private void dlLib_FileComplete(object sender, EventArgs e, string sSymbol)
        {
            this.bwLoadData.ReportProgress(0, sSymbol);
        }
        private void dlLib_StockDayComplete(object sender, EventArgs e, string sSymbol, DateTime dtDay)
        {
            string sStatus = sSymbol + " - " + dtDay.ToString("yyyy-mm-dd");
            this.bwLoadFile.ReportProgress(0, sStatus);
        }
        private void ClearFields()
        {
            this.lblCurrentStock.Text = "";
            this.lblStatus.Text = "";
            this.tbCurrentStock.Text = "";
            this.tbCurrentStock.Visible = false;
        }

        private void bwLoadData_DoWork(object sender, DoWorkEventArgs e)
        {
            //this.dlLib.LoadAllData();
            foreach (string sFilename in this.dlLib.FileList)
            {
                List<StockObject> stocks = this.dlLib.LoadFile(sFilename);
                foreach (StockObject stock in stocks)
                {
                    this.db.Insert(stock);
                }
            }
        }
        private void bwLoadData_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (this.pbMain.Value < 10)
            {
                this.lblStatus.Text = "Loading Data...";
                this.lblCurrentStock.Text = "Current Stock:";
                this.tbCurrentStock.Visible = true;
            }

            this.pbMain.PerformStep();
            this.tbCurrentStock.Text = (string)e.UserState;
        }
        private void bwLoadFile_DoWork(object sender, DoWorkEventArgs e)
        {
            List<StockObject> stocks = this.dlLib.LoadFile((string)e.Argument);
            foreach(StockObject stock in stocks)
            {
                this.db.Insert(stock);
            }
        }
        private void bwLoadFile_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (this.pbMain.Value < 10)
            {
                this.lblStatus.Text = "Loading Stock...";
                this.lblCurrentStock.Text = "Current Date:";
                this.tbCurrentStock.Visible = true;
            }

            this.pbMain.PerformStep();
            this.tbCurrentStock.Text = (string)e.UserState;
        }
        private void bwLoadFile_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.ClearFields();
        }

        private void tsmiReloadAllStockData_Click(object sender, EventArgs e)
        {
            if (fbdOpen.ShowDialog(this).Equals(DialogResult.OK))
            {
                this.dlLib = new DataLib(fbdOpen.SelectedPath);

                this.dlLib.FileComplete += new FileCompleteEventHandler(dlLib_FileComplete);
                this.pbMain.Value = 0;
                this.pbMain.Maximum = dlLib.TotalFiles;
                this.pbMain.Minimum = 0;
                this.pbMain.Step = 1;

                this.bwLoadData.RunWorkerAsync();
            }

            this.ClearFields();
        }
        private void tsmiLoadAStockFile_Click(object sender, EventArgs e)
        {
            if (this.ofdOpen.ShowDialog(this).Equals(DialogResult.OK))
            {
                this.dlLib = new DataLib();

                this.dlLib.StockDayComplete += new StockDayCompleteEventHandler(dlLib_StockDayComplete);
                this.pbMain.Value = 0;
                this.pbMain.Maximum = dlLib.TotalStockDays;
                this.pbMain.Minimum = 0;
                this.pbMain.Step = 1;

                this.bwLoadFile.RunWorkerAsync(ofdOpen.FileName);
            }
        }

        private void tsmiGoogleFinanceLogin_Click(object sender, EventArgs e)
        {
            GoogleFinanceLib gfLib = new GoogleFinanceLib();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataControler dc = new DataControler();
            dc.GetValue("GOOG", new DateTime(2009, 1, 1), "Price_Open");
        }

        private void btnTestDBConnection_Click(object sender, EventArgs e)
        {
            /*
             *  stocksim.signaturepens.ca
             *  username: stockbot
             *  password: SBHelloWorld
             *  database: signaturepens_stocksim
             *  server:   lute:yarber
             */
            DBConnect db = new DBConnect();
            db.Init("stocksim.signaturepens.ca", "signaturepens_stocksim", "stockbot", "SBHelloWorld");
        }
    }
}
