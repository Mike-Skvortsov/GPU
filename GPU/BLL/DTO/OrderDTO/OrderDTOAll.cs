namespace BLL.DTO.OrderDTO
{
    public class OrderDTOAll
    {
        public int UserId { get; set; }
        public int Count { get; set; }
        public DateTime DateTime { get; set; } = DateTime.Now;
    }
}
