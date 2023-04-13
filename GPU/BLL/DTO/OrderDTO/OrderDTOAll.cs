using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTO.OrderDTO
{
    public class OrderDTOAll
    {
        public int UserId { get; set; }
        public int Count { get; set; }
        public DateTime DateTime { get; set; } = DateTime.Now;
    }
}
