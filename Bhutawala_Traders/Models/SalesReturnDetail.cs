using System.ComponentModel.DataAnnotations;

namespace Bhutawala_Traders.Models
{
    public class SalesReturnDetail
    {
        [Key]
        public int SalesId { get; set; }
        public int InvoiceId { get; set; }
        public int StockId { get; set; }
        public double Qty { get; set; }
        public string? Unit { get; set; }
        public int InvoiceDetailId { get; set; }
        public int StaffId { get; set; }
    }
}
