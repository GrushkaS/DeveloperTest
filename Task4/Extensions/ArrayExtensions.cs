using Common.Extensions;

namespace Task4.Extensions
{
    public static class ArrayExtensions
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
    }
}
