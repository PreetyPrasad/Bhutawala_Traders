using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bhutawala_Traders.Models
{
    public class SalesReturnDetail
    {
        [Key]
        public int SalesId { get; set; }
        [ForeignKey(nameof(InvoiceMaster))]
        public int InvoiceId { get; set; }
        [ForeignKey(nameof(InwardStock))]
        public int StockId { get; set; }
        [ForeignKey(nameof(InvoiceDetail))]
        public int InvoiceDetailId { get; set; }
        [ForeignKey(nameof(StaffMaster))]
        public int StaffId { get; set; }
        [Required]
        public double Qty { get; set; }
        [Required]
        public string? Unit { get; set; }
    }
}
