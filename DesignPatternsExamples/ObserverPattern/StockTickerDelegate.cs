using System;

namespace ObserverPattern
{
    public class StockTickerDelegate
    {
        public event EventHandler<StockTickerEventArgs> StockTicker;

        protected virtual void OnNewStock(string symbol, double price, DateTime dateRecieved)
        {
            if (StockTicker != null)
            {
                StockTicker(this, new StockTickerEventArgs(symbol, price, dateRecieved));
            }
        }

        public void SetStock(Stock stock)
        {
            OnNewStock(stock.Symbol, stock.Price, stock.DateRecieved);
        }
    }
}