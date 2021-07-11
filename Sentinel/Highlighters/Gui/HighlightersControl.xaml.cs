﻿using System.Windows.Controls;

using Sentinel.Highlighters.Interfaces;
using Sentinel.Services;

namespace Sentinel.Highlighters.Gui
{
    /// <summary>
    /// Interaction logic for HighlightersControl.xaml.
    /// </summary>
    public partial class HighlightersControl : UserControl
    {
        public HighlightersControl()
        {
            InitializeComponent();
            Highlighters = ServiceLocator.Instance.Get<IHighlightingService<IHighlighter>>();
            DataContext = this;
        }

        public IHighlightingService<IHighlighter> Highlighters { get; private set; }
    }
}