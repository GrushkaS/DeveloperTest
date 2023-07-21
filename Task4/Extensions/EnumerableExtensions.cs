namespace Task4.Extensions
{
    public static class EnumerableExtensions
    {
        public static IEnumerable<int> MissingElements(this int[] arr)
        {
            if (arr.IsNullOrEmpty())
            {
                throw new ArgumentNullException(nameof(arr));
            }

            var firstNumber = arr.First();

            var lastNumber = arr.Last();

            return Enumerable.Range(firstNumber, lastNumber - firstNumber).Except(arr);
        }

        public static bool IsNullOrEmpty<T>(this IEnumerable<T> array)
        {
            return (array == null || array.Count() == 0);
        }
    }
}
