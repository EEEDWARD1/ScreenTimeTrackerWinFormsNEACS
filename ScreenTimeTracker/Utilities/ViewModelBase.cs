using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace ScreenTimeTracker.Utilities
{
    //This is an implementation of the INotifyPropertyChanged interface using the ViewModelBase class.
    //The ViewModelBase class is a base class that provides a common implementation for view models in a WPF or MVVM application.
    class ViewModelBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string propName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }
    }
}
