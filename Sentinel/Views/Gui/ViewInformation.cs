using Sentinel.Views.Interfaces;

namespace Sentinel.Views.Gui
{
    public class ViewInformation : IViewInformation
    {
        public ViewInformation(string identifier, string name)
        {
            Identifier = identifier;
            Name = name;
        }

        public string Identifier { get; private set; }

        public string Name { get; private set; }

        public string Description { get; set; }
    }
}