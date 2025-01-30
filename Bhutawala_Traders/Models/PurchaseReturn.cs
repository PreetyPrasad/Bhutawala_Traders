using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bhutawala_Traders.Models
{
    public class PurchaseReturn
    {
        [Key]
        public int PurchaseReturnId { get; set; }
        [ForeignKey(nameof(PurchaseMaster))]
        public int PurchaseId { get; set; }
        [ForeignKey(nameof(InwardStock))]
        public int StockId { get; set; }
        [Required]
        public double Qty { get; set; }
        [Required]
        public string? Unit { get; set; }
        [Required]
        public double Total { get; set; }
        [Required]
        [ForeignKey(nameof(StaffMaster))]
        public int StaffId { get; set; }
        public DateTime LogDate { get; set; } = DateTime.Now;
    }
}
