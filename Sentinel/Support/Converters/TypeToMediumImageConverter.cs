using Sentinel.Images;

namespace Sentinel.Support.Converters
{
    public class TypeToMediumImageConverter : TypeToImageConverter
    {
        public TypeToMediumImageConverter()
        {
            Quality = ImageQuality.Medium;
        }
    }
}