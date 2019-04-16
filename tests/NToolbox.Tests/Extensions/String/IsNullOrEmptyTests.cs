﻿using FluentAssertions;

using NToolbox.Extensions.String;

using Xunit;

namespace NToolbox.Tests.Extensions.String
{
    public class IsNullOrEmptyTests
    {
        [Theory]
        [InlineData(null)]
        [InlineData("")]
        public void IsNullOrEmpty_NullOrEmptyValue_True(string value)
        {
            // Arrange
            var expectedResult = string.IsNullOrEmpty(value);

            // Act
            var result = value.IsNullOrEmpty();

            // Assert
            result.Should().Be(expectedResult);
        }

        [Theory]
        [InlineData("abc")]
        public void IsNullOrEmpty_NotNullOrEmptyValue_True(string value)
        {
            // Arrange
            var expectedResult = string.IsNullOrEmpty(value);

            // Act
            var result = value.IsNullOrEmpty();

            // Assert
            result.Should().Be(expectedResult);
        }
    }
}
