using System.ComponentModel.DataAnnotations;

namespace Bhutawala_Traders.Models
{
    public class Category
    {
        public Category()
        {
            Categories=new HashSet<Category>();
        }

        [Key] 
        public int CategoryId { get; set; }
        [Required]
        public string Name { get; set; } = string.Empty;
        public ICollection<Category> Categories { get; set; }
    }
}
