using Sentinel.Highlighters.Interfaces;
using Sentinel.Interfaces;

namespace Sentinel.Highlighters
{
    public class StandardHighlighter : Highlighter, IStandardDebuggingHighlighter
    {
        public StandardHighlighter(string name, bool enabled, LogEntryFields field, MatchMode mode, string pattern, IHighlighterStyle style)
            : base(name, enabled, field, mode, pattern, style)
        {
        }
    }
}