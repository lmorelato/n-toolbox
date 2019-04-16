﻿using FluentAssertions;

using NToolbox.Extensions.String;

using Xunit;

namespace NToolbox.Tests.Extensions.String
{
    public class IsNotNullOrWhiteSpaceTests
    {
        [Theory]
        [InlineData("abc")]
        public void IsNotNullOrWhiteSpace_NotNullOrEmptyValue_True(string value)
        {
            // Arrange
            var expectedResult = !string.IsNullOrWhiteSpace(value);

            // Act
            var result = value.IsNotNullOrWhiteSpace();

            // Assert
            result.Should().Be(expectedResult);
        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        [InlineData(" ")]
        public void IsNotNullOrEmpty_NullOrEmptyValue_True(string value)
        {
            // Arrange
            var expectedResult = !string.IsNullOrWhiteSpace(value);

            // Act
            var result = value.IsNotNullOrWhiteSpace();

            // Assert
            result.Should().Be(expectedResult);
        }
    }
}
