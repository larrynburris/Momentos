namespace Momentos
{
    public interface IOriginator<T>
    {
        IMomento<T> CreateMomento();
        void SetMomento(IMomento<T> momento);
    }
}
