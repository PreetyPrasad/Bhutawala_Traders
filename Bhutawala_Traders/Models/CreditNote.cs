using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
        [ForeignKey(nameof(InvoiceMaster))]
        public int InvoiceId { get; set; }
        [Required]
        public int Amount { get; set; }
        [Required]
        public DateTime NoteDate { get; set; } = DateTime.Now;
        [ForeignKey(nameof(StaffMaster))]
        public int StaffId { get; set; }
        public ICollection<ApplyCredit>ApplyCredits { get; set; }
    }
}
