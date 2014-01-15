using System;
using System.Collections.Generic;

namespace ObserverPattern
{
    public class StockTickerObservable : IObservable<Stock>
    {
        private readonly List<IObserver<Stock>> _observers;
        private Stock _stock;

        public StockTickerObservable()
        {
            _observers = new List<IObserver<Stock>>();
        }

        public Stock Stock
        {
            get { return _stock; }
            set
            {
                _stock = value;
                this.Notify();
            }
        }

        private void Notify()
        {
            _observers.ForEach(i =>
            {
                if (_stock.Price < 0 || _stock.DateRecieved == DateTime.MinValue)
                {
                    i.OnError(new ApplicationException("Invalid stock information"));
                }
                else
                {
                    i.OnNext(_stock);
                }
            });
        }

        public IDisposable Subscribe(IObserver<Stock> observer)
        {
            if (!_observers.Contains(observer))
            {
                _observers.Add(observer);
            }

            return new Unsubscriber(_observers, observer);
        }
    }

    public class Unsubscriber : IDisposable
    {
        private readonly List<IObserver<Stock>> _observers;
        private readonly IObserver<Stock> _observer;

        public Unsubscriber(List<IObserver<Stock>> observers, IObserver<Stock> observer)
        {
            _observers = observers;
            _observer = observer;
        }

        public void Dispose()
        {
            if (_observer != null && _observers.Contains(_observer))
            {
                _observers.Remove(_observer);
            }
        }
    }
}