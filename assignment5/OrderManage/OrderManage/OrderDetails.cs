using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManage
{
    public class OrderDetails
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get
            {
                return Product.Price;
            } }
        public override bool Equals(object obj)
        {
            var detail = obj as OrderDetails;
            return detail != null && Product.Equals(detail.Product);
        }

        public override int GetHashCode()
        {
            return Product != null ? Product.GetHashCode() : 0;
        }

        public override string ToString()
        {
            return $"Product: {Product}, Quantity: {Quantity}";
        }
    }
}
