using System.Collections.Generic;

using Sentinel.Interfaces;

namespace Sentinel.Logs.Interfaces
{
    public interface ILogManager : IEnumerable<ILogger>
    {
        ILogger Add(string logName);

        ILogger Get(string name);

        void Remove(string name);
    }
}