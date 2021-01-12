using System.Text;

namespace StyleBuilder
{
    public class ClassBuilder
    {
        private readonly StringBuilder _classHolder;

        public ClassBuilder(params string[] classNames)
        {
            if (classNames.Length == 0)
                return;

            _classHolder = new StringBuilder();

            foreach (var cn in classNames)
                _classHolder.Append($"{cn} ");

            _classHolder.Append("{ ");
        }

        public ClassBuilder AddStyle(string style, string styleValue)
        {
            _classHolder.Append($"{style}:{styleValue}");
            _classHolder.Append(";");
            return this;
        }

        public string Build()
        {
            _classHolder.Append(" }");
            return _classHolder.ToString();
        }
    }
}