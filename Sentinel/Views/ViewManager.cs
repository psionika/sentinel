﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;

using Sentinel.Views.Gui;
using Sentinel.Views.Heartbeat;
using Sentinel.Views.Interfaces;

namespace Sentinel.Views
{
    public class ViewManager : IViewManager
    {
        private readonly Dictionary<IViewInformation, Type> registeredTypes = new Dictionary<IViewInformation, Type>();

        public ViewManager()
        {
            Register(LogMessages.Info, typeof(LogMessages));
            Register(MessageHeatBeat.Info, typeof(MessageHeatBeat));
        }

        /// <summary>
        /// Gets the observerable collection of the instances of a viewer main frame.
        /// </summary>
        public ObservableCollection<IWindowFrame> Viewers { get; } = new ObservableCollection<IWindowFrame>();

        public IEnumerable<IViewInformation> Registered => registeredTypes.Keys;

        public void Register(IViewInformation info, Type viewerType)
        {
            if (registeredTypes.Any(t => t.Key.Identifier == info.Identifier))
            {
                throw new NotSupportedException("Already have a registered viewer with the Id of " + info.Identifier);
            }

            // Validate that the type supports the necessary interface: ILogViewer
            var interfaceType = typeof(ILogViewer);
            if (viewerType.GetInterfaces().All(i => i != interfaceType))
            {
                throw new NotSupportedException($"Types registered in ViewManager must support the interface '{interfaceType}'");
            }

            // Populate the registration information.
            registeredTypes.Add(info, viewerType);
        }

        public IViewInformation Get(string identifier)
        {
            return registeredTypes.Keys.FirstOrDefault(v => v.Identifier == identifier);
        }

        public ILogViewer GetInstance(string identifier)
        {
            var registered = registeredTypes.Keys;

            Debug.Assert(
                registered.Concat(registered).Any(i => i.Identifier == identifier),
                "Identifier must be registered in the collection of views, either explicitly or by auto discovery");

            if (registered.Any(i => i.Identifier == identifier))
            {
                var t = registeredTypes.First(v => v.Key.Identifier == identifier).Value;

                // Create an instance of the type (must have a default constructor).
                return (ILogViewer)Activator.CreateInstance(t);
            }

            return null;
        }
    }
}