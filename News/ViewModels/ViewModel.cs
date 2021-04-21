using System;
using System.ComponentModel;

namespace News.ViewModels
{
    public abstract class ViewModel : INotifyPropertyChanged
    {
        public event PropertyChangingEventHandler PropertyChanged;
    }
}
