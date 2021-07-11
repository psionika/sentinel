using CommandLine;

namespace Sentinel.EventLogMonitor
{
    public class CommandLineOptions
    {
        [Option('b', "no-banner", Default = false, HelpText = "Hide the copyright banner shown on application startup")]
        public bool SuppressBanner { get; set; }
    }
}