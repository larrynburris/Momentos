using System;

namespace MomentosSample
{
    public class Stock
    {
        public string Symbol { get; set; }
        public decimal Price { get; set; }
        public DateTime Timestamp { get; set; }

        public override string ToString()
        {
            return $"{Timestamp} - {Symbol} - {Price.ToString("F2")}";
        }
    }
}
