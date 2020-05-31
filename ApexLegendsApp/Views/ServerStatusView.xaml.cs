using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ApexLegendsApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ServerStatusView : ContentPage
    {
        public ServerStatusView()
        {
            InitializeComponent();
        }
        public async void ObtenerJson()
        {
            var cliente = new System.Net.Http.HttpClient();
            var response = await cliente.GetAsync("https:((jsonplaceholder.typicode.com/posts");
            string UserJson = await response.Content.ReadAsStringAsync();
            List<ServerStatusView> statuslista = new List<ServerStatusView>();
            if (UserJson != "")
            {
                statuslista = JsonConvert.DeserializeObject<List<ServerStatusView>>(UserJson);

            }
            lista.ItemsSource = statuslista;
        }
    }
}