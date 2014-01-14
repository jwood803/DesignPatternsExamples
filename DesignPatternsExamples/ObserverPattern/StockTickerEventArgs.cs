using System;

namespace ObserverPattern
{
    public class StockTickerEventArgs : EventArgs
    {
        public StockTickerEventArgs(string symbol, double price, DateTime dateRecieved)
        {
            this.Symbol = symbol;
            this.Price = price;
            this.DateRecieved = dateRecieved;
        }

        public DateTime DateRecieved { get; set; }
        public double Price { get; set; }
        public string Symbol { get; set; }
    }
}