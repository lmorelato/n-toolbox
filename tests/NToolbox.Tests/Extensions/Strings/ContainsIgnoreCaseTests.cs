using FluentAssertions;

using NToolbox.Extensions.Strings;

using Xunit;

namespace NToolbox.Tests.Extensions.Strings
{
    public class ContainsIgnoreCaseTests
    {
        [Theory]
        [InlineData(null, "a", false)]
        [InlineData("a", null, false)]
        [InlineData("abc", "d", false)]
        [InlineData("abc", "ab", true)]
        public void ContainsIgnoreCase_WhenCalled_ExpectedValue(string a, string b, bool expectedResult)
        {
            // Act
            var result = a.ContainsIgnoreCase(b);

            // Assert
            result.Should().Be(expectedResult);
        }
    }
}
