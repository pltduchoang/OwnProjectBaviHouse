using System.Text.Json;

namespace BaviHouseASP.Models
{
    public class Room
    {
        public int ID { get; set; }
        public required int RoomNo { get; set; }
        public required string FullName { get; set; }
        public required string Phone { get; set; }
        public required DateTime MoveInDate { get; set; }
        public required double Deposit { get; set; }
        public required double Rent { get; set; }
        public required double WaterLaundry { get; set;}
        public int PreviousePowerReading { get; set; }
        public int PowerReading { get; set; }
        public double? PowerConsume { get; set; }
        public double PowerPrice { get; set; }
        public double? PowerCost { get; set; }
        public double? TotalCharge { get; set; }

        public Room()
        {
            
        }

    }

}
