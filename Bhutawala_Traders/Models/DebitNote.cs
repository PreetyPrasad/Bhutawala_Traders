using System.ComponentModel.DataAnnotations;

namespace Bhutawala_Traders.Models
{
    public class DebitNote
    {
        [Key]
        public int NoteId { get; set; }
        public int PurchaseId { get; set; }
        public double Amount { get; set; }
        public DateTime NoteDate { get; set; }= DateTime.Now;
        public DateTime LogDate { get; set; } = DateTime.Now;
        public int StaffId { get; set; }
    }
}
