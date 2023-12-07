using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace webBanHang.API.Models
{
    [Table("Order")]
    public class Order
    {
        [Key]
        public int OrderID { get; set; }
        [Key]
        [Required]
        public int CustomerID { get; set; }
        [Required]

        public DateTime OrderDate { get; set; }
        [Required]

        public decimal TotalAmount { get; set; }

        // Khóa ngoại
        public Customer Customer { get; set; }
        public ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
