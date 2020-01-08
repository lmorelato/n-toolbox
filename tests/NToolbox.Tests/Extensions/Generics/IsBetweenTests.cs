using FluentAssertions;
using NToolbox.Extensions.Generic;
using Xunit;

namespace NToolbox.Tests.Extensions.Generics
{
    public class IsBetweenTests
    {
        [Theory]
        [InlineData(5.5, 5.5, 5.5, true)]
        [InlineData(5.5, 5.5, 9.9, true)]
        [InlineData(5.5, 2.1, 5.5, true)]
        [InlineData(5.5, 2.1, 9.9, true)]
        [InlineData(5.5, 1.1, 2.9, false)]
        public void ContainsIgnoreCase_DecimalValue_ExpectedValue(decimal value, decimal start, decimal end, bool expectedResult)
        {
            // Act
            var result = value.IsBetween(start, end);

            // Assert
            result.Should().Be(expectedResult);
        }

        [Theory]
        [InlineData(5, 5, 5, true)]
        [InlineData(5, 5, 9, true)]
        [InlineData(5, 2, 5, true)]
        [InlineData(5, 2, 9, true)]
        [InlineData(5, 1, 2, false)]
        public void ContainsIgnoreCase_IntValue_ExpectedValue(int value, int start, int end, bool expectedResult)
        {
            // Act
            var result = value.IsBetween(start, end);

            // Assert
            result.Should().Be(expectedResult);
        }

        [Theory]
        [InlineData("b", "a", "c", true)]
        [InlineData("c", "a", "b", false)]
        public void ContainsIgnoreCase_StringValue_ExpectedValue(string value, string start, string end, bool expectedResult)
        {
            // Act
            var result = value.IsBetween(start, end);

            // Assert
            result.Should().Be(expectedResult);
        }
    }
}
