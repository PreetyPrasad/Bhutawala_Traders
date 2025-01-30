using System.ComponentModel.DataAnnotations;

namespace inventroy.Models
{
    public class ApplyCredit
    {
        [Key]
        public int ApplyId { get; set; }
      
        public int CreditNoteId { get; set; }
        public CreditNote? CreditNote { get; set; }
     
        public int InvoiceId {  get; set; }
        public InvoiceMaster?  InvoiceMaster { get; set; }
        [Required]

        public DateTime LogDate { get; set; } = DateTime.Now;
        public int StaffId { get; set; }
        public StaffMaster? StaffMaster { get; set; }

    }
}
