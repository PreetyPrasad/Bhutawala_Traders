using System.ComponentModel.DataAnnotations;

namespace inventroy.Models
{
    public class ApplyCredit
    {
        [Key]
        public int ApplyId { get; set; }
        public int CreditNoteId { get; set; }
        public int InvoiceId {  get; set; }
        public DateTime LogDate { get; set; } = DateTime.Now;

    }
}
