using System;
using System.Collections.Generic;

namespace FinanceWebScraper
{
    public class YahooFinanceScraper
    {
        public List<String> StockWatchList { get; set; }
        public string UserId { get; set; }

        public YahooFinanceScraper(List<string> stockWatchList, string userId)
        {
            StockWatchList = stockWatchList;
            UserId = userId;
        }
    }
}