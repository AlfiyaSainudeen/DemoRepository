namespace BookServiceAPI.Models
{
    public class Book
    {
        public int BookId { get; set; }
        public string BookName { get; set; }
        public int Price { get; set; }
        public string Author { get; set; }
        public string Lang { get; set; }
        public string Publisher { get; set; }
        public int ReleaseYear { get; set; }

    }
}
