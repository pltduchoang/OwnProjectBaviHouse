using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaviHouse.Model
{
    public partial class Apartment
    {
        public int UnitNum { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public DateOnly BeganDate {get; set; }
        public double Deposite { get; set; }
        public string Phone { get; set; }
        public double Rent { get; set; }
        public double WaterLaundry { get; set; }
        public int LastPower { get; set; }  
        public int NewPower { get; set; }

        public Apartment(int unitNum, string fName, string lName, DateOnly beganDate, double deposite, string phone, double rent, double waterLaundry, int lastPower, int newPower)
        {
            this.UnitNum = unitNum;
            this.FName = fName;
            this.LName = lName;
            this.BeganDate = beganDate;
            this.Deposite = deposite;
            this.Phone = phone;
            this.Rent = rent;
            this.WaterLaundry = waterLaundry;
            this.LastPower = lastPower;
            this.NewPower = newPower;
        }
    }
}
