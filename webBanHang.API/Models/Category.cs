using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace webBanHang.API.Models
{
    [Table("Categorys")]
    public class Category
    {
        [Key]
        public int CategoryID { get; set; }
        [Required]
        public string CategoryName { get; set; }

        //Khóa ngoại
        public ICollection<Product> Products { get; set; }
    }
}
