using System.Runtime.Serialization;

using Sentinel.Extractors.Interfaces;
using Sentinel.Interfaces;

namespace Sentinel.Extractors
{
    [DataContract]
    public class SearchExtractor
        : Extractor, IDefaultInitialisation, ISearchExtractor
    {
        public void Initialise()
        {
            Name = "SearchExtractor";
            Field = LogEntryFields.System;
            Pattern = string.Empty;
        }
    }
}