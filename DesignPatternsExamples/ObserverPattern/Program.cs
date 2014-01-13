using System;

namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // Monitor when specific events occur and react to them
            var stockTicker = new StockTicker();

            // Create observers, subscribe, and listen for the events of the stock ticker
            var twitterStock = new TwitterStock(stockTicker);

            stockTicker.Stock = new Stock
                                {
                                    Symbol = "GOOG",
                                    Price = 1000,
                                    DateRecieved = DateTime.Now
                                };

            Console.ReadLine();
        }
    }
}