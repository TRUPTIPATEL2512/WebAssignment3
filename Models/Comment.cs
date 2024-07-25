namespace A3_TruptiPatel.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int UserId { get; set; }
        public int Rating { get; set; }
        public string Images { get; set; } = string.Empty;
        public string Text { get; set; } = string.Empty;
        public Product Product { get; set; } = null!;
        public User User { get; set; } = null!;
    }
}
