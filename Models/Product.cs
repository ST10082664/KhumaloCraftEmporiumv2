namespace KhumaloCraftEmporium.Models
{
    public class Product
    {
        public Product()
        {
            // Initialize properties in the constructor
            ProductName = string.Empty;
            Description = string.Empty;
        }

        public int ProductId { get; set; }

        // These properties now have default values
        public string ProductName { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; } = 0.0m; // Default value for decimal
        public string ArtisanNames { get; set; } = string.Empty; // Default value for string
        public string Category { get; set; } = string.Empty; // Default value for string
        public string Availability { get; set; } = string.Empty; // Default value for string

        // Make this property nullable if it's allowed to be null
        public ICollection<Transactions>? Transactions { get; set; }
    }

}
