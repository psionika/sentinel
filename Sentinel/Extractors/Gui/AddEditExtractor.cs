﻿using System.Windows;
using System.Windows.Input;

using Sentinel.Interfaces;

using Sentinel.WpfExtras;

namespace Sentinel.Extractors.Gui
{
    public class AddEditExtractor : ViewModelBase
    {
        private readonly Window window;

        private string name = "Unnamed";

        private string pattern = "pattern";

        private LogEntryFields field;

        private MatchMode mode;

        public AddEditExtractor(Window window, bool editMode)
        {
            this.window = window;
            if (window != null)
            {
                window.Title = $"{(editMode ? "Edit" : "Register")} Extractor";
            }

            Accept = new DelegateCommand(AcceptDialog, Validates);
            Reject = new DelegateCommand(RejectDialog);
        }

        public ICommand Accept { get; private set; }

        public LogEntryFields Field
        {
            get
            {
                return field;
            }

            set
            {
                field = value;
                OnPropertyChanged(nameof(Field));
            }
        }

        public MatchMode Mode
        {
            get
            {
                return mode;
            }

            set
            {
                mode = value;
                OnPropertyChanged(nameof(Mode));
            }
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                if (name != value)
                {
                    name = value;
                    OnPropertyChanged(nameof(Name));
                }
            }
        }

        public string Pattern
        {
            get
            {
                return pattern;
            }

            set
            {
                if (value != pattern)
                {
                    pattern = value;
                    OnPropertyChanged(nameof(Pattern));
                }
            }
        }

        public ICommand Reject { get; private set; }

        private void AcceptDialog(object obj)
        {
            window.DialogResult = true;
            window.Close();
        }

        private void RejectDialog(object obj)
        {
            window.DialogResult = false;
            window.Close();
        }

        private bool Validates(object obj)
        {
            return Name.Length > 0 && Pattern.Length > 0;
        }
    }
}