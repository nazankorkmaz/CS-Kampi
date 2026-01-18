using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace C_EgitimKampi301_2.EntityLayer.concrete
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }

        public int ProductStock {  get; set; }
        public decimal ProductPrice { get; set; }
        public string ProductDescription { get; set; }
   
        public int CateforyId {get;set; }
        public virtual Category Category { get; set; }

        public List<Order> Orders { get; set; }
    }
}
