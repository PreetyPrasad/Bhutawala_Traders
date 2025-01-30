using System.ComponentModel.DataAnnotations;

namespace inventroy.Models
{
    public class StaffMaster
    {

        public StaffMaster() 
        {
            Inwordstocks = new HashSet<Inwordstock>();
            InvoiceMasters = new HashSet<InvoiceMaster>();
            CreditNotes = new HashSet<CreditNote>();
            SellsReturnDetails = new HashSet<SellsReturnDetail>();
            CustomerInstallments = new HashSet<CustomerInstallment>();
            ApplyCredits = new HashSet<ApplyCredit>();
            PurchaseMasters = new HashSet<PurchaseMaster>();
            DabitNotes = new HashSet<DabitNote>();

        }
        [Key]
        public int StaffId { get; set; }
        public string FullName { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public int ContactNo { get; set; }
        [Required]
        public string? Category { get; set; }
        public string Qualification { get; set; } = string.Empty;
        [Required]
        public string? Adhar {  get; set; }
        [Required]
        public int Age { get; set; }
        public  DateTime JoinDate { get; set; }
        [Required]
        public string? Email { get; set; }
        [Required]
        public string? Password { get; set; }
        [Required]
        public DateTime LogDate { get; set; } = DateTime.Now;
        public ICollection<Inwordstock> Inwordstocks { get; set; }
        public ICollection<InvoiceMaster> InvoiceMasters { get; set; }
        public ICollection<CreditNote> CreditNotes { get; set; }
        public ICollection<SellsReturnDetail> SellsReturnDetails { get; set; }
        public ICollection<CustomerInstallment> CustomerInstallments { get; set; }
        public ICollection<ApplyCredit> ApplyCredits { get; set; }
        public ICollection<PurchaseMaster> PurchaseMasters { get; set; }
        public ICollection<DabitNote> DabitNotes { get; set; }





    }
}
