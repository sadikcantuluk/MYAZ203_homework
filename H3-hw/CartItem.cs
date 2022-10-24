using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H3_homework
{
    internal class CartItem
    {
        public int CartId { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }

        public override string ToString()
        {
            return $"CartID:{CartId,-5}Product:{Product.ProductName,-5}Quantity:{Quantity,-5}";
        }
    }
}
