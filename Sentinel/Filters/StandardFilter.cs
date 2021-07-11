using Sentinel.Filters.Interfaces;
using Sentinel.Interfaces;

namespace Sentinel.Filters
{
    public class StandardFilter : Filter, IStandardDebuggingFilter
    {
        public StandardFilter(string name, LogEntryFields field, string pattern)
            : base(name, field, pattern)
        {
        }
    }
}