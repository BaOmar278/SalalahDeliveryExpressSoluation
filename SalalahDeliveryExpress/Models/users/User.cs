using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalalahDeliveryExpress.Models.users
{
    public abstract class User
    {
        [Required]
        [MaxLength(100)]
        public string fullName { get; set; }

        [Required]
        [EmailAddress]
        public string email { get; set; }
        [Required]
        [Phone]
        public string phoneNumber { get; set; }
        [Required]
        public string city { get; set; }
        public List<Delivery> Deliveries { get; set; }

        protected User(string fullName, string email, string phoneNumber, string city)
        {
            this.fullName = fullName;
            this.email = email;
            this.phoneNumber = phoneNumber;
            this.city = city;
            Deliveries = new List<Delivery>();
        }

        public void AddDelivery(Delivery delivery)
        {
            Deliveries.Add(delivery);

        }
        public  virtual void getUserInfo()
        {
            Console.WriteLine($"Full Name: {fullName}");
            Console.WriteLine($"Email: {email}");
            Console.WriteLine($"Phone Number: {phoneNumber}");
            Console.WriteLine($"City: {city}");
            Console.WriteLine($"Total Deliveries: {Deliveries.Count}");
            Console.WriteLine($"Total Deliveries: {Deliveries.Count}");
            foreach (var dev in Deliveries)
            {
                Console.WriteLine($"- {dev}");
            }
        }

        public void getDeliveriesInfo()
        {
            Console.WriteLine($"Deliveries for {fullName}:");
            foreach (var delivery in Deliveries)
            {
                Console.WriteLine($"- Pickup: {delivery.pickupLocation}, Dropoff: {delivery.dropoffLocation}, Date: {delivery.deliveryDate}, Status: {delivery.status}");
            }
        }

    }
}
