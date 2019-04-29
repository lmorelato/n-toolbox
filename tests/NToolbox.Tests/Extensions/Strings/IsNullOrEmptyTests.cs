using FluentAssertions;

using NToolbox.Extensions.Strings;

using Xunit;

namespace NToolbox.Tests.Extensions.Strings
{
    public class IsNullOrEmptyTests
    {
        [Theory]
        [InlineData(null)]
        [InlineData("")]
        [InlineData("abc")]
        public void IsNullOrEmpty_StringValue_True(string value)
        {
            // Arrange
            var expectedResult = string.IsNullOrEmpty(value);

            // Act
            var result = value.IsNullOrEmpty();

            // Assert
            result.Should().Be(expectedResult);
        }
    }
}
