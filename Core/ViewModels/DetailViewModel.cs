﻿using MugenMvvmToolkit.ViewModels;

namespace Core.ViewModels
{
    public class DetailViewModel : ViewModelBase
    {
        private string _text;

        public string Text
        {
            get { return _text; }
            set
            {
                if(_text == value) return;
                _text = value;
                OnPropertyChanged();
            }
        }
    }
}
