using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StockTicker.Datasets;


namespace StockTicker.Classes
{
    public class TestExecution
    {
        

        public TestExecution(StockDataContext dc, string sSymbol, int iAvgDays, 
            int iRegressionDays, DateTime dtCurrentDate)
        {
            /*
             * get current stock data
             * get current - 1 day stock data
             * 
             * get current - regression/avg days data
             * 
             * call each of the analysis engine functions
             * 
             * call set method from datacontroller to update the stock test values
             * 
             */
            DateTime dtStart;

        }
        
    }
}
