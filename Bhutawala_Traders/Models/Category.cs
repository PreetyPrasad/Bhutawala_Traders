using System.ComponentModel.DataAnnotations;

namespace Bhutawala_Traders.Models
{
    public class Category
    {
        [Key] 
        public int CategoryId { get; set; }
        public string Name { get; set; } = string.Empty;
    }
}
