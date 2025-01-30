using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bhutawala_Traders.Models
{
    public class PurchasePayment
    {
        public int PaymentId { get; set; }
        [ForeignKey(nameof(PurchaseMaster))]
        public int PurchaseId { get; set; }
        [Required]
        public double Amount { get; set; }
        [Required]
        public string? PaymentMode { get; set; }
        public double RefNo { get; set; }
        [Required]
        public DateTime? PaymentDate { get; set; }=DateTime.Now;
        public DateTime? LogDate { get; set; }=DateTime.Now;

    }
}
