using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StockTicker.Classes
{
    public class StockObject
    {
        private string symbol;
        private DateTime day;
        private decimal open;
        private decimal high;
        private decimal low;
        private decimal close;
        private int volume;
        private decimal adjustedClose;

        public StockObject()
        {
        }

        public string Symbol
        {
            get
            {
                return this.symbol;
            }
            set
            {
                this.symbol = value;
            }
        }
        public DateTime Day
        {
            get
            {
                return this.day;
            }
            set
            {
                this.day = value;
            }
        }
        public decimal Open
        {
            get
            {
                return this.open;
            }
            set
            {
                this.open = value;
            }
        }
        public decimal High
        {
            get
            {
                return this.high;
            }
            set
            {
                this.high = value;
            }
        }
        public decimal Low
        {
            get
            {
                return this.low;
            }
            set
            {
                this.low = value;
            }
        }
        public decimal Close
        {
            get
            {
                return this.close;
            }
            set
            {
                this.close = value;
            }
        }
        public decimal AdjustedClose
        {
            get
            {
                return this.adjustedClose;
            }
            set
            {
                this.adjustedClose = value;
            }
        }
        public int Volume
        {
            get
            {
                return this.volume;
            }
            set
            {
                this.volume = value;
            }
        }

    }
}
