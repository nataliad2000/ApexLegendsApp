using System.Collections.Generic;
using ApexLegendsApp.Model;
using ApexLegendsApp.Services;

namespace ApexLegendsApp.ViewModels
{
    public class AssaultRiflesViewModel : BaseViewModel
    {
        private readonly IGameDataAPIService _gameDataApiService;

        public AssaultRiflesViewModel()
        {
            _gameDataApiService = new GameDataApiService();
        }

        private List<Weapon> _weapons;

        public List<Weapon> Weapons
        {
            get => _weapons;
          set=>SetValue(ref _weapons,value);
        }

        public override async void OnAppearing()
        {
            base.OnAppearing();
            Weapons = await _gameDataApiService.GetAssaultRifles();
        }
    }
}