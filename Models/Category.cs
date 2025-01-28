using System.ComponentModel.DataAnnotations;

namespace inventroy.Models
{
    public class Category
    {
        [Key] 
         public Category()
        {
            Products = new HashSet<Product>();
        }
        public int CategoryId { get; set; }
        public string CategoryName { get; set; } = string.Empty;


    }
}
