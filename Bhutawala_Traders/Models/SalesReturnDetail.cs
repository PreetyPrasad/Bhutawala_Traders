using System.ComponentModel.DataAnnotations;

namespace Bhutawala_Traders.Models
{
    public class SalesReturnDetail
    {
        [Key]
        public int SalesId { get; set; }
        public int InvoiceId { get; set; }
        public InvoiceMaster? InvoiceMasters { get; set; }  
        public int StockId { get; set; }
        public InwardStock? InwardStocks { get; set; }
        [Required]
        public double Qty { get; set; }
        [Required]
        public string? Unit { get; set; }
        public int InvoiceDetailId { get; set; }
        public InvoiceDetail? InvoiceDetails {  get; set; }
        public int StaffId { get; set; }
        public StaffMaster? StaffMasters { get; set; }
    }
}
