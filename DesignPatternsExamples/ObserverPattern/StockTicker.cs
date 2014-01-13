using System.Collections.Generic;

namespace ObserverPattern
{
    public class StockTicker : ISubject
    {
        private readonly List<IObserver> _observers;

        public StockTicker()
        {
            _observers = new List<IObserver>();
        }

        public void Subscribe(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void Unsubscribe(IObserver observer)
        {
            if (_observers.Contains(observer))
            {
                _observers.Remove(observer);
            }
        }

        public void NotifyAll(Stock stock)
        {
            _observers.ForEach(i => i.Update(stock));
        }
    }
}