using FluentAssertions;

using NToolbox.Extensions.Strings;

using Xunit;

namespace NToolbox.Tests.Extensions.Strings
{
    public class ToValueIfNullOrEmptyTests
    {
        [Theory]
        [InlineData(null)]
        [InlineData("")]
        public void ToValueIfNullOrEmpty_NullOrWhiteSpaceValue_ExpectedResult(string value)
        {
            // Arrange
            var expectedResult = "abc";

            // Act
            var result = value.ToValueIfNullOrEmpty(expectedResult);

            // Assert
            result.Should().Be(expectedResult);
        }

        [Fact]
        public void ToValueIfNullOrEmpty_NotNullOrWhiteSpaceValue_ExpectedResult()
        {
            // Arrange
            var expectedResult = "abc";

            // Act
            var result = expectedResult.ToValueIfNullOrEmpty(expectedResult);

            // Assert
            result.Should().Be(expectedResult);
        }
    }
}
