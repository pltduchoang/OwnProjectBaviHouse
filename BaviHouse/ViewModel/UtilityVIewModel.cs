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

       

        [ObservableProperty]
        Apartment selectedApartment;

        [ObservableProperty]
        double ammountDue = 0;

        [ObservableProperty]
        double electricityCost = 0;

        public static int newReading = 0;

        int unitCost = 4500;

        [RelayCommand]
        public void Calculation()
        {

            double electricityUsage = newReading - SelectedApartment.NewPower;
            ElectricityCost = electricityUsage * unitCost;
            AmmountDue = ElectricityCost + SelectedApartment.Rent + SelectedApartment.WaterLaundry;
        }
    }
}
