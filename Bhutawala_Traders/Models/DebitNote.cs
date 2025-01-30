using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bhutawala_Traders.Models
{
    public class DebitNote
    {
        [Key]
        public int NoteId { get; set; }
        [ForeignKey(nameof(PurchaseMaster))]
        public int PurchaseId { get; set; }
        [Required]
        public double Amount { get; set; }
        [Required]
        public DateTime NoteDate { get; set; }= DateTime.Now;
        public DateTime LogDate { get; set; } = DateTime.Now;
        [Required]
        [ForeignKey(nameof(StaffMaster))]
        public int StaffId { get; set; }
    }
}
