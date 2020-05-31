using ApexLegendsApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ApexLegendsApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EquipView : ContentPage
    {
        public EquipView()
        {
            InitializeComponent();
            BindingContext = new EquipViewModel();
        }
    }
}