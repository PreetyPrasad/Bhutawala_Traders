using System.ComponentModel.DataAnnotations;

namespace inventroy.Models
{
    public class CreditNote
    {


        public CreditNote()
        {
            ApplyCredits = new HashSet<ApplyCredit>();
        }
        [Key]
        public int CreditId { get; set; }
        [Required]
        public int NoteNo { get; set; }
        [Required]
        public int InvoiceId { get; set; }
        public InvoiceMaster? InvoiceMaster { get; set; } 
       
        public int Amount { get; set; }
        [Required]
        public DateTime DateTime { get; set; } = DateTime.Now;
        
        public int StaffId { get; set; }
        public StaffMaster? StaffMaster { get; set; }
        public ICollection<ApplyCredit> ApplyCredits { get; set; }


    }
}
