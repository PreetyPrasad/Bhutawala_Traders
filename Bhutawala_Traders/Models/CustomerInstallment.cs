using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bhutawala_Traders.Models
{
    public class CustomerInstallment
    {
        [Key]
        public int CustomerInstallmentId { get; set; }
        [ForeignKey(nameof(InvoiceMaster))]
        public int InvoiceId { get; set; }
        [Required]
        public double Amount { get; set; }
        [Required]
        public string PaymentMode { get; set; } = string.Empty;
        [Required]
        public string? RefNo { get; set; }
        [Required]
        public DateTime PaymentDate { get; set; }= DateTime.Now;
        public DateTime LogDate { get; set; }=DateTime.Now;
        [Required]
        [ForeignKey(nameof(StaffMaster))]
        public int StaffId { get; set; }
    }
}
