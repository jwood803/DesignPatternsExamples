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
            new TwitterStock(stockTicker);

            // Setting the "Stock" property will trigger a new update and will display to the console.
            stockTicker.Stock = new Stock
                                {
                                    Symbol = "TWTR",
                                    Price = 1000,
                                    DateRecieved = DateTime.Now
                                };

            // Events

            // Create a reference to the delegate object
            var stockTickerDelegate = new StockTickerDelegate();
            
            // Subscribe to the StockTicker event. Using a lambda expression to give the 
            // event what happens after it has been triggered.
            stockTickerDelegate.StockTicker += (s, e) => 
                Console.WriteLine("Stock from event. Symbol {0}, price {1}, date recieved {2}",
                    e.Symbol, e.Price, e.DateRecieved);

            // An event has been triggered...
            stockTickerDelegate.SetStock(new Stock { Symbol = "TWTR", Price = 500, DateRecieved = DateTime.Now });

            // IObserver<T>

            // Create the Stock Ticker subject object
            var stockTickerObservable = new StockTickerObservable();

            // Create the object to observe
            var twitterStockObservable = new TwitterStockObservable();

            // Subscribe and check for new notifications. This will dispose
            // of the object (release the observable) once finished.
            using (stockTickerObservable.Subscribe(twitterStockObservable))
            {
                stockTickerObservable.Stock = new Stock
                                                {
                                                    Symbol = "TWTR",
                                                    Price = 5000,
                                                    DateRecieved = DateTime.Now
                                                };
            }

            Console.ReadLine();
        }
    }
}