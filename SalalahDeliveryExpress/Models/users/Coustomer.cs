using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalalahDeliveryExpress.Models.users
{
    public class Coustomer : User
    {

         private bool PickedUp;
        public List<string> adress { get; set; }
        
        

        public Coustomer(string fullName, string email, string phoneNumber, string city) : base(fullName, email, phoneNumber, city)
        {
            this.adress = new List<string>();
            Deliveries = new List<Delivery>();
        }

        public void AddAdress(string adress)
        {
            this.adress.Add(adress);
        }

        public void RemoveAdress(string adress)
        {
            this.adress.Remove(adress);
        }

      

        public void getCoustomerInfo()
        {
            Console.WriteLine($"Full Name: {fullName}");
            Console.WriteLine($"Email: {email}");
            Console.WriteLine($"Phone Number: {phoneNumber}");
            Console.WriteLine($"City: {city}");
            Console.WriteLine("Addresses:");
            foreach (var addr in adress)
            {
                Console.WriteLine($"- {addr}");
            }
            Console.WriteLine($"Total Deliveries: {Deliveries.Count}");
        }

        public override void getUserInfo()
        {
            base.getUserInfo();
            Console.WriteLine("Addresses:");
            foreach (var addr in adress)
            {
                Console.WriteLine($"- {addr}");
            }
        }

        public void ReceiveDelivery(Delivery delivery)
        {
            PickedUp = true;
            delivery.status = Enums.Status.Delivered;
            Console.WriteLine($"Delivery received by {fullName} at {delivery.dropoffLocation}");
        }


    }
}
