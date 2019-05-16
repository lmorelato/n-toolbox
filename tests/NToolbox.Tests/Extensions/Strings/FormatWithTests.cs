using FluentAssertions;

using NToolbox.Extensions.Strings;

using Xunit;

namespace NToolbox.Tests.Extensions.Strings
{
    public class FormatWithTests
    {
        [Theory]
        [InlineData(null)]
        [InlineData(" ")]
        public void FormatWith_ValueIsNullOrWhiteSpace_ReturnsValue(string value)
        {
            var result = value.FormatWith(string.Empty);

            result.Should().Be(value);
        }

        [Fact]
        public void FormatWith_EmptyValues_ReturnsTemplate()
        {
            var template = "{0}.{1}";

            var result = template.FormatWith();

            result.Should().Be(template);
        }

        [Fact]
        public void FormatWith_ValidValues_ReturnsFormattedString()
        {
            var template = "{0}.{1}";
            var values = new object[] { "a", "b" };
            var expectedResult = string.Format(template, values);

            var result = template.FormatWith(values);

            result.Should().Be(expectedResult);
        }
    }
}
