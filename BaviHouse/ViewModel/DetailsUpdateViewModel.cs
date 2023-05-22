using BaviHouse.DataBase;
using BaviHouse.Model;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaviHouse.ViewModel
{
    [QueryProperty("Apartment", "Apartment")]
    public partial class DetailsUpdateViewModel : ObservableObject
    {
        public DetailsUpdateViewModel() 
        {

        }

        [ObservableProperty]
        Apartment apartment;

        [RelayCommand]
        async Task GoBack()
        {
            await Shell.Current.GoToAsync("..");
        }

        public static void GoMain()
        {
            Shell.Current.GoToAsync("../..");
        }
    }
}
