using Sentinel.Highlighters.Interfaces;
using Sentinel.Services;

namespace Sentinel.Controls
{
    /// <summary>
    /// Interaction logic for LogActivityControl.xaml.
    /// </summary>
    public partial class LogActivityControl
    {
        public LogActivityControl()
        {
            InitializeComponent();
            Highlight = ServiceLocator.Instance.Get<IHighlightingService<IHighlighter>>();
        }

        public IHighlightingService<IHighlighter> Highlight { get; private set; }
    }
}