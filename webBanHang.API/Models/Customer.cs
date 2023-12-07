using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace webBanHang.API.Models
{
    [Table("Customer")]
    public class Customer
    {
        [Key]
        public int CustomerID { get; set; }
        [Required]

        public string FirstName { get; set; }
        [Required]

        public string LastName { get; set; }
        [Required]

        public string Email { get; set; }
        [Required]

        public string PhoneNumber { get; set; }
        [Required]

        public string Address { get; set; }

        // Khóa ngoại
        public ICollection<Order> Orders { get; set; }
    }
}
