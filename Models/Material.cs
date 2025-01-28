using System.ComponentModel.DataAnnotations;

namespace inventroy.Models
{
    public class Material
    {
        [Key] 
        public int MaterialId { get; set; }
        public int CategoryId { get; set; }
        public Category? Category { get; set; }
        public string? MaterialName { get; set; } 
        public string Unit {  get; set; } = string.Empty;
        public double Qty {  get; set; } 
        public double Net_Qty {  get; set; } 
        public string Description { get; set; } = string.Empty;
        public string Brand { get; set; } = string.Empty;
    }
}
