using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Routing.Matching;

namespace Bhutawala_Traders.Models
{
    public class ApplyCredit
    {
        [Key]
        public int ApplyId { get; set; }
        [ForeignKey(nameof(CreditNote))]
        public int CreditNoteId { get; set; }
        [ForeignKey(nameof(InvoiceMaster))]
        public int InvoiceId { get; set; }
        public DateTime LogDate { get; set; }=DateTime.Now;
        [ForeignKey(nameof(StaffMaster))]
        public int StaffId { get; set; }
    }
}
