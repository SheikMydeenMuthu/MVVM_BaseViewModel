using MVVMwithBaseViewModel.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MVVMwithBaseViewModel.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageAppearingPage : ContentPage
    {
        public PageAppearingPage()
        {
            InitializeComponent();
            BindingContext =new PageAppearingViewModel();
        }
    }
}