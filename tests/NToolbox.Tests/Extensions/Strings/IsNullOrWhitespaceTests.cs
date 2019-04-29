using FluentAssertions;

using NToolbox.Extensions.Strings;

using Xunit;

namespace NToolbox.Tests.Extensions.Strings
{
    public class IsNullOrWhitespaceTests
    {
        [Theory]
        [InlineData(null)]
        [InlineData("")]
        [InlineData("abc")]
        public void IsNullOrWhitespaceTests_StringValue_True(string value)
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
