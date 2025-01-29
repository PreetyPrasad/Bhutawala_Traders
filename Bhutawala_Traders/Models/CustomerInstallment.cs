using System.ComponentModel.DataAnnotations;

namespace Bhutawala_Traders.Models
{
    public class CustomerInstallment
    {
        [Key]
        public int CustomerInstallmentId { get; set; }
        public int InvoiceId { get; set; }
        public InvoiceMaster? InvoiceMasters {  get; set; }
        public double Amount { get; set; }
        public string PaymentMode { get; set; } = string.Empty;
        public string? RefNo { get; set; }
        public DateTime PaymentDate { get; set; }= DateTime.Now;
        public DateTime LogDate { get; set; }=DateTime.Now;
        public int StaffId { get; set; }
        public StaffMaster?StaffMasters { get; set; }
    }
}
