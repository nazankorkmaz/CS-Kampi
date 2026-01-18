using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_EgitimKampi301_2.EntityLayer.concrete
{
    public class Order
    {
        public int OrderId { get; set; }

        // bir siparişte bir ürün bir kez geçer ama adeti fazla olur tabi ki 
        public int productId { get; set; }
        public virtual Product Product { get; set; }


        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal TotalPrice { get; set; }
        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }
    }
}
