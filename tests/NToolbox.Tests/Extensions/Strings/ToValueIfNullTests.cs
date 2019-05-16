using FluentAssertions;

using NToolbox.Extensions.Strings;

using Xunit;

namespace NToolbox.Tests.Extensions.Strings
{
    public class ToValueIfNullTests
    {
        [Theory]
        [InlineData(null)]
        public void ToValueIfNull_NullOrWhiteSpaceValue_ExpectedResult(string value)
        {
            // Arrange
            var expectedResult = "abc";

            // Act
            var result = value.ToValueIfNull(expectedResult);

            // Assert
            result.Should().Be(expectedResult);
        }

        [Fact]
        public void ToValueIfNull_NotNullOrWhiteSpaceValue_ExpectedResult()
        {
            // Arrange
            var expectedResult = "abc";

            // Act
            var result = expectedResult.ToValueIfNull(expectedResult);

            // Assert
            result.Should().Be(expectedResult);
        }
    }
}
