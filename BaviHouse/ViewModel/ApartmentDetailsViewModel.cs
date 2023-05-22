using BaviHouse.DataBase;
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
    [QueryProperty("Apartment", "Apartment")]
    public partial class ApartmentDetailsViewModel : ObservableObject
    {

        public ApartmentDetailsViewModel() { }

        [ObservableProperty]
        Apartment apartment;

        [RelayCommand]
        async Task GoBack()
        {
            await Shell.Current.GoToAsync("..");
        }


        //Apartment apartmentToUpdate;
        //public void GetApartmentToUpdate() 
        //{
            

        //    int unitNumUpdate = apartment.UnitNum;

        //    DBConnect db = new DBConnect();
        //    List<Apartment> apartmentList = db.GetData();
        //    foreach (Apartment apartment in apartmentList)
        //    {
        //        apartmentList.Add(apartment);
        //    }
        //    foreach (Apartment apartment in apartmentList)
        //    {
        //        if (apartment.UnitNum == unitNumUpdate)
        //        {
        //            apartmentToUpdate = apartment;
        //        }
        //    }
        //}

        [RelayCommand]
        async Task GoDetailsUpdate()
        {
            await Shell.Current.GoToAsync($"{nameof(DetailsUpdatePage)}", true,
                new Dictionary<string, object>
                {
                    {"Apartment", apartment}
                });
        }
    }

    
}
