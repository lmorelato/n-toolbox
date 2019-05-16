using FluentAssertions;

using NToolbox.Extensions.Strings;

using Xunit;

namespace NToolbox.Tests.Extensions.Strings
{
    public class RemoveDigitsTests
    {
        [Theory]
        [InlineData(null, null)]
        [InlineData("", "")]
        [InlineData("a1b2c3", "abc")]
        public void RemoveDigits_StringValue_ExpectedResult(string value, string expectedResult)
        {
            // Act
            var result = value.RemoveDigits();

            // Assert
            result.Should().Be(expectedResult);
        }
    }
}
