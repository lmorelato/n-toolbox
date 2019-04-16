using FluentAssertions;

using NToolbox.Extensions.String;

using Xunit;

namespace NToolbox.Tests.Extensions.String
{
    public class IsNullOrWhitespaceTests
    {
        [Theory]
        [InlineData(null)]
        [InlineData("")]
        public void IsNullOrWhitespaceTests_NullOrEmptyValue_True(string value)
        {
            // Arrange
            var expectedResult = string.IsNullOrWhiteSpace(value);

            // Act
            var result = value.IsNullOrWhiteSpace();

            // Assert
            result.Should().Be(expectedResult);
        }

        [Theory]
        [InlineData("abc")]
        public void IsNullOrWhitespaceTests_NotNullOrEmptyValue_True(string value)
        {
            // Arrange
            var expectedResult = string.IsNullOrWhiteSpace(value);

            // Act
            var result = value.IsNullOrWhiteSpace();

            // Assert
            result.Should().Be(expectedResult);
        }
    }
}
