namespace APIAssignmentOnEcomerce.Models
{
    public class Product
    {private static int  Id=1;
            public Product()
            {
            ProductId = Id;
            Id++;
            }
        public int ProductId { get; private set; }
        public string ProductName { get; set; }
        public string Category { get; set; }
        public int Price { get; set; }
        public int Stock { get; set; }
    }
}
