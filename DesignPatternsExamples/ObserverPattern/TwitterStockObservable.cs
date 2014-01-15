using System;

namespace ObserverPattern
{
    public class TwitterStockObservable : IObserver<Stock>
    {
        public void OnNext(Stock value)
        {
            Console.WriteLine("{0} changed with price {1}. Recieved on {2}", value.Symbol, value.Price, value.DateRecieved);
        }

        public void OnError(Exception error)
        {
            Console.WriteLine("An error occured: {0}", error.Message);
        }

        public void OnCompleted()
        {
            Console.WriteLine("Completed!");
        }
    }
}