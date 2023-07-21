namespace Task2.Services
{
    public interface IInstanceService
    {
        IEnumerable<T> GetInstances<T>();
    }
}
