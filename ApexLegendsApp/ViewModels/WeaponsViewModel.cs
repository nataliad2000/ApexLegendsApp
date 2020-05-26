using System.Windows.Input;
using ApexLegendsApp.Views;
using Xamarin.Forms;

namespace ApexLegendsApp.ViewModels
{
    public class WeaponsViewModel : BaseViewModel
    {
        public WeaponsViewModel()
        {
            _goToAssaultRifles = new Command(PeformGoToWeapons);
        }

        private void PeformGoToWeapons(object obj)
            => App.Current.MainPage.Navigation.PushAsync(new AssaultRiflesView());

        private Command _goToAssaultRifles;

        public Command GoToAssaultRiflesCommand => _goToAssaultRifles;
    }
}