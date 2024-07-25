namespace A3_TruptiPatel.Models
{
	public class Cart
	{
		public int Id { get; set; }
		public int UserId { get; set; }
		public User User { get; set; } = null!;
		public ICollection<CartProduct> CartProducts { get; set; } = new List<CartProduct>();
	}

	public class CartProduct
	{
		public int Id { get; set; }
		public int CartId { get; set; }
		public int ProductId { get; set; }
		public int Quantity { get; set; }
		public Cart Cart { get; set; } = null!;
		public Product Product { get; set; } = null!;
	}
}
