﻿using System;

using Sentinel.Interfaces.Providers;

namespace Sentinel.Providers
{
    public class ProviderRegistrationRecord : IProviderRegistrationRecord
    {
        public Guid Identifier { get; set; }

        public IProviderInfo Info { get; set; }

        public Type Settings { get; set; }

        public Type Implementer { get; set; }
    }
}
