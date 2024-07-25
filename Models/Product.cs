namespace A3_TruptiPatel.Models
{
	public class Product
	{
		public int Id { get; set; }
		public string Description { get; set; } = string.Empty;
		public string Image { get; set; } = string.Empty;
		public decimal Pricing { get; set; }
		public decimal ShippingCost { get; set; }
	}
}
