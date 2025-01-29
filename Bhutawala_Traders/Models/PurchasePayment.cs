using System.ComponentModel.DataAnnotations;

namespace Bhutawala_Traders.Models
{
    public class PurchasePayment
    {
        public int PaymentId { get; set; }
        public int PurchaseId { get; set; }
        public PurchaseMaster? PurchaseMasters {  get; set; }
        [Required]
        public double Amount { get; set; }
        [Required]
        public string? PaymentMode { get; set; }
        [Required]
        public double RefNo { get; set; }
        [Required]
        public DateTime? PaymentDate { get; set; }=DateTime.Now;
        public DateTime? LogDate { get; set; }=DateTime.Now;

    }
}
