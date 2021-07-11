using System.Collections.ObjectModel;
using System.Runtime.Serialization;

using Sentinel.Interfaces;

namespace Sentinel.Filters.Interfaces
{
    public interface IFilteringService<T>
    {
        [DataMember]
        ObservableCollection<T> Filters { get; set; }

        ObservableCollection<T> SearchFilters { get; set; }

        bool IsFiltered(ILogEntry entry);
    }
}