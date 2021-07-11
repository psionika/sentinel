using System;

namespace Sentinel.Interfaces.Providers
{
    public interface IProviderRegistrationRecord
    {
        Guid Identifier { get; }

        IProviderInfo Info { get; }

        Type Settings { get; }

        Type Implementer { get; }
    }
}