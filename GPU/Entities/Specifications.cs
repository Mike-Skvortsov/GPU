namespace Entities
{
	public class Specifications: BaseEntity
	{
		public int ChipsetId { get; set; }
		public virtual Chipset? Chipset { get; set; }
		public int MemoryId { get; set; }
		public virtual Memory? Memory { get; set; }
		public int Supported3DAPIsId { get; set; }
		public virtual Supported3DAPIs? Supported3DAPIs { get; set; }
		public int PortsId { get; set; }
		public virtual Ports? Ports { get; set; }
		public int DetailsId { get; set; }
		public virtual Details? Details { get; set; }
		public int FromFactorId { get; set; }
		public virtual FromFactor? FromFactor { get; set; }
		public int ProductId { get; set; }
		public virtual Product Products { get; set; }
	}
}
