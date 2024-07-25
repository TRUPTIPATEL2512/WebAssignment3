namespace A3_TruptiPatel.Models
{
	public class User
	{
		public int Id { get; set; }
		public string Email { get; set; } = string.Empty;
		public string Password { get; set; } = string.Empty;
		public string Username { get; set; } = string.Empty;
		public string PurchaseHistory { get; set; } = string.Empty;
		public string ShippingAddress { get; set; } = string.Empty;
	}
}
