using ApexLegendsApp.Model;
using ApexLegendsApp.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApexLegendsApp.ViewModels
{
    public class ConsumableViewModel:BaseViewModel
    {
        private readonly GameDataApiService _gameDataApiService;
        public ConsumableViewModel()
        {

            _gameDataApiService = Locator.Load<IGameDataAPIService>();
        }
        private List<Equip> _equip;
        public List<Equip> equip
        {
            get => _equip;
            set => SetValue(ref _equip, value);
        }
        public override async void OnAppearing()
        {
            base.OnAppearing();
            equip = await _gameDataApiService.GetConsumables();
        }
    }
}
