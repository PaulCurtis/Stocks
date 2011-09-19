using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StockTicker.Classes
{
    public class Simulation
    {
        private decimal dStartCash = 1000m;
        private decimal dTradeComission = 5m;
        private decimal dTargetPctSell = 0.01m;
        private decimal dTargetPctStopLoss = 0.2m;

        private DateTime dtSimStartDate = new DateTime(2008, 1, 1);

        private int iSimulations = 100;

        private int iAvgDays = 10, iRegressionDays = 15;


        public Simulation()
        {
            string sCurrentStock;
            /*
             * read in the parameter file (OR JUST FUCKING HARD CODE IT)
             * 
             * 
             * 
             * loop through a number of days and call the test execution 
             * for each 
             */
            for (int i = 1; i <= iSimulations; i++)
            {
                /*
                 * StockDataContext dc, string sSymbol, int iAvgDays, 
            int iRegressionDays, DateTime dtCurrentDate)
        {
                 * 
                 * get the fuckeeng stock list, der
                 */
                //TestExecution te = new TestExecution(new StockTicker.Datasets.StockDataContext,
                //    sCurrentStock, this.iAvgDays,this.iRegressionDays,

            }
        }
    }
}
