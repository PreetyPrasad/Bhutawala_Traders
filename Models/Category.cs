using System.ComponentModel.DataAnnotations;

namespace inventroy.Models
{
    public class Category
    {
       
         public Category()
         {
            Materials = new HashSet<Material>();

         }
        [Key]
        public int CategoryId { get; set; }
        [Required]
        public string CategoryName { get; set; } = string.Empty;
        public ICollection<Material> Materials { get; set; }


    }
}
