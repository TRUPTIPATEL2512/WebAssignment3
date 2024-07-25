namespace A3_TruptiPatel.Models
{
	public class Order
	{
		public int Id { get; set; }
		public int UserId { get; set; }
		public DateTime OrderDate { get; set; } = DateTime.Now;
		public ICollection<OrderProduct> OrderProducts { get; set; } = new List<OrderProduct>();
		public User User { get; set; } = null!;
	}

	public class OrderProduct
	{
		public int Id { get; set; }
		public int OrderId { get; set; }
		public int ProductId { get; set; }
		public int Quantity { get; set; }
		public Order Order { get; set; } = null!;
		public Product Product { get; set; } = null!;
	}
}
