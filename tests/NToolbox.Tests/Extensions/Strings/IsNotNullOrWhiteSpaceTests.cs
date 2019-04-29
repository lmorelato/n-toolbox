using FluentAssertions;

using NToolbox.Extensions.Strings;

using Xunit;

namespace NToolbox.Tests.Extensions.Strings
{
    public class IsNotNullOrWhiteSpaceTests
    {
        [Theory]
        [InlineData(null)]
        [InlineData("")]
        [InlineData(" ")]
        [InlineData("abc")]
        public void IsNotNullOrEmpty_StringValue_True(string value)
        {
            // Arrange
            var expectedResult = !string.IsNullOrWhiteSpace(value);

            // Act
            var result = value.IsNotNullOrWhiteSpace();

            // Assert
            result.Should().Be(expectedResult);
        }
    }
}
