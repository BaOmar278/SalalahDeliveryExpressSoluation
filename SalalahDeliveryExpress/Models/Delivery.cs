using SalalahDeliveryExpress.Models.Enums;
using SalalahDeliveryExpress.Models.users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalalahDeliveryExpress.Models
{
    public class Delivery
    {
        public Coustomer coustomer { get; set; }
        public Driver driver { get; set; }
        public string pickupLocation { get; set; }
        public string dropoffLocation { get; set; }
        public DateTime deliveryDate { get; set; }
        public Status status { get; set; }
        public List<string> items { get; set; }

        public Delivery(Coustomer coustomer, Driver driver, string pickupLocation, string dropoffLocation, DateTime deliveryDate, List<string> items)
        {
            this.coustomer = coustomer;
            this.driver = driver;
            this.pickupLocation = pickupLocation;
            this.dropoffLocation = dropoffLocation;
            this.deliveryDate = deliveryDate;
            this.status = Status.Pending;
            this.items = items;
        }
    }
}
