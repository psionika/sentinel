using System.Runtime.Serialization;

using Sentinel.Interfaces.Providers;

namespace Sentinel.NLog
{
    public interface INLogAppenderSettings : IProviderSettings
    {
        [DataMember]
        NetworkProtocol Protocol { get; set; }

        [DataMember]
        int Port { get; set; }
    }
}