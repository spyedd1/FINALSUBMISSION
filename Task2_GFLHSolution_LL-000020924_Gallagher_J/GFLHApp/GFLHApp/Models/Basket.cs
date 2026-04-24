namespace GFLHApp.Models
{
    public class Basket
    {

        public int BasketId { get; set; } // PK

        public string UserId { get; set; } // FK that links the basket to the user account

        public bool Status { get; set; } // Indicates whether the basket is active (true) or has been checked out (false)

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow; // Stores the date and time when the basket was created, defaulting to the current UTC time.

        // Navigation properties

        public ICollection<BasketProducts>? BasketProducts { get; set; } // A basket can have multiple basket products

    }
}
