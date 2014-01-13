using System;

namespace ObserverPattern
{
    public class TwitterStock : IObserver
    {
        private ISubject _stockData;
        private double _price;
        private DateTime _dateRecieved;
        private string _symbol;

        public TwitterStock(ISubject stockData)
        {
            _stockData = stockData;
        }

        public void Update(Stock stock)
        {
            _symbol = stock.Symbol;
            _price = stock.Price;
            _dateRecieved = stock.DateRecieved;

            Display();
        }

        private void Display()
        {
            Console.WriteLine("{0} changed with price {1} on {2}.", _symbol, _price, _dateRecieved);
        }
    }
}