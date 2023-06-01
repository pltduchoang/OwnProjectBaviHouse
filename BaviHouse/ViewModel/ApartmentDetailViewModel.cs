using BaviHouse.Model;
using BaviHouse.View;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;


namespace BaviHouse.ViewModel
{
    [QueryProperty("UnitNum", "UnitNum")]
    public partial class ApartmentDetailViewModel : ObservableObject
    {
        public ApartmentDetailViewModel() 
        {
        }

        [ObservableProperty]
        int unitNum;

        //public Apartment FindApartment(int id)
        //{
        //    if (id == 0) 
        //    {
        //        return; 
        //    }

        //} 
    }
}
