using System.ComponentModel.DataAnnotations;

namespace Bhutawala_Traders.Models
{
    public class DebitNote
    {
        [Key]
        public int NoteId { get; set; }
        public int PurchaseId { get; set; }
        public PurchaseMaster? PurchaseMasters {  get; set; }
        [Required]
        public double Amount { get; set; }
        [Required]
        public DateTime NoteDate { get; set; }= DateTime.Now;
        public DateTime LogDate { get; set; } = DateTime.Now;
        [Required]
        public int StaffId { get; set; }
        public StaffMaster? StaffMasters { get; set; }
    }
}
