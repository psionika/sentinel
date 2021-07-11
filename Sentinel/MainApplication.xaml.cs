using System.Windows;

using Sentinel.Properties;
using Sentinel.Services;
using Sentinel.Services.Interfaces;

namespace Sentinel
{
    /// <summary>
    /// Interaction logic for MainApplication.xaml.
    /// </summary>
    public partial class MainApplication : Application
    {
        /// <summary>
        /// Application Entry Point.
        /// </summary>
        [System.STAThread()]
        public static void Main()
        {
            MainApplication app = new MainApplication();

            app.InitializeComponent();
            app.Run();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MainApplication"/> class.
        /// </summary>
        public MainApplication()
        {
            Settings.Default.Upgrade();

            ServiceLocator locator = ServiceLocator.Instance;
            locator.ReportErrors = true;
            locator.Register<ISessionManager>(new SessionManager());

            // Request that the application close on main window close.
            ShutdownMode = ShutdownMode.OnMainWindowClose;
        }
    }
}