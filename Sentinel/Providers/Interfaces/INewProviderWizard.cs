using System.Windows;

using Sentinel.Interfaces.Providers;

namespace Sentinel.Providers.Interfaces
{
    public interface INewProviderWizard
    {
        IProviderInfo Provider { get; }

        IProviderSettings Settings { get; }

        bool Display(Window parent);
    }
}