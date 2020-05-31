using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ApexLegendsApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MasterDetailMenuDetailMasterMaster : ContentPage
    {
        public ListView ListView;

        public MasterDetailMenuDetailMasterMaster()
        {
            InitializeComponent();

            BindingContext = new MasterDetailMenuDetailMasterMasterViewModel();
            ListView = MenuItemsListView;
        }

        class MasterDetailMenuDetailMasterMasterViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<MasterDetailMenuDetailMasterMenuItem> MenuItems { get; set; }

            public MasterDetailMenuDetailMasterMasterViewModel()
            {
                MenuItems = new ObservableCollection<MasterDetailMenuDetailMasterMenuItem>(new[]
                {
                    new MasterDetailMenuDetailMasterMenuItem { Id = 0, Title = "Page 1" },
                    new MasterDetailMenuDetailMasterMenuItem { Id = 1, Title = "Page 2" },
                    new MasterDetailMenuDetailMasterMenuItem { Id = 2, Title = "Page 3" },
                    new MasterDetailMenuDetailMasterMenuItem { Id = 3, Title = "Page 4" },
                    new MasterDetailMenuDetailMasterMenuItem { Id = 4, Title = "Page 5" },
                });
            }

            #region INotifyPropertyChanged Implementation
            public event PropertyChangedEventHandler PropertyChanged;
            void OnPropertyChanged([CallerMemberName] string propertyName = "")
            {
                if (PropertyChanged == null)
                    return;

                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
            #endregion
        }
    }
}