using System;

namespace StyleBuilder
{
    internal static class Program
    {
        private static void Main()
        {
            var classBuilder =
                new ClassBuilder(".container")
                    .AddStyle("background-color", "#ffff")
                    .AddStyle("border-color", "#dddd");

            var styleBuilder =
                new StyleBuilder(classBuilder)
                    .Build();

            // prints: <style type="text/css">.container { background-color:#ffff;border-color:#dddd; }<\style>
            Console.WriteLine(styleBuilder);
        }
    }
}