using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalalahDeliveryExpress.Models.users
{
    public class Driver : User
    {
        private bool PickedUp;
        public string vehicleType { get; set; }
        public string vehicleNumber { get; set; }
        public Driver(string fullName, string email, string phoneNumber, string city, string vehicleType, string vehicleNumber) : base(fullName, email, phoneNumber, city)
        {
            this.vehicleType = vehicleType;
            this.vehicleNumber = vehicleNumber;
        }

  

        public override void getUserInfo()
        {
          
            Console.WriteLine($"Vehicle Type: {vehicleType}");
            Console.WriteLine($"Vehicle Number: {vehicleNumber}");
           base.getUserInfo();
        }

        public void PickUpDelivery(Delivery delivery)
        {
            PickedUp = true;
            delivery.status = Models.Enums.Status.OntheWay;
            Console.WriteLine($"Delivery picked up by {fullName} and it on the way to {delivery.dropoffLocation}");
        }

    }
}
