using System.Collections.Generic;

using Sentinel.Interfaces;

namespace Sentinel.Highlighters.Interfaces
{
    public interface ISearchHighlighter
    {
        IEnumerable<LogEntryFields> Fields { get; }

        LogEntryFields Field { get; set; }

        bool Enabled { get; set; }

        MatchMode Mode { get; set; }

        IHighlighter Highlighter { get; }

        string Search { get; set; }
    }
}