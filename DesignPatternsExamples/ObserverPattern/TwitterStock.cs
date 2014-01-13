using System;

namespace ObserverPattern
{
    public class TwitterStock : IObserver
    {
        private StockTicker _stockData;
        private double _price;
        private DateTime _dateRecieved;
        private string _symbol;

        public TwitterStock(StockTicker stockData)
        {
            _stockData = stockData;
            _stockData.Subscribe(this);
        }

        public void Update()
        {
            _symbol = _stockData.Stock.Symbol;
            _price = _stockData.Stock.Price;
            _dateRecieved = _stockData.Stock.DateRecieved;

            Display();
        }

        private void Display()
        {
            Console.WriteLine("{0} changed with price {1} on {2}.", _symbol, _price, _dateRecieved);
        }
    }
}