using BaviHouse.Model;
using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaviHouse.DataBase;
using CommunityToolkit.Mvvm.Input;
using BaviHouse.View;

namespace BaviHouse.ViewModel
{
    public partial class ApartmentViewModel : ObservableObject
    {
        public ApartmentViewModel() 
        {
            ApartmentList = new ObservableCollection<Apartment>();
            DisplayAllApartment();
        }

        [ObservableProperty]
        ObservableCollection<Apartment> apartmentList;

        public void DisplayAllApartment()
        {
            DBConnect db = new DBConnect();
            List<Apartment> apartmentList = db.GetData();
            foreach (Apartment apartment in apartmentList)
            {
                ApartmentList.Add(apartment);
            }
        }

        [RelayCommand]
        async Task GoApartmentDetail(Apartment apartment)
        {
            if (apartment is null)
            {
                return;
            }
            //await Shell.Current.GoToAsync("ApartmentDetailPage");
            await Shell.Current.GoToAsync($"{nameof(ApartmentDetailPage)}", true,
                new Dictionary<string, object>
                {
                    {"Apartment", apartment}
                });
        }

    }
}
