using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManage
{
    public class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }

        public override bool Equals(object obj)
        {
            var product = obj as Product;
            return product != null && Name == product.Name && Price == product.Price;
        }

        public override int GetHashCode()
        {
            unchecked
            { // 使用 unchecked 以避免溢出
                int hash = 17;
                hash = hash * 23 + (Name != null ? Name.GetHashCode() : 0);
                hash = hash * 23 + Price.GetHashCode();
                return hash;
            }
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
