using Sentinel.Images;

namespace Sentinel.Support.Converters
{
    public class TypeToLargeImageConverter : TypeToImageConverter
    {
        public TypeToLargeImageConverter()
        {
            Quality = ImageQuality.Large;
        }
    }
}