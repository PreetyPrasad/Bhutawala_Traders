using System.ComponentModel.DataAnnotations;

namespace Bhutawala_Traders.Models
{
    public class PurchaseReturn
    {
        [Key]
        public int PurchaseReturnId { get; set; }
        public int PurchaseId { get; set; }
        public PurchaseMaster? PurchaseMasters {  get; set; }
        public int StockId { get; set; }
        public InwardStock? InwardStocks { get; set; }
        [Required]
        public double Qty { get; set; }
        [Required]
        public string? Unit { get; set; }
        [Required]
        public double Total { get; set; }
        [Required]
        public int StaffId { get; set; }
        public StaffMaster? StaffMasters {  get; set; }
    }
}
