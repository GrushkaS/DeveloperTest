using Task4.Extensions;

namespace Task4.Tests
{
    public class Task4StringExtensionsTests
    {
        [Fact]
        public void ReverseString_hello_Returns_olleh()
        {
            var input = "hello";
            var expected = "olleh";

            var actual = input.ReverseString();

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ReverseString_World_Returns_dlroW()
        {
            var input = "World";
            var expected = "dlroW";

            var actual = input.ReverseString();

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ReverseString_a_Returns_a()
        {
            var input = "a";
            var expected = "a";

            var actual = input.ReverseString();

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void GivenEmptyString_ToReverseString_ThrowArgumentNullException()
        {
            var input = "";

            Assert.Throws<ArgumentNullException>(() => input.ReverseString());
        }

        [Fact]
        public void GivenNullObject_ToReverseString_ThrowArgumentNullException()
        {
            string input = null;

            Assert.Throws<ArgumentNullException>(() => input.ReverseString());
        }


        [Fact]
        public void IsPalindrome_hooh_Returns_True()
        {
            var input = "hooh";
            var expected = true;

            var actual = input.IsPalindrome();

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void IsPalindrome_HooH_Returns_True()
        {
            var input = "HooH";
            var expected = true;

            var actual = input.IsPalindrome();

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void IsPalindrome_Hello_Returns_False()
        {
            var input = "Hello";
            var expected = false;

            var actual = input.IsPalindrome();

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void IsPalindrome_a_Returns_True()
        {
            var input = "a";
            var expected = true;

            var actual = input.IsPalindrome();

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void GivenEmptyString_ToIsPalindrome_ThrowArgumentNullException()
        {
            var input = "";

            Assert.Throws<ArgumentNullException>(() => input.IsPalindrome());
        }

        [Fact]
        public void GivenNullObject_ToIsPalindrome_ThrowArgumentNullException()
        {
            string input = null;

            Assert.Throws<ArgumentNullException>(() => input.IsPalindrome());
        }

    }
}
