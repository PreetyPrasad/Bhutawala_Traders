using System.ComponentModel.DataAnnotations;

namespace Bhutawala_Traders.Models
{
    public class PurchaseReturn
    {
        [Key]
        public int PurchaseReturnId { get; set; }
        public int PurchaseId { get; set; }
        public int StockId { get; set; }
        public double Qty { get; set; }
        public string? Unit { get; set; }
        public double Total { get; set; }
        public int StaffId { get; set; }
    }
}
