using CommandLine;

namespace Sentinel.StartUp
{
    public interface IOptions
    {
        [Option('p', "port")]
        int Port { get; set; }

        [Option('u', "udp", SetName = "protocols")]
        bool IsUdp { get; set; }
    }
}