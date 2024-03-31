using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManage
{
    public class Customer
    {
        public string Name { get; set; }

        public override bool Equals(object obj)
        {
            var customer = obj as Customer;
            return customer != null && Name == customer.Name;
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return (Name != null ? Name.GetHashCode() : 0);
            }
        }

        public override string ToString()
        {
            return Name;
        }
    }

}
