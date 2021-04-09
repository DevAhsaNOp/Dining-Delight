using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dining_Delight.Models
{
    class CartItem
    {
        [DisplayName("Item ID")]
        public int ItemId { get; set; }
        
        [DisplayName("Item Name")]
        public string ItemName { get; set; }

        public int Quantity { get; set; }

        [DisplayName("Unit Price")]
        public decimal UnitPrice { get; set; }

        [DisplayName("Total Price")]
        public decimal TotalPrice { get; set; }
    }
}
