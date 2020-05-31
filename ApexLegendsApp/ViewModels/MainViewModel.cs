using System;
using System.Windows.Input;
using ApexLegendsApp.Views;
using Xamarin.Forms;

namespace ApexLegendsApp.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        public MainViewModel()
        {
            _goToWeaponsCommand = new Command(PerformWeaponsCommand);
            _goToServerStatusCommand = new Command(PerformServerStatusCommand);
            _goToConsumable = new Command(PerformGoToEquipCommand);
        }

        private void PerformGoToEquipCommand(object obj)
            => App.Current.MainPage.Navigation.PushAsync(new EquipView());
      

        private void PerformWeaponsCommand(object obj)
            => App.Current.MainPage.Navigation.PushAsync(new WeaponsView());

        private void PerformServerStatusCommand(object obj)
            => App.Current.MainPage.Navigation.PushAsync(new ServerStatusView());

        private Command _goToServerStatusCommand;
        private Command _goToWeaponsCommand;
        private Command _goToConsumable;
        public ICommand GoToServerStatusCommand => _goToServerStatusCommand;
        public ICommand GoToWeaponsCommand => _goToWeaponsCommand;
        public ICommand GoToEquipCommand => _goToConsumable;
    }
}