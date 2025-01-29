using System.ComponentModel.DataAnnotations;

namespace Bhutawala_Traders.Models
{
    public class CreditNote
    {
        [Key]
        public int CreditId { get; set; }
        public int NoteNo { get; set; }
        public int InvoiceId { get; set; }
        public int Amount { get; set; }
        public DateTime NoteDate { get; set; } = DateTime.Now;
        public int StaffId { get; set; }

    }
}
