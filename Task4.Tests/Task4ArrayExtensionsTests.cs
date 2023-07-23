using Task4.Extensions;

namespace Task4.Tests
{
    public class Task4ArrayExtensionsTests
    {
        [Fact]
        public void FindingMissingElements()
        {
            var input = new int[] { 1, 2, 4, 5, 6, 8, 9, 10 };
            var expected = new int[] { 3, 7 };

            var actual = input.MissingElements();

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void GivenOneElement_ToMissingElements_ReturnsEmptyCollection()
        {
            var input = new int[] { 1 };
            var expected = new int[] { };

            var actual = input.MissingElements();

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void GivenNoElementMissingArray_ToMissingElements_ReturnsEmptyCollection()
        {
            var input = new int[] { 1 };
            var expected = new int[] { };

            var actual = input.MissingElements();

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void GivenEmptyArray_ToMissingElements_ThrowArgumentNullException()
        {
            var input = "";

            Assert.Throws<ArgumentNullException>(() => input.ReverseString());
        }

        [Fact]
        public void GivenNullObject_ToMissingElements_ThrowArgumentNullException()
        {
            string input = null;

            Assert.Throws<ArgumentNullException>(() => input.ReverseString());
        }
    }
}
