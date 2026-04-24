namespace GFLHApp.Models
{
    public class Orders
    {
        public int OrdersId { get; set; } // PK
        public string UserId { get; set; } // FK that links orders to the user account

        public DateOnly OrderDate { get; set; } // Stores the date of the order, using DateOnly as we only need to store the date and not the time

        public string? DeliveryMethod { get; set; } // This uses a ? as they can pick any type of delivery method, and it is not required to be filled in

        public bool Delivery { get; set; } // Whether the user has chosen delivery as their delivery method

        public bool Collection { get; set; } // Whether the user has chosen collection as their delivery method

        public decimal OrdersTotal { get; set; } // Stores the total cost of the order, calculated from the order products and their quantities

        public string TrackingStatus { get; set; } = "Not Shipped"; // Derived from producer slices, defaulting to "Not Shipped" when the order is created

        public bool TermsAccepted { get; set; } // Whether the user has accepted the terms and conditions at checkout

        public DateOnly? DateOfCollection { get; set; } // This uses a ? as the date of collection is not required to be filled in as they may pick delivery instead of collection

        public string OrderStatus { get; set; } = "Pending"; // Derived from producer slices
        public bool DeliveryConfirmed { get; set; } = false;  // Customer confirms delivery

        // Billing/Delivery Address Fields

        public string BillingLine1 { get; set; } // The first line of the billing address, required to be filled in as it is needed for payment processing and invoicing

        public string? BillingLine2 { get; set; } // This uses a ? as the second line of the address is not required to be filled in

        public string BillingCity { get; set; } // The city of the billing address, required to be filled in as it is needed for payment processing and invoicing

        public string BillingPostcode { get; set; } // The postcode of the billing address, required to be filled in as it is needed for payment processing and invoicing

        public string? DeliveryLine1 { get; set; } // The first line of the delivery address, this uses a ? as it is not required to be filled in if the user has chosen collection as their delivery method

        public string? DeliveryLine2 { get; set; }  // The second line of the delivery address, this uses a ? as it is not required to be filled in if the user has chosen collection as their delivery method, and the second line of the address is not always needed

        public string? DeliveryCity { get; set; } // The city of the delivery address, this uses a ? as it is not required to be filled in if the user has chosen collection as their delivery method

        public string? DeliveryPostcode { get; set; } // The postcode of the delivery address, this uses a ? as it is not required to be filled in if the user has chosen collection as their delivery method

        // Navigation properties

        public ICollection<OrderProducts>? OrderProducts { get; set; } // An order can have multiple order products
    }
}
