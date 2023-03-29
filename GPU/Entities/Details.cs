namespace Entities
{
	public class Details:BaseEntity
	{
		public string MaxResolution { get; set; }
		public string Cooler { get; set; }
		public float ThermalDesignPower { get; set; }
		public float RecommendedPSUWattage { get; set; }
		public string PowerConnector { get; set; }
		public virtual ICollection<Specifications> Specifications { get; set; }

	}
}
