using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StockTicker.Classes
{
    public static class AnalysisEngine
    {
        public static string CalcGap(double Day2Open, double Day1Close)
        {
            if (Day2Open - Day1Close > 0)
            {
                return "Up";
            }
            else if (Day2Open - Day1Close < 0)
            {
                return "Down";
            }
            else
            {
                return "No Change";
            }
        }
        public static string CalcColour(double StockOpen, double StockClose)
        {
            if (StockClose > StockOpen)
            {
                return "White";
            }
            else if (StockClose < StockOpen)
            {
                return "Black";
            }
            else
            {
                return "No Change";
            }
        }
        public static double CalcAvg(List<double> StockList)
        {
            double total = 0;

            foreach (double value in StockList)
            {
                total = total + value;
            }
            return total / StockList.Count;
        }
        public static double CalcShadowCloseActual(double stockHigh, double StockClose)
        {
            return stockHigh - StockClose;
        }
        public static double CalcShadowOpenActual(double stockHigh, double stockOpen)
        {
            return stockHigh - stockOpen;
        }
        public static int CalcShadowClosePercentage(double StockHigh, double StockClose)
        {
            double difference = StockHigh - StockClose;
            double result = StockClose / difference * 100;
            return (int)Math.Round(result, 2);
        }
        public static int CalcShadowOpenOpercentage(double StockHigh, double StockOpen)
        {
            double difference = StockHigh - StockOpen;
            return (int)Math.Round(StockOpen / difference * 100);
        }
        public static double CalcStandardDevation(List<Double> CostsArray)
        {
            double average = CostsArray.Average();
            double sumOfDerivation = 0;
            foreach (double value in CostsArray)
            {
                sumOfDerivation += (value) * (value);
            }
            double sumOfDerivationAverage = sumOfDerivation / CostsArray.Count;
            return Math.Sqrt(sumOfDerivationAverage - (average * average));
        }

        public static double CalcLinearRegression(List<double> CloseList, int dayToPerdict)
        {
            double xAvg = 0;
            double yAvg = 0;

            for (int x = 0; x < CloseList.Count; x++)
            {
                xAvg += x;
                yAvg += CloseList[x];
            }
            xAvg = xAvg / CloseList.Count;
            yAvg = yAvg / CloseList.Count;

            double v1 = 0;
            double v2 = 0;

            for (int x = 0; x < CloseList.Count; x++)
            {
                v1 += (x - xAvg) * (CloseList[x] - yAvg);
                v2 += Math.Pow(x - xAvg, 2);
            }
            double a = v1 / v2;
            double b = yAvg - a * xAvg;

            double y = (a * dayToPerdict) + b;
            return y;
        }
    }


}
