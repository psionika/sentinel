using System.Runtime.Serialization;

namespace Sentinel.Interfaces.Providers
{
    public interface IProviderSettings
    {
        [DataMember]
        string Name { get; }

        [DataMember]
        string Summary { get; }

        /// <summary>
        /// Gets reference back to the provider this setting is appropriate to.
        /// </summary>
        [DataMember]
        IProviderInfo Info { get; }
    }
}