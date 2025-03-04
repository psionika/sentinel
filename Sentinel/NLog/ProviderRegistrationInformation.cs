using System;

using Sentinel.Interfaces.Providers;

namespace Sentinel.NLog
{
    public class ProviderRegistrationInformation : IProviderRegistrationRecord
    {
        public ProviderRegistrationInformation(IProviderInfo providerInfo)
        {
            Info = providerInfo;
        }

        public Guid Identifier => Info.Identifier;

        public IProviderInfo Info { get; private set; }

        public Type Settings => typeof(NetworkConfigurationPage);

        public Type Implementer => typeof(NLogViewerProvider);
    }
}