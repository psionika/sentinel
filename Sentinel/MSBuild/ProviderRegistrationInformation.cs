using System;

using Sentinel.Interfaces.Providers;

namespace Sentinel.MSBuild
{
    public class ProviderRegistrationInformation : IProviderRegistrationRecord
    {
        public ProviderRegistrationInformation(IProviderInfo providerInfo)
        {
            Info = providerInfo;
        }

        public Guid Identifier => Info.Identifier;

        public IProviderInfo Info { get; private set; }

        public Type Settings => typeof(ConfigurationPage);

        public Type Implementer => typeof(MsBuildProvider);
    }
}