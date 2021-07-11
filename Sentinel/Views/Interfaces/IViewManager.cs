using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Sentinel.Views.Interfaces
{
    public interface IViewManager
    {
        ObservableCollection<IWindowFrame> Viewers { get; }

        IEnumerable<IViewInformation> Registered { get; }

        void Register(IViewInformation info, Type viewerType);

        IViewInformation Get(string identifier);

        ILogViewer GetInstance(string identifier);
    }
}