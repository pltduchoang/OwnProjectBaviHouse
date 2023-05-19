using BaviHouse.Model;
using BaviHouse.View;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
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

    }
}
