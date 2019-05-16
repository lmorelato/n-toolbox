using FluentAssertions;

using NToolbox.Extensions.Strings;

using Xunit;

namespace NToolbox.Tests.Extensions.Strings
{
    public class EqualsIgnoreCaseTests
    {
        [Theory]
        [InlineData("a", "a", true)]
        [InlineData("aaa", "aAa", true)]
        [InlineData("a", "b", false)]
        [InlineData("", "", true)]
        [InlineData(null, null, true)]
        public void EqualsIgnoreCase_ValidValue_ReturnsExpectedResult(string value1, string value2, bool expectedResult)
        {
            var result = value1.EqualsIgnoreCase(value2);

            result.Should().Be(expectedResult);
        }
    }
}
