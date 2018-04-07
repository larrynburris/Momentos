namespace Momentos
{
    public interface IMomento<T>
    {
        T GetState();
        void SetState(T state);
    }
}
