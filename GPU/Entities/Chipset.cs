namespace Entities
{
	public class Chipset: BaseEntity
	{
		public string? Manufacture { get; set; }
		public string? Series { get; set; }
		public string? GPU { get; set; }
		public string? CUDA { get; set; }
		public virtual ICollection<Specifications> Specifications { get; set; }

	}
}
