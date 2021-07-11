using Sentinel.Images;

namespace Sentinel.Support.Converters
{
    public class TypeToSmallImageConverter : TypeToImageConverter
    {
        public TypeToSmallImageConverter()
        {
            Quality = ImageQuality.Small;
        }
    }
}