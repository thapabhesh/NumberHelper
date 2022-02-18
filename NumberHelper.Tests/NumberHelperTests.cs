using Xunit;

namespace NumberHelper.Tests
{
    public class NumberHelperTests
    {
        [Theory]
        [InlineData(10, new int[] { 1, 0 })]
        [InlineData(123456, new int[] { 1, 2, 3, 4, 5, 6 })]
        [InlineData(-123456, new int[] { 1, 2, 3, 4, 5, 6 })]
        [InlineData(0, new int[] { 0 })]
        public void Should_Digits_ReturnValidResults(int number, int[] expected)
        {
            var digits = NumberHelper.Digits(number);

            Assert.Equal(expected, digits);
        }

        [Theory]
        [InlineData(123, 321)]
        [InlineData(-123, -321)]
        [InlineData(0, 0)]
        public void Should_Reverse_ReturnValidResults(int number, int expected)
        {
            var reverse = NumberHelper.Reverse(number);

            Assert.Equal(expected, reverse);
        }
    }
}
