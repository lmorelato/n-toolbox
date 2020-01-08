using System.Collections.Generic;
using FluentAssertions;
using NToolbox.Extensions.Objects;
using Xunit;

namespace NToolbox.Tests.Extensions.Objects
{
    public class TrimSpacesTests
    {
        private const string InvalidValue = " value  ";
        private const string ValidValue = "value";

        [Fact]
        public void TrimSpaces_IncludeCustomTypesAndLists_TrimmedObject()
        {
            // arrange
            var obj = new TestClass();

            // act
            obj.TrimSpaces(true);

            // assert
            obj.Property1.Should().Be(ValidValue);
            obj.Property2.Should().BeNull();
            obj.Property3.Should().BeNull();

            obj.Custom.Property1.Should().Be(ValidValue);
            obj.Custom.Property2.Should().BeNull();
            obj.Custom.Property3.Should().BeNull();

            obj.List.ForEach(
                item =>
                {
                    item.Property1.Should().Be(ValidValue);
                    item.Property2.Should().BeNull();
                    item.Property3.Should().BeNull();
                });
        }

        [Fact]
        public void TrimSpaces_NullObject_NullObject()
        {
            // act
            ((TestClass)null).TrimSpaces();

            // assert
            ((TestClass)null).Should().BeNull();
        }

        private class TestClass
        {
            public string Property1 { get; set; } = InvalidValue;

            public string Property2 { get; set; } = string.Empty;

            public string Property3 { get; set; } = null;

            public CustomType Custom { get; set; } = new CustomType();

            public List<CustomType> List { get; set; } = new List<CustomType> { new CustomType(), new CustomType() };


            internal class CustomType
            {
                public string Property1 { get; set; } = InvalidValue;

                public string Property2 { get; set; } = string.Empty;

                public string Property3 { get; set; } = null;
            }
        }
    }
}
