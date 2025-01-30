using System.ComponentModel.DataAnnotations;

namespace inventroy.Models
{
    public class CustomerInstallment
    {
        [Key]
        public int CustomerInstallmentId { get; set; }
        [Required]
        public int InvoicId { get; set; }

        public InvoiceDetail? InvoiceDetail { get; set; }
        [Required]
        public double Amount { get; set; }
        [Required]
        public string Paymentmode { get; set; } = string.Empty;
        [Required]
        public string? RefNo { get; set; }
        [Required]
        public DateTime PaymentDate { get; set; } = DateTime.Now;
        [Required]
        public DateTime LogDate { get; set; } = DateTime.Now;
        public int StaffId { get; set; }
        public StaffMaster? StaffMaster { get; set; }

    }
}
