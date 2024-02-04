using System.ComponentModel.DataAnnotations;

namespace PRODUCTXPLATFORMMVC.Models
{
    public class ProductList
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
    }
}
