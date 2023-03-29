namespace Entities
{
	public class Memory:BaseEntity
	{
		public int MemorySize { get; set; }
		public string MemoryInterface { get; set; }
		public string MemoryType { get; set; }
		public virtual ICollection<Specifications> Specifications { get; set; }

	}
}
