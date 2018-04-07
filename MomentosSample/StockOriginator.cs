using Momentos;

namespace MomentosSample
{
    public class StockOriginator : IOriginator<Stock>
    {
        public Stock Data { get; set; }

        public IMomento<Stock> CreateMomento()
        {
            return new StockMomento(Data);
        }

        public void SetMomento(IMomento<Stock> momento)
        {
            momento.SetState(Data);
        }
    }
}
