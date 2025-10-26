using SalalahDeliveryExpress.Models.users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalalahDeliveryExpress.Models
{
    public class DeliverySystem
    {
        public List<Coustomer> cos { get; set; }
        public List<Driver> drvs { get; set; }
        public List<Delivery> delivs { get; set; }

        public DeliverySystem()
        {
            cos = new List<Coustomer>();
            drvs = new List<Driver>();
            delivs = new List<Delivery>();
        }

        public void AddCoustomer(Coustomer coustomer)
        {
            cos.Add(coustomer);
        }
        public void AddDriver(Driver driver)
        {
            drvs.Add(driver);
        }
        public void AddDelivery(Delivery delivery)
        {
            delivs.Add(delivery);
            
        }

        public void ListAllDeliveries()
        {
            foreach (var coustomer in cos)
            {
                coustomer.getDeliveriesInfo();

            }
        }

        public void ListAllPandingDeliveries()
        {
            foreach (var delivery in delivs)
            {
                if (delivery.status == Enums.Status.Pending)
                {
                    Console.WriteLine($"Coustomer: {delivery.coustomer.fullName}");
                    Console.WriteLine($"Pickup Location: {delivery.pickupLocation}");
                    Console.WriteLine($"Dropoff Location: {delivery.dropoffLocation}");
                    Console.WriteLine($"Delivery Date: {delivery.deliveryDate}");
                    Console.WriteLine($"Items: {string.Join(", ", delivery.items)}");
                    Console.WriteLine();
                }
            }
        }

        public void ListAllOntheWayDeliveries()
        {
            foreach (var delivery in delivs)
            {
                if (delivery.status == Enums.Status.OntheWay)
                {
                    Console.WriteLine($"Coustomer: {delivery.coustomer.fullName}");
                    Console.WriteLine($"Driver: {delivery.driver.fullName}");
                    Console.WriteLine($"Pickup Location: {delivery.pickupLocation}");
                    Console.WriteLine($"Dropoff Location: {delivery.dropoffLocation}");
                    Console.WriteLine($"Delivery Date: {delivery.deliveryDate}");
                    Console.WriteLine($"Items: {string.Join(", ", delivery.items)}");
                    Console.WriteLine();
                }
            }
        }

        public void ListAllDeliveredDeliveries()
        {
            foreach (var delivery in delivs)
            {
                if (delivery.status == Enums.Status.Delivered)
                {
                    Console.WriteLine($"Coustomer: {delivery.coustomer.fullName}");
                    Console.WriteLine($"Driver: {delivery.driver.fullName}");
                    Console.WriteLine($"Pickup Location: {delivery.pickupLocation}");
                    Console.WriteLine($"Dropoff Location: {delivery.dropoffLocation}");
                    Console.WriteLine($"Delivery Date: {delivery.deliveryDate}");
                    Console.WriteLine($"Items: {string.Join(", ", delivery.items)}");
                    Console.WriteLine();
                }
            }
        }

        public void ListAllCoustomers()
        {
            foreach (var coustomer in cos)
            {
                coustomer.getUserInfo();
                Console.WriteLine();
            }
        }


        public void assignDelivery(Delivery delivery, Driver driver)
        {
            if (delivery.driver != null)
            {
                Console.WriteLine("Delivery is already assigned to a driver.");
                Console.WriteLine(delivery.driver.fullName);

            }
            else if (!drvs.Contains(driver))
            {
                Console.WriteLine("Driver not found in the system.");
                return;
            }
            else if (delivery.coustomer.city == driver.city)
            {


                delivery.driver = driver;
                driver.AddDelivery(delivery);
                Console.WriteLine($"Delivery assigned to driver {driver.fullName}");
            }
            else
            {
                Console.WriteLine("Driver and Coustomer are in different cities. Cannot assign delivery.");
            }




        }
    }
}