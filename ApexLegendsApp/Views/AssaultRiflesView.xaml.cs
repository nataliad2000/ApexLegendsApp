using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApexLegendsApp.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ApexLegendsApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AssaultRiflesView : ContentPage
    {
        public AssaultRiflesView()
        {
            InitializeComponent();
            BindingContext = new AssaultRiflesViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            (BindingContext as AssaultRiflesViewModel).OnAppearing();
        }
    }
}