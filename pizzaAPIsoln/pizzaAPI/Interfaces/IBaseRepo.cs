namespace pizzaAPI.Interfaces
{
    public interface IBaseRepo<K,T>
    {
        T Add(T item);
    }
}
