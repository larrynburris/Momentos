using Momentos;

namespace MomentosSample
{
    public class StockMomento : IMomento<Stock>
    {
        private Stock _state;

        public StockMomento(Stock state)
        {
            _state = state;
        }

        public Stock GetState()
        {
            return _state;
        }

        public void SetState(Stock state)
        {
            _state = state;
        }
    }
}
