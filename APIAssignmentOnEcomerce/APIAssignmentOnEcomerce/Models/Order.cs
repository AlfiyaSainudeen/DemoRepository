namespace APIAssignmentOnEcomerce.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public DateTime OrderDate { get; set; }
        public int Quantity { get; set; }
        public int Amount { get; set; }
    }
}
