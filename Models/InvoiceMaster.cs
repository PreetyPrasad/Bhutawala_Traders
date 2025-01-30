using System.ComponentModel.DataAnnotations;

namespace inventroy.Models
{
    public class InvoiceMaster
    {
        [Key]
        public int InvoiceId {  get; set; }
        [Required]
        public int InvoiceNo { get; set; }
        public string CustomerName { get; set; } = string.Empty;
        [Required]
        public string ContactNo { get; set; }= string.Empty;
        [Required]
        public double GrossAmount { get; set; }
        [Required]
        public double GSTAmount {  get; set; }
        [Required]
        public string? GST_TYPE { get; set; }
        [Required]
        public double Total {  get; set; }
        [Required]
        public DateTime InvoiceDate { get; set; } = DateTime.Now;
        [Required]
        public DateTime NoticePeriod { get; set; }  =DateTime.Now;

        public string? GSTIN {  get; set; }
        public int StaffId { get; set; }
        public StaffMaster? StaffMaster { get; set; }

    }
}
