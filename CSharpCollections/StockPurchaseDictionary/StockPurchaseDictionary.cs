using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpCollections.StockPurchaseDictionary
{
    class StockPurchaseDictionary : ConsoleApp
    {
        public StockPurchaseDictionary()
        {
            Name = "Stock Purchase Dictionary";
        }
        public override void Run()
        {
            Dictionary<string, string> stocks = new Dictionary<string, string>();
            stocks.Add("GM", "General Motors");
            stocks.Add("CAT", "Caterpillar");
            stocks.Add("DJI", "Dow Jones Industrial");
            stocks.Add("SBUX", "Starbucks Corporation");
            stocks.Add("DG", "Dollar General Corporation");
            stocks.Add("GE", "General Electric Company");
            stocks.Add("INTC", "Intel Corporation");
            stocks.Add("FB", "Facebook Inc.");
            stocks.Add("TWTR", "Twitter Inc.");
            stocks.Add("AAPL", "Apple Inc.");

            List<(string ticker, int shares, double price)> purchases = new List<(string, int, double)>();

            purchases.Add((ticker: "GM", shares: 3, price: 23.21));
            purchases.Add((ticker: "GM", shares: 3, price: 17.87));
            purchases.Add((ticker: "GM", shares: 1, price: 28.56));
            purchases.Add((ticker: "CAT", shares: 2, price: 138.43));
            purchases.Add((ticker: "DJI", shares: 2, price: 17.87));
            purchases.Add((ticker: "TWTR", shares: 3, price: 19.02));
            purchases.Add((ticker: "FB", shares: 1, price: 267.01));
            purchases.Add((ticker: "DG", shares: 2, price: 198.93));
            purchases.Add((ticker: "INTC", shares: 2, price: 49.28));
            purchases.Add((ticker: "AAPL", shares: 3, price: 497.48));
            purchases.Add((ticker: "GE", shares: 3, price: 6.31));
            purchases.Add((ticker: "SBUX", shares: 1, price: 77.07));


            //Create a total ownership report that computes the total value of each stock that you have purchased.
            //This is the basic relational database join algorithm between two tables.

            /*
             * Define a new Dictionary to hold the aggregated purchase information. - The key should be a string that is the full company name.
             * The value will be the valuation of each stock (price*amount) { "General Electric": 35900, "AAPL": 8445, ... }
            */

            var finalStockReport = new Dictionary<string, int>();

            // Iterate over the purchases and update the valuation for each stock
            foreach ((string ticker, int shares, double price) purchase in purchases)
            {
                var totalValue = (double)purchase.shares * purchase.price;

                if (finalStockReport.ContainsKey(purchase.ticker))
                {
                    Console.WriteLine($"{purchase.ticker} already there.");
                    finalStockReport[purchase.ticker] = finalStockReport[purchase.ticker] + (int)totalValue;
                    Console.WriteLine($"{finalStockReport[purchase.ticker]} plus {(int) totalValue}");
                }
                else
                {
                    finalStockReport.Add(purchase.ticker, (int) totalValue);
                }
            }

            foreach (var report in finalStockReport)
            {
                Console.WriteLine($"{report.Key}: {report.Value}");
            }
        }
    }
}
