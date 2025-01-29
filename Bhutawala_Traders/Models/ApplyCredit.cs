using System.ComponentModel.DataAnnotations;

namespace Bhutawala_Traders.Models
{
    public class ApplyCredit
    {
        [Key]
        public int ApplyId { get; set; }
        public int CreditNoteId { get; set; }
        public int InvoiceId { get; set; }
        public DateTime LogDate { get; set; }=DateTime.Now;
        public int StaffId { get; set; }
    }
}
