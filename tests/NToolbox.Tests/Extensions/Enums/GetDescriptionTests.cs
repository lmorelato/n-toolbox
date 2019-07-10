using System;
using System.ComponentModel;
using FluentAssertions;
using NToolbox.Extensions.Enums;
using NToolbox.Extensions.Strings;
using Xunit;

namespace NToolbox.Tests.Extensions.Enums
{
    public class GetDescriptionTests
    {
        [Fact]
        public void GetDescription_ValueIsNull_ThrowsArgumentNullException()
        {
            Tests? enumItem = null;

            Action result = () => enumItem.GetDescription();

            result.Should().Throw<ArgumentNullException>();
        }

        [Fact]
        public void GetDescription_NoDescription_ReturnsStringValue()
        {
            var enumItem = Tests.Some;

            var result = enumItem.GetDescription();

            result.Should().Be(nameof(Tests.Some));
        }

        [Fact]
        public void GetDescription_FieldValueIsValid_ReturnsDescription()
        {
            var enumItem = Tests.Any;

            var result = enumItem.GetDescription();

            result.Should().Be("Any description");
        }
    }

    internal enum Tests
    {
        [Description("Any description")]
        Any,
        Some,
        Bar
    }
}
