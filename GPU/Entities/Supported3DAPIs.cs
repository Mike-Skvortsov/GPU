namespace Entities
{
	public class Supported3DAPIs : BaseEntity
	{
		public string DirectX { get; set; }
		public string OpenGL { get; set; }
		public virtual ICollection<Specifications> Specifications { get; set; }

	}
}
