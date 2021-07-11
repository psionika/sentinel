using Sentinel.Interfaces.Providers;

namespace Sentinel.Log4Net
{
    public interface IUdpAppenderListenerSettings : IProviderSettings
    {
        int Port { get; set; }
    }
}