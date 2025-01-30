using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bhutawala_Traders.Models
{
    public class InvoiceDetail
    {
        public InvoiceDetail()
        {
            SalesReturnDetails=new HashSet<SalesReturnDetail>();
        }
        [Key]
        public int InvoiceDetailId { get; set; }
        [ForeignKey(nameof(Material))]
        public int MaterialId { get; set; }
        [Required]
        public double Rate { get; set; }
        [Required]
        public double Qty { get; set; }
        [Required]
        public string Unit { get; set; } = string.Empty;
        [Required]
        public double GST { get; set; }
        [Required]
        public double Total { get; set; }
        public ICollection<SalesReturnDetail> SalesReturnDetails { get; set; }
    }
}
