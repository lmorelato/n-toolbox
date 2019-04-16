using FluentAssertions;

using NToolbox.Extensions.String;

using Xunit;

namespace NToolbox.Tests.Extensions.String
{
    public class IsNotNullOrEmptyTests
    {
        [Theory]
        [InlineData("abc")]
        public void IsNotNullOrEmpty_NotNullOrEmptyValue_True(string value)
        {
            // Arrange
            var expectedResult = !string.IsNullOrEmpty(value);

            // Act
            var result = value.IsNotNullOrEmpty();

            // Assert
            result.Should().Be(expectedResult);
        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        [InlineData(" ")]
        public void IsNotNullOrEmpty_NullOrEmptyValue_True(string value)
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
