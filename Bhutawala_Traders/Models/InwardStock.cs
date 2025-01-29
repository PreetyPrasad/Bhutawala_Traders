using System.ComponentModel.DataAnnotations;

namespace Bhutawala_Traders.Models
{
    public class InwardStock
    {
        [Key]
        public int StockId { get; set; }
        public int MaterialId { get; set; }
        public int PurchaseId { get; set; }
        public double Qty { get; set; }
        public string Unit { get; set; }=string.Empty;
        public double Cost { get; set; }
        public DateTime RecieveDate { get; set; }=DateTime.Now;
        public string? Note { get; set; }
        public int StaffId { get; set; }
    }
}
