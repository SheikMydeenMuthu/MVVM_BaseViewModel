using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

using Xamarin.Forms;

using MVVMwithBaseViewModel.Models;
using MVVMwithBaseViewModel.Services;

namespace MVVMwithBaseViewModel.ViewModels
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        public Command RefreshCommand
        {
            get
            {
                return new Command(() =>
                {
                    Refresh();
                });
            }
        }
        public Command CleanUpCommand
        {
            get
            {
                return new Command(() =>
                {
                    CleanUp();
                });
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName]string PropertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs((PropertyName)));
        }

        public virtual void Refresh()
        {

        }
        public virtual void CleanUp()
        {

        }        
    }
}
