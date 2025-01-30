using System.ComponentModel.DataAnnotations;

namespace inventroy.Models
{
    public class Material
    {
        public Material()
        {
            InvoiceDates = new HashSet<InvoiceDetail>();
        }
        [Key] 
        public int MaterialId { get; set; }
        [Required]
        public int CategoryId { get; set; }
        public Category? Category { get; set; }
        [Required]
        public string? MaterialName { get; set; } 
        [Required]  
        public string Unit {  get; set; } = string.Empty;
        [Required]
        public double Qty {  get; set; } 
        [Required]
        public double Net_Qty {  get; set; } 
        [Required]
        public string Description { get; set; } = string.Empty;
        [Required]


        public string Brand { get; set; } = string.Empty;

        public double GST { get; set;} 
        public double GSTType { get; set;}
        
        public ICollection<InvoiceDetail> InvoiceDates { get; set; }

    }
}
