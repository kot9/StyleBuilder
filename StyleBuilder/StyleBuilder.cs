using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StyleBuilder
{
    public class StyleBuilder
    {
        private readonly List<ClassBuilder> _classBuilders;

        public StyleBuilder(params ClassBuilder[] classBuilders)
        {
            if (classBuilders.Length == 0)
            {
                _classBuilders = new List<ClassBuilder>();
                return;
            }

            _classBuilders = classBuilders.ToList();
        }

        public string Build()
        {
            if (_classBuilders.Count == 0)
                return string.Empty;

            var sb = new StringBuilder();

            sb.Append("<style type=\"text/css\">");

            foreach (var cb in _classBuilders)
                sb.Append(cb.Build());

            sb.Append("<\\style>");

            return sb.ToString();
        }
    }
}