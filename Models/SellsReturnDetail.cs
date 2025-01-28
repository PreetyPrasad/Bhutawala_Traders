using System.ComponentModel.DataAnnotations;

namespace inventroy.Models
{
    public class SellsReturnDetail
    {
        [Key]
        public int SellsID { get; set; }
        public int InvoiceId { get; set; }
        public int StockId { get; set; }
        public double Qty { get; set; }
        public string? unit {  get; set; }
        public int InvoiceDetailId { get; set; }
    }
}
