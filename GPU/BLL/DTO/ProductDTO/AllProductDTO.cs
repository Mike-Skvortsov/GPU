namespace BLL.DTO.ProductDTO
{
	public class AllProductDTO
	{
		public int Id { get; set; }
		public string Title { get; set; }
		public float Price { get; set; }
		public float Sale { get; set; }
		public byte[] Image { get; set; }
		public bool IsPresent { get; set; }
	}
}
