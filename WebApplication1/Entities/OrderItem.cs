using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using test.Entities;

namespace WebApplication1.Entities
{
    public class OrderItem :BaseEntity
    {
        public virtual Order Order { get; set; }
        public string OrderId { get; set; }

        public virtual Item Item { get; set; }
        public string ItemId { get; set; }

        public int Quantity { get; set; }
    }
}
