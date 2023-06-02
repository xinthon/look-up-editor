using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace look_up_editor
{
    public class Product
    {
        public int ID { get; set; }
        public string ProductName { get; set; } = string.Empty; 
        public string Country { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public double UnitPrice { get; set; }
        public int Quantity { get; set; }
    }
}
