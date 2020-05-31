using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using ApexLegendsApp.Model;
using ApexLegendsApp.ViewModels;
using Newtonsoft.Json;

namespace ApexLegendsApp.Services
{
    public class GameDataApiService : IGameDataAPIService
    {
        private const string AssaultRifles = "assault_rifles";
        private const string Equip = "consumables";
        private HttpClient _httpClient = new HttpClient();

        public async Task<List<Equip>> GetConsumables()
        {
            var url = GetUrl(Equip, Keys.ApiKey);
            var response = await _httpClient.GetStringAsync(url);
            return JsonConvert.DeserializeObject<List<Equip>>(response);
        }
        public async Task<List<Weapon>> GetAssaultRifles()
        {
            var url = GetUrl(AssaultRifles, Keys.ApiKey);
            var response = await _httpClient.GetStringAsync(url);
            return JsonConvert.DeserializeObject<List<Weapon>>(response);
        }
        
        
        private string GetUrl(string type, string apiKey) => Keys.GameDataApi
            .Replace("{DATATYPE}", type)
            .Replace("{YOURAPIKEY}", Keys.ApiKey);

    }
}