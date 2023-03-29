namespace Entities
{
	public class Product: BaseEntity
	{
		public string? Title { get; set; }
		public string? Description { get; set; }
		public string? Price { get; set; }
		public float Sale { get; set; }
		public bool Present { get; set; }
		public string? Brand { get; set; }
		public string? Series { get; set; }
		public string? GPUModel { get; set; }
		public string? GPUInterface { get; set; }
		public Specifications? Specifications { get; set; }
	}
}
