using FluentAssertions;

using NToolbox.Extensions.Strings;

using Xunit;

namespace NToolbox.Tests.Extensions.Strings
{
    public class IsValidEmailAddressTests
    {
        [Theory]
        [InlineData(null, false)]
        [InlineData("", false)]
        [InlineData("abc", false)]
        [InlineData("abc.com", false)]
        [InlineData("abc@com", false)]
        [InlineData("abc@abc.com", true)]
        [InlineData("abc@abc.com.br", true)]
        public void IsValidEmailAddress_StringValue_ExpectedValue(string email, bool expectedResult)
        {
            // Act
            var result = email.IsValidEmailAddress();

            // Assert
            result.Should().Be(expectedResult);
        }
    }
}
