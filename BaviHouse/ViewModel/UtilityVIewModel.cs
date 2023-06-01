using BaviHouse.DataBase;
using BaviHouse.Model;
using BaviHouse.View;
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
            string genMessage = ($"Thong bao tien phong {SelectedApartment.UnitNum} giai doan tu {SelectedApartment.BeganDate.Day}/{DateTime.Now.Month}/{DateTime.Now.Year} den thang tiep theo.\nChi tiet nhu sau:\n{"So dien moi: ",-25}{newReading}-{SelectedApartment.NewPower}\n{"Dien tieu thu: ",-25}{electricityUsage}(kWh)\n______________\n{"Tien dien: ",-25}{ElectricityCost:C2} \n{"Tien nha: ",-25}{SelectedApartment.Rent:C2}\n{"Tien Nuoc & Giat: ",-25}{SelectedApartment.WaterLaundry:C2}\n{"Thanh tien: ",-25}{AmmountDue:C2}");
            Message = genMessage;
            SendCopy(genMessage);
            
        }

        [ObservableProperty]
        string message;

        public void SendCopy(string message)
        {
            
            Clipboard.SetTextAsync(message);

        }


        [RelayCommand]
        public void UpdateUtility()
        {
            DBConnect db = new();
            if (newReading != 0)
            {
                db.UpdateUtility(SelectedApartment.UnitNum, newReading);

            }
            
        }
    }
}
