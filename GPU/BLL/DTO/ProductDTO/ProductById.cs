using BLL.DTO.Manufacturer;
using System.ComponentModel.DataAnnotations.Schema;

namespace BLL.DTO.ProductDTO
{
	public class ProductById
	{
		public int Id { get; set; }
		public string? Title { get; set; }
		public string? Description { get; set; }
		public float? Price { get; set; }
		public float Sale { get; set; }
		public bool IsPresent { get; set; }
		public string? Series { get; set; }
		public string? GPUInterface { get; set; }
		public int MemorySize { get; set; }
		public string? MemoryType { get; set; }
		public string Ports { get; set; }
		public ManufacturerDTO? Manufacturer { get; set; }
		public string? ChipsetSeries { get; set; }
		public string? GPU { get; set; }
		public string? CUDA { get; set; }
		public string Supported3DAPI { get; set; }
		public bool IsHot { get; set; }
		public bool IsNew { get; set; }
		public byte[] Image { get; set; }
	}
}
