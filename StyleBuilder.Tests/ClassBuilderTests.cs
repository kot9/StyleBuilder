using FluentAssertions;
using Xunit;

namespace StyleBuilder.Tests
{
    public class ClassBuilderTests
    {
        [Fact]
        public void ItWorks()
            => new ClassBuilder(".wrapper", ".wrapper-content")
                .Build()
                .Should()
                .Be(".wrapper .wrapper-content {  }");

        [Fact]
        public void AddStyle()
            => new ClassBuilder(".wrapper", ".wrapper-content")
                .AddStyle("background-color", "#ffff")
                .Build()
                .Should()
                .Be(".wrapper .wrapper-content { background-color:#ffff; }");

        [Fact]
        public void AddBunchOfStyles()
            => new ClassBuilder(".wrapper", ".wrapper-content")
                .AddStyle("background-color", "#ffff")
                .AddStyle("border-color", "#e3e3e3")
                .Build()
                .Should()
                .Be(".wrapper .wrapper-content { background-color:#ffff;border-color:#e3e3e3; }");

        //TODO should be added negative cases and unusual usage
    }
}