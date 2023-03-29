namespace Entities
{
	public class Ports:BaseEntity
	{
		public string MultiMonitorSupport { get; set; }
		public string HDMI { get; set; }
		public string DisplayPort { get; set; }
		public virtual ICollection<Specifications> Specifications { get; set; }

	}
}
