using System.Runtime.Serialization;
using System.Windows.Media;

using Newtonsoft.Json;

using Sentinel.Interfaces;

using Sentinel.WpfExtras;

namespace Sentinel.Highlighters
{
    [DataContract]
    public class HighlighterStyle : ViewModelBase, IHighlighterStyle
    {
        private Color? background;

        private Color? foreground;

        [DataMember]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public Color? Background
        {
            get
            {
                return background;
            }

            set
            {
                if (value != background)
                {
                    background = value;
                    OnPropertyChanged(nameof(Background));
                }
            }
        }

        [DataMember]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public Color? Foreground
        {
            get
            {
                return foreground;
            }

            set
            {
                if (value != foreground)
                {
                    foreground = value;
                    OnPropertyChanged(nameof(Foreground));
                }
            }
        }
    }
}