using FluentAssertions;

using NToolbox.Extensions.Strings;

using Xunit;

namespace NToolbox.Tests.Extensions.Strings
{
    public class SafeTrimTests
    {
        [Theory]
        [InlineData(null, null)]
        [InlineData(" abc ", "abc")]
        [InlineData("", "")]
        public void SafeTrim_StringValue_ExpectedResult(string value, string expectedResult)
        {
            // Act
            var result = value.SafeTrim();

            // Assert
            result.Should().Be(expectedResult);
        }
    }
}
