using System.ComponentModel.DataAnnotations;

namespace Bhutawala_Traders.Models
{
    public class InvoiceMaster
    {
        public InvoiceMaster()
        {
            CreditNotes=new HashSet<CreditNote>();
            SalesReturnDetails=new HashSet<SalesReturnDetail>();
            CustomerInstallments=new HashSet<CustomerInstallment>();
            ApplyCredits = new HashSet<ApplyCredit>();
        }
        [Key]
        public int InvoiceId { get; set; }
        [Required]
        public int InvoiceNo { get; set; }
        [Required]
        public string CustomerName { get; set; }=string.Empty;
        [Required]
        public string ContactNo { get; set; }= string.Empty;
        [Required]
        public double GrossAmt { get; set; }
        [Required]
        public double GSTAmt { get; set; }
        [Required]
        public string? GST_Type { get; set; }
        [Required]
        public double Total { get; set; }
        [Required]
        public DateTime InvoiceDate { get; set; }=DateTime.Now;
        [Required]
        public DateTime NoticePeriod { get; set; }= DateTime.Now;
        [Required]
        public double GSTIN { get; set; }
        [Required]
        public int StaffId { get; set; }
        public StaffMaster? StaffMasters {  get; set; }

        public ICollection<CreditNote> CreditNotes { get; set; }
        public ICollection<SalesReturnDetail>SalesReturnDetails { get; set; }
        public ICollection<CustomerInstallment> CustomerInstallments { get; set; }
        public ICollection<ApplyCredit>ApplyCredits { get; set; }
    }
}
