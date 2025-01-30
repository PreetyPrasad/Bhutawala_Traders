using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bhutawala_Traders.Models
{
    public class Material
    {
        public Material()
        {
            InwardStocks=new HashSet<InwardStock>();
            InvoiceDetails=new HashSet<InvoiceDetail>();
        }

        [Key]
        public int MaterialId { get; set; }
        [ForeignKey(nameof(Category))]
        public int CategoryId { get; set; }
        [Required]
        public string? MaterialName { get; set; }
        [Required]
        public string Unit { get; set; } = string.Empty;
        [Required]
        public double Qty { get; set; }
        [Required]
        public double NetQty { get; set; }
        [Required]
        public string? Discription { get; set; }
        [Required]
        public string Brand { get; set; } = string.Empty;
        [Required]
        public double GST { get; set; }
        [Required]
        public string? GST_Type { get; set; }
        public DateTime LogDate { get; set; } = DateTime.Now;
        public ICollection<InwardStock> InwardStocks { get; set; }
        public ICollection<InvoiceDetail>InvoiceDetails { get; set; }
    }
}
