namespace Entities
{
	public class FromFactor: BaseEntity
	{
		public string FormFactor { get; set; }
		public float MaxGPULength { get; set; }
		public virtual ICollection<Specifications> Specifications { get; set; }

	}
}
