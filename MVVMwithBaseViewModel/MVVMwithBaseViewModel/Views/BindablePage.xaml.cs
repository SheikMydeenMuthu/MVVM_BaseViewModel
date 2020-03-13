using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVVMwithBaseViewModel.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MVVMwithBaseViewModel.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BindablePage : ContentPage
    {
        public BindablePage()
        {
            InitializeComponent();
            BindingContext = new BindableViewModel();
        }
    }
}