using System.ComponentModel.DataAnnotations;

namespace OrderManageWeb.Models
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }
        public string ?Name { get; set; }
        // Other properties
    }
}
