using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Google.GData.Client;

namespace StockTicker.Classes
{
    public class GoogleFinanceLib
    {
        private string sUsername = "finance@ccscorp.ca";
        private string sPassword = "mszcefpiucatnckl";

        public GoogleFinanceLib()
        {
            Service sFinance = new Service("finance", "StockTicker");//"CCSC-StockTicker-1a");

            /*
             *  Setup credentials. 
             */
            sFinance.Credentials = new GDataCredentials(sUsername, sPassword);
            GDataGAuthRequestFactory rfFactory = (GDataGAuthRequestFactory)sFinance.RequestFactory;
            rfFactory.AccountType = "GOOGLE";
            
            FeedQuery fqQuery = new FeedQuery();
            /*
             *  Need "query" uri.
             */
            fqQuery.Uri = new Uri("http://www.google.com/finance");
            fqQuery.Query = "GOOG";
/*            AtomFeed afFeed = sFinance.Query(fqQuery);
*/
//            string s = "";
        }
    }
}
