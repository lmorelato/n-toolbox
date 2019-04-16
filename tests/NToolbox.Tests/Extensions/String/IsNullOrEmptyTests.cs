using FluentAssertions;

using NToolbox.Extensions.String;

using Xunit;

namespace NToolbox.Tests.Extensions.String
{
    public class IsNullOrEmptyTests
    {
        [Theory]
        [InlineData(null)]
        [InlineData("")]
        public void IsNullOrEmpty_IsNullOrEmpty_True(string value)
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
