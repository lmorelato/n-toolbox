using FluentAssertions;

using NToolbox.Extensions.Strings;

using Xunit;

namespace NToolbox.Tests.Extensions.Strings
{
    public class IsNotNullOrEmptyTests
    {
        [Theory]
        [InlineData(null)]
        [InlineData("")]
        [InlineData(" ")]
        [InlineData("abc")]
        public void IsNotNullOrEmpty_StringValue_True(string value)
        {
            // Arrange
            var expectedResult = !string.IsNullOrEmpty(value);

            // Act
            var result = value.IsNotNullOrEmpty();

            // Assert
            result.Should().Be(expectedResult);
        }
    }
}
