using Sentinel.Views.Interfaces;

namespace Sentinel.Logger
{
    public interface IUdpLogViewer : ILogViewer
    {
        int Port { get; set; }
    }
}