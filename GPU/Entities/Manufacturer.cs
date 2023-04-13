namespace Entities
{
	public class Manufacturer:BaseEntity
	{
		public string? Name { get; set; }
		public string? Brand { get; set; }
		public ICollection<Product> Products { get; set;}
	}
}
