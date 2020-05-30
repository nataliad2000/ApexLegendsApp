using System.Collections.Generic;
using ApexLegendsApp.Model;
using Xamarin.Forms;

namespace ApexLegendsApp.ViewModels
{
    public class BaseViewModel : BindableObject
    {
        public virtual void OnAppearing()
        {
            
        }
        protected void SetValue<T>(ref T backingField , T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(backingField, value))
            {
                return "";
            }
            backingField = value;
            RaisePropertyChanged(propertyName);
        }
    }
}