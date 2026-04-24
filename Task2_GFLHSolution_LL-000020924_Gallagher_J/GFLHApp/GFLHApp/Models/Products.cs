namespace GFLHApp.Models
{
    public class Products
    {
        public int ProductsId { get; set; } // PK

        public int ProducersId { get; set; } // FK that links products to the producer who created them

        public string ItemName { get; set; } // The name of the product, e.g. "Sourdough Bread", "Organic Carrots", "Free-Range Eggs"

        public decimal ItemPrice { get; set; } // The price of the product, stored as a decimal to allow for currency values (e.g. 3.99)

        public string? ImagePath { get; set; } // This uses a ? as the image path is not required to be filled in as they may not want to or be able to upload an image of their product

        public int QuantityInStock { get; set; } // The quantity of the product currently in stock, which can be used to manage inventory and prevent overselling

        public bool Available { get; set; } // Indicates whether the product is currently available for purchase. This can be used to temporarily hide products that are out of stock or unavailable for other reasons without deleting them from the database.

        public string Category { get; set; } // The category of the product, which can be used for filtering and organizing products in the application (e.g. "Bread", "Vegetables", "Dairy")

        public string Description { get; set; } // A description of the product, which can provide additional information to customers about the product's features, ingredients, or any other relevant details that may help them make a purchasing decision.

        public string? Allergens { get; set; } // Comma separated allergen list e.g. "Gluten, Nuts, Dairy" - required under Natasha's Law

        // Navigation properties

        public Producers Producers { get; set; } // A product is associated with one producer

        public ICollection<BasketProducts>? BasketProducts { get; set; } // A product can be in multiple basket products

        public ICollection<OrderProducts>? OrderProducts { get; set; } // A product can be in multiple order products
    }
}
