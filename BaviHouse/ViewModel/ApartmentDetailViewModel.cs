using BaviHouse.Model;
using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BaviHouse.ViewModel
{
    [QueryProperty("Apartment","Apartment")]
    public partial class ApartmentDetailViewModel : ObservableObject
    {
        public ApartmentDetailViewModel() 
        {
        }

        [ObservableProperty]
        Apartment apartment;

    }
}
