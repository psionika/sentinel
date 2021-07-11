using System.Windows.Controls;
using System.Windows.Threading;

namespace Sentinel.Support.Wpf
{
    public class DataBoundToolbar : ToolBar
    {
        private delegate void InvalidateMeasurementDelegate();

        public override void OnApplyTemplate()
        {
            Dispatcher.BeginInvoke(
                new InvalidateMeasurementDelegate(InvalidateMeasure),
                DispatcherPriority.Background,
                null);
            base.OnApplyTemplate();
        }
    }
}