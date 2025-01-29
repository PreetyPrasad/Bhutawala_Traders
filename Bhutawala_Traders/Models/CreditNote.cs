using System.ComponentModel.DataAnnotations;

namespace Bhutawala_Traders.Models
{
    public class CreditNote
    {
        public CreditNote()
        {
            ApplyCredits=new HashSet<ApplyCredit>();
        }
        [Key]
        public int CreditId { get; set; }
        [Required]
        public int NoteNo { get; set; }
        [Required]
        public int InvoiceId { get; set; }
        public InvoiceMaster? InvoiceMasters {  get; set; }
        [Required]
        public int Amount { get; set; }
        [Required]
        public DateTime NoteDate { get; set; } = DateTime.Now;
        public int StaffId { get; set; }
        public StaffMaster? StaffMasters {  get; set; }
        public ICollection<ApplyCredit>ApplyCredits { get; set; }
    }
}
