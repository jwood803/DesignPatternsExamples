using System;

namespace ObserverPattern
{
    public class Stock
    {
        public string Symbol { get; set; }
        public double Price { get; set; }
        public DateTime DateRecieved { get; set; }
    }
}