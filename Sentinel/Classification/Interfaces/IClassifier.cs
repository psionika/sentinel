using System.Runtime.Serialization;

using Sentinel.Interfaces;

namespace Sentinel.Classification.Interfaces
{
    public interface IClassifier
    {
        [DataMember]
        string Name { get; set; }

        [DataMember]
        string Type { get; set; }

        [DataMember]
        bool Enabled { get; set; }

        [DataMember]
        string Pattern { get; set; }

        [DataMember]
        string Description { get; }

        [DataMember]
        LogEntryFields Field { get; set; }

        [DataMember]
        MatchMode Mode { get; set; }

        bool IsMatch(ILogEntry entry);

        ILogEntry Classify(ILogEntry entry);
    }
}