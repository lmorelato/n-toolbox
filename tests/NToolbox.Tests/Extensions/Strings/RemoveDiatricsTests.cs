using FluentAssertions;

using NToolbox.Extensions.Strings;

using Xunit;

namespace NToolbox.Tests.Extensions.Strings
{
    public class RemoveDiatricsTests
    {
        [Theory]
        [InlineData(null, null)]
        [InlineData("", "")]
        [InlineData("ãéìòû", "aeiou")]
        public void RemoveDiatrics_StringValue_ExpectedResult(string value, string expectedResult)
        {
            // Act
            var result = value.RemoveDiacritics();

            // Assert
            result.Should().Be(expectedResult);
        }
    }
}
