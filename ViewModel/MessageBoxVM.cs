﻿using System.Windows;

namespace AdminArchive.ViewModel
{
    internal class MessageBoxVM : BaseViewModel
    {
        private string _text;
        private string _title;
        private Visibility _elVisibility;
        private Visibility _infoVisibility;
        private Visibility _errorVisibility;
        private bool _isOKVisible;
        private bool _isYesVisible;
        private bool _isNoVisible;

        // public properties to represent the model
        public string Text
        {
            get => _text;
            set { _text = value; OnPropertyChanged(nameof(Text)); }
        }

        public string Title
        {
            get => _title;
            set { _title = value; OnPropertyChanged(nameof(Title)); }
        }

        public Visibility ElVisibility
        {
            get => _elVisibility;
            set { _elVisibility = value; OnPropertyChanged(nameof(ElVisibility)); }
        }

        public Visibility InfoVisibility
        {
            get => _infoVisibility;
            set { _infoVisibility = value; OnPropertyChanged(nameof(InfoVisibility)); }
        }

        public Visibility ErrorVisibility
        {
            get => _errorVisibility;
            set { _errorVisibility = value; OnPropertyChanged(nameof(ErrorVisibility)); }
        }

        public bool IsOKVisible
        {
            get => _isOKVisible;
            set { _isOKVisible = value; OnPropertyChanged(nameof(IsOKVisible)); }
        }

        public bool IsYesVisible
        {
            get => _isYesVisible;
            set { _isYesVisible = value; OnPropertyChanged(nameof(IsYesVisible)); }
        }

        public bool IsNoVisible
        {
            get => _isNoVisible;
            set { _isNoVisible = value; OnPropertyChanged(nameof(IsNoVisible)); }
        }
    }
}
