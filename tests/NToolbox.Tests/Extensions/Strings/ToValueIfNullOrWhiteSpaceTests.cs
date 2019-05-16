using FluentAssertions;

using NToolbox.Extensions.Strings;

using Xunit;

namespace NToolbox.Tests.Extensions.Strings
{
    public class ToValueIfNullOrWhiteSpaceTests
    {
        [Theory]
        [InlineData(null)]
        [InlineData("")]
        [InlineData(" ")]
        public void ToValueIfNullOrWhiteSpace_NullOrWhiteSpaceValue_ExpectedResult(string value)
        {
            // Arrange
            var expectedResult = "abc";

            // Act
            var result = value.ToValueIfNullOrWhiteSpace(expectedResult);

            // Assert
            result.Should().Be(expectedResult);
        }

        [Fact]
        public void ToValueIfNullOrWhiteSpace_NotNullOrWhiteSpaceValue_ExpectedResult()
        {
            // Arrange
            var expectedResult = "abc";

            // Act
            var result = expectedResult.ToValueIfNullOrWhiteSpace(expectedResult);

            // Assert
            result.Should().Be(expectedResult);
        }
    }
}
