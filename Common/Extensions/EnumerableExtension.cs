namespace Common.Extensions
{
    public static class EnumerableExtensions
    {
        public static bool IsNullOrEmpty<T>(this IEnumerable<T> array)
        {
            return (array == null || array.Count() == 0);
        }
    }
}
