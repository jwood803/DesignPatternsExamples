namespace ObserverPattern
{
    public class StockTicker : ISubject
    {
        public void Subscribe(IObserver observer)
        {
            throw new System.NotImplementedException();
        }

        public void Unsubscribe(IObserver observer)
        {
            throw new System.NotImplementedException();
        }

        public void NotifyAll()
        {
            throw new System.NotImplementedException();
        }
    }
}