using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StockTicker.Datasets;


namespace StockTicker.Classes
{
    public enum DataColumns
    {
        Open = 1,
        Close = 2
    }

    public class DataControler
    {
        private StockDataContext db = new StockDataContext();
        

        public double GetValue(string sStockSymbol, DateTime dtDate, string sColumnName)
        {
//            string sWhere = "Symbol = " + sStockSymbol + " and Day = " + dtDate.ToString("yyyy-mm-dd");
//            var value = db.StockDatas.Where(sWhere).Select(sColumnName);
            //var value = from cs in db.StockDatas
            //            where (cs.Symbol == sStockSymbol) && (cs.Day == dtDate)
            //            select sColumnName;

            return 0.0f;// float.Parse(value.ToString());
        }
        public List<double> GetValues(string sStockSymbol, DateTime dtStart, DateTime dtEnd, string sColumnName)
        {
            return null;
        }

        public void Set(string sStockSymbol, DateTime dtDate, string sColumnName, float fValue)
        {
        }

    }
}
