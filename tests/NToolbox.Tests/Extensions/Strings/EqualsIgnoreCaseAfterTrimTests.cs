using FluentAssertions;

using NToolbox.Extensions.Strings;

using Xunit;

namespace NToolbox.Tests.Extensions.Strings
{
    public class EqualsIgnoreCaseAndTrimTests
    {
        [Theory]
        [InlineData(null, null, true)]
        [InlineData("", "", true)]
        [InlineData("", " ", true)]
        [InlineData("abc", "abc ", true)]
        [InlineData("abc", "abd", false)]
        [InlineData("abc", " abd", false)]
        public void EqualsIgnoreCaseAndTrim_WhenCalled_ExpectedValue(string a, string b, bool expectedResult)
        {
            // Act
            var result = a.EqualsIgnoreCaseAndTrim(b);

            // Assert
            result.Should().Be(expectedResult);
        }
    }
}
