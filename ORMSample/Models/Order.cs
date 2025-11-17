using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORMSample.Models
{
    public class Order
    {
        public int OrderId { get; set; }

        public DateTime? Created { get; set; }

        // 1 to many relationship
        public ICollection<OrderItem> Items { get; set; }
    }
}
