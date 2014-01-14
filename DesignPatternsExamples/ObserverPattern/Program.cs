using System;

namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // Traditional

            // Monitor when specific events occur and react to them
            var stockTicker = new StockTicker();

            // Create observers, subscribe, and listen for the events of the stock ticker
            var twitterStock = new TwitterStock(stockTicker);

            stockTicker.Stock = new Stock
                                {
                                    Symbol = "TWTR",
                                    Price = 1000,
                                    DateRecieved = DateTime.Now
                                };

            // Events

            var stockTickerDelegate = new StockTickerDelegate();

            stockTickerDelegate.StockTicker += (s, e) => 
                Console.WriteLine("Stock from event. Symbol {0}, price {1}, date recieved {2}", e.Symbol, e.Price, e.DateRecieved);

            stockTickerDelegate.SetStock(new Stock { Symbol = "TWTR", Price = 500, DateRecieved = DateTime.Now });

            // IObserver<T>



            Console.ReadLine();
        }
    }
}