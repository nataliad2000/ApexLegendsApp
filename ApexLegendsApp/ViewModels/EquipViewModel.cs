using ApexLegendsApp.Views;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace ApexLegendsApp.ViewModels
{
    public class EquipViewModel:BaseViewModel
    {
        private Command _goToConsumables;
        public Command GoToConsumables => _goToConsumables;

        public EquipViewModel()
        {
            _goToConsumables = new Command(PerformGoToConsumables);
        }

        private void PerformGoToConsumables(object obj)
        {
           App.Current.MainPage.Navigation.PushAsync(new ConsumableView())
        }
    }

}
