using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace webBanHang.API.Models
{
    [Table("OrderDetail")]
    public class OrderDetail
    {
        [Key]
        public int OrderDetailID { get; set; } // Khóa chính (PK)
        [Key]
        [Required]
        public int OrderID { get; set; } // Khóa ngoại (FK) liên kết với bảng Order
        [Key]
        [Required]

        public int ProductID { get; set; } // Khóa ngoại (FK) liên kết với bảng Product
        [Required]

        public int Quantity { get; set; }
        [Required]

        public decimal Subtotal { get; set; }

        // Khóa ngoại
        public Order Order { get; set; }
        public Product Product { get; set; }
    }
}
