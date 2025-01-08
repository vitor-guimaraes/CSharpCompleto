using System;

namespace CSharpCompleto.Entities
{
    public class CarRental
    {
        public Vehicle CarModel { get; set; }
        public DateTime PickupDate { get; set; }
        public DateTime ReturnDate { get; set; }
        public Invoice Invoice { get; set; }
        public CarRental(Vehicle carModel, DateTime pickupDate, DateTime returnDate)
        {
            CarModel = carModel;
            PickupDate = pickupDate;
            ReturnDate = returnDate;
        }
    }
}
