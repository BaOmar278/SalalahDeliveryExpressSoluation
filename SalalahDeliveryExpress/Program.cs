using SalalahDeliveryExpress.Models;
using SalalahDeliveryExpress.Models.users;

namespace SalalahDeliveryExpress
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DeliverySystem deliverySystem = new DeliverySystem();
            Console.WriteLine("Welcome to Salalah Delivery Express!");
            Coustomer c1 = new("Ahmed Al Kathiri", "ahmed.alkathiri@email.com", "+968-9123-4567", "Saada W");
            Coustomer c2 = new("Fatima Al Shanfari", "fatima.shanfari@email.com", "+968-9234-5678", "Saada N");
            Coustomer c3 = new("Mohammed Al Mahri", "mohammed.mahri@email.com", "+968-9345-6789", "Taqah");
            Coustomer c4 = new("Aisha Al Hakmani", "aisha.hakmani@email.com", "+968-9456-7890", "Marbat");

            c1.AddAdress("Al Baleed, Salalah, Dhofar Governorate, Oman");
            c2.AddAdress("Al Dahariz, Salalah, Dhofar Governorate, Oman");
            c3.AddAdress("Al Hafa, Salalah, Dhofar Governorate, Oman");
            c4.AddAdress("Al Saada, Salalah, Dhofar Governorate, Oman");
     


            deliverySystem.AddCoustomer(c1);
            deliverySystem.AddCoustomer(c2);
            deliverySystem.AddCoustomer(c3);
            deliverySystem.AddCoustomer(c4);

            Driver d1 = new("Salem Al Mashani", "salem.mashani@email.com", "+968-9567-8901", "Salalah", "Car", "12345");
            Driver d2 = new("Youssef Al Kathiri", "youssef.kathiri@email.com", "+968-9678-9012", "Salalah", "Car", "67890");
            deliverySystem.AddDriver(d1);
            deliverySystem.AddDriver(d2);
        }
    }
}
