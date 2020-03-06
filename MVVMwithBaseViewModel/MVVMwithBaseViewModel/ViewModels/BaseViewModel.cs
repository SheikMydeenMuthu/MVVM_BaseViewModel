using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

using Xamarin.Forms;

using MVVMwithBaseViewModel.Models;
using MVVMwithBaseViewModel.Services;

namespace MVVMwithBaseViewModel.ViewModels
{
    public class BaseViewModel : BindableObject
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
        public virtual void Refresh()
        {

        }
        public virtual void CleanUp()
        {

        }        
    }
}
