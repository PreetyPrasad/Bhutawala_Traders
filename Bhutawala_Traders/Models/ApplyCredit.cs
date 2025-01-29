using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Routing.Matching;

namespace Bhutawala_Traders.Models
{
    public class ApplyCredit
    {
        [Key]
        public int ApplyId { get; set; }
        public int CreditNoteId { get; set; }
        public CreditNote? CreditNote {  get; set; }
        public int InvoiceId { get; set; }
        public InvoiceMaster? InvoiceMasters {  get; set; }
        public DateTime LogDate { get; set; }=DateTime.Now;
        public int StaffId { get; set; }
        public StaffMaster? StaffMaster { get; set; }
    }
}
