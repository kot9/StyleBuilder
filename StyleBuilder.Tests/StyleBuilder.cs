using FluentAssertions;
using Xunit;

namespace StyleBuilder.Tests
{
    public class UnitTest1
    {
        private readonly ClassBuilder _classCb;
        private readonly ClassBuilder _classCb1;

        public UnitTest1()
        {
            _classCb = new ClassBuilder("body")
                .AddStyle("background-color", "#fffff");

            _classCb1 = new ClassBuilder(".wrapper", ".wrapper-container")
                .AddStyle("border-color", "#e3e3e3");
        }

        [Fact]
        public void CreationOfType_ReturnsEmptyStyleTag()
            => new StyleBuilder()
                .Build()
                .Should()
                .Be(string.Empty);

        [Fact]
        public void BuildStylesUsingOneClassBuilder()
            => new StyleBuilder(_classCb)
                .Build()
                .Should()
                .Be("<style type=\"text/css\">body { background-color:#fffff; }<\\style>");

        [Fact]
        public void BuildStylesUsingTwoClassBuilder()
            => new StyleBuilder(_classCb, _classCb1)
                .Build()
                .Should()
                .Be("<style type=\"text/css\">body { background-color:#fffff; }.wrapper .wrapper-container { border-color:#e3e3e3; }<\\style>");
    }
}