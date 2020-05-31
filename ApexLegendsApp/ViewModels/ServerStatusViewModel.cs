using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace ApexLegendsApp.ViewModels
{
    public class ServerStatusViewModel
    {
        private string _status;
        public string status => _status;
        public async void datos()
        {
            var resultadoApi = await new HttpClient().GetStringAsync("https://apexlegendsapi.com/servers.json");
            _status = JsonConvert.DeserializeObject<string>(resultadoApi);
        }
    }
}
