using BaviHouse.DataBase;
using BaviHouse.Model;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaviHouse.ViewModel
{
    public partial class UtilityVIewModel : ObservableObject
    {


        [ObservableProperty]
        IList<Apartment> apartmentList;


        [ObservableProperty]
        Apartment apartment;

        public UtilityVIewModel() 
        {
            ApartmentList = new ObservableCollection<Apartment>();
            DisplayAllApartment();
        }

        public void DisplayAllApartment()
        {
            DBConnect db = new DBConnect();
            List<Apartment> apartmentList = db.GetData();
            foreach (Apartment apartment in apartmentList)
            {
                ApartmentList.Add(apartment);
            }
        }

        //[RelayCommand]
        //async Task ChooseApartment()
        //{
        //    return;
        //}
    }
}
