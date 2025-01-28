using System.ComponentModel.DataAnnotations;

namespace inventroy.Models
{
    public class CreditNote
    {
        [Key]
        public int CreditId { get; set; }
        public int NoteNo { get; set; }
        public int InvoiceId { get; set; }
        public int Amount { get; set; }
        public DateTime DateTime { get; set; } = DateTime.Now;


    }
}
