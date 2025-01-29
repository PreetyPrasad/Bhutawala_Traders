using System.ComponentModel.DataAnnotations;

namespace Bhutawala_Traders.Models
{
    public class Category
    {
        public Category()
        {
            Materials=new HashSet<Material>();
        }

        [Key] 
        public int CategoryId { get; set; }
        [Required]
        public string Name { get; set; } = string.Empty;
        public ICollection<Material> Materials { get; set; }
    }
}
