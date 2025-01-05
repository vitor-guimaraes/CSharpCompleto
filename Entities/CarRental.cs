using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCompleto.Entities
{
    public class CarRental
    {
        public CarRental(string carModel, DateTime pickupDate, DateTime returnDate, double pricePerHour, double pricePerDay)
        {
            CarModel = carModel;
            PickupDate = pickupDate;
            ReturnDate = returnDate;
            PricePerHour = pricePerHour;
            PricePerDay = pricePerDay;
        }

        public CarRental()
        {
        }

        public string CarModel { get; set; }
        public DateTime PickupDate { get; set; }
        public DateTime ReturnDate { get; set; }
        public double PricePerHour { get; set; }
        public double PricePerDay { get; set; }

        public TimeSpan Duration()
        {
            return ReturnDate - PickupDate;
        }

        public double BasePayment() 
        {
            TimeSpan duration = Duration();

            if (duration.TotalDays >= 1)
            {
                return PricePerDay * duration.TotalDays;
            }
            else
            {
                return PricePerHour * duration.TotalHours;
            }
        }

        public double Tax(double basePayment)
        {
            if (basePayment < 100)
            {
                return basePayment * 0.2;
            }
            else
            {
                return basePayment * 0.15;
            }
        }

        public double TotalPayment()
        {
            double basePayment = BasePayment();
            double tax = Tax(basePayment);

            return basePayment + tax;
        }
    }
}
