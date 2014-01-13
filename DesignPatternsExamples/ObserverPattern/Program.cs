namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var stockTicker = new StockTicker();

            var twitterStock = new TwitterStock(stockTicker);
        }
    }
}