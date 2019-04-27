using FluentAssertions;

using NToolbox.Extensions.Strings;

using Xunit;

namespace NToolbox.Tests.Extensions.Strings
{
    public class ContainsIgnoreCaseAfterTrimTests
    {
        [Theory]
        [InlineData(null, " a", false)]
        [InlineData("abc ", null, false)]
        [InlineData("abc ", " d", false)]
        [InlineData("abc ", " a", true)]
        [InlineData("abc  ", "  a", true)]
        public void ContainsIgnoreCaseAfterTrim_WhenCalled_ExpectedValue(string a, string b, bool expectedResult)
        {
            // Act
            var result = a.ContainsIgnoreCaseAfterTrim(b);

            // Assert
            result.Should().Be(expectedResult);
        }
    }
}
