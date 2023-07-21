namespace Task4.Extensions
{
    public static class StringExtensions
    {
        public static string ReverseString(this string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                throw new ArgumentNullException(nameof(str));
            }

            var sourceLength = str.Length;

            return new string(Enumerable.Range(0, sourceLength).Select((x, i) => str[sourceLength - i - 1]).ToArray());
        }


        public static bool IsPalindrome(this string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                throw new ArgumentNullException(nameof(str));
            }

            return string.Compare(str, str.ReverseString(), true) == 0;
        }
    }
}
