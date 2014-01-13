using System;

namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var stockTicker = new StockTicker();

            var twitterStock = new TwitterStock(stockTicker);

            twitterStock.Update(new Stock { Symbol = "GOOG", Price = 1200, DateRecieved = DateTime.Now });

            Console.ReadLine();
        }
    }
}