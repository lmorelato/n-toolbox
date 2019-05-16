using System.Collections.Generic;
using System.Linq;
using FluentAssertions;
using NToolbox.Extensions.Enumerables;
using Xunit;

namespace NToolbox.Tests.Extensions.Enumerables
{
    public class JoinByTests
    {
        [Fact]
        public void JoinBy_ValidList_ListJoinedBySeparator()
        {
            // Arrange
            var separator = "#";
            var list = new List<string>() { "a", "b", "c" };
            var expectedResult = string.Join(separator, list);

            // Act
            var result = list.JoinBy(separator);

            // Assert
            result.Should().Be(expectedResult);
        }

        [Fact]
        public void JoinBy_ValidListAndPredicate_ListJoinedBySeparator()
        {
            // Arrange
            var separator = "#";
            var list = new[] { new { value = "a" }, new { value = "b" }, new { value = "c" } };
            var expectedResult = string.Join(separator, list.Select(x => x.value));

            // Act
            var result = list.JoinBy(x => x.value, separator);

            // Assert
            result.Should().Be(expectedResult);
        }

        [Fact]
        public void JoinByComma_ValidList_ListJoinedByComma()
        {
            // Arrange
            var list = new List<string>() { "a", "b", "c" };
            var expectedResult = string.Join(",", list);

            // Act
            var result = list.JoinByComma();

            // Assert
            result.Should().Be(expectedResult);
        }

        [Fact]
        public void JoinByComma_ValidListAndPredicate_ListJoinedByComma()
        {
            // Arrange
            var list = new[] { new { value = "a" }, new { value = "b" }, new { value = "c" } };
            var expectedResult = string.Join(",", list.Select(x => x.value));

            // Act
            var result = list.JoinByComma(x => x.value);

            // Assert
            result.Should().Be(expectedResult);
        }
    }
}
