using FluentAssertions;

using NToolbox.Extensions.String;

using Xunit;

namespace NToolbox.Tests.Extensions.String
{
    public class TruncateTests
    {
        [Theory]
        [InlineData(null)]
        [InlineData("")]
        public void Truncate_IsNullOrEmpty_ReturnsValue(string value)
        {
            var expectedResult = value;

            var result = value.Truncate(0);

            result.Should().Be(expectedResult);
        }

        [Theory]
        [InlineData("abcde", -1, "")]
        [InlineData("abcde", 0, "")]
        [InlineData("abcde", 1, "a")]
        [InlineData("abcde", 5, "abcde")]
        [InlineData("abcde", 6, "abcde")]
        public void Truncate_ValidValue_ReturnsExpectedResult(string value, int maxLength, string expectedResult)
        {
            var result = value.Truncate(maxLength);

            result.Should().Be(expectedResult);
        }
    }
}
