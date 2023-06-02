using DevExpress.Mvvm.DataAnnotations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace look_up_editor
{
    public class Product
    {
        public int ID { get; set; }
        public string ProductName { get; set; } = string.Empty;
        [Hidden]
        public string Country { get; set; } = string.Empty;
        [Hidden]
        public string City { get; set; } = string.Empty;
        [Hidden]
        public double UnitPrice { get; set; }
        [Hidden]
        public int Quantity { get; set; }
    }
}
