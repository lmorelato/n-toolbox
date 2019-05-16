using FluentAssertions;

using NToolbox.Extensions.Strings;

using Xunit;

namespace NToolbox.Tests.Extensions.Strings
{
    public class RemoveLettersTests
    {
        [Theory]
        [InlineData(null, null)]
        [InlineData("", "")]
        [InlineData("a1b2c3", "123")]
        public void RemoveLetters_StringValue_ExpectedResult(string value, string expectedResult)
        {
            // Act
            var result = value.RemoveLetters();

            // Assert
            result.Should().Be(expectedResult);
        }
    }
}
