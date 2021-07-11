﻿using System.Collections.ObjectModel;
using System.Runtime.Serialization;

using Sentinel.Interfaces;

namespace Sentinel.Extractors.Interfaces
{
    public interface IExtractingService<T>
    {
        [DataMember]
        ObservableCollection<T> Extractors { get; set; }

        [IgnoreDataMember]
        ObservableCollection<T> SearchExtractors { get; set; }

        bool IsFiltered(ILogEntry entry);
    }
}