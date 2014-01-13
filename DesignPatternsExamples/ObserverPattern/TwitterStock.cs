namespace ObserverPattern
{
    public class TwitterStock : IObserver
    {
        private ISubject _stockData;

        public TwitterStock(ISubject stockData)
        {
            _stockData = stockData;
        }

        public void Update(Stock stock)
        {
            throw new System.NotImplementedException();
        }
    }
}