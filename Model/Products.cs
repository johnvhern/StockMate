using System.ComponentModel.DataAnnotations;

namespace StockMate.Model
{
    public class Products
    {
        [Key]
        public int ProductId { get; set; }
        
        [Required(ErrorMessage = "Product name is required.")]
        public string Name { get; set; }

        public string SKU { get; set; }


        public int CategoryId { get; set; }


    }
}