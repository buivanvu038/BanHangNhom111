using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace webBanHang.API.Models

{
    [Table("Supplier")]
    public class Supplier
    {
        [Key]
        public int SupplierID { get; set; }
        [Required]
        public string SupplierName { get; set; }
        [Required]

        public string ContactPerson { get; set; }
        [Required]

        public string ContactEmail { get; set; }
        [Required]

        public string ContactPhone { get; set; }

        // Khóa ngoại
        public ICollection<Product> Products { get; set; }
    }
}
