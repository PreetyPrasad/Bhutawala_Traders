using System.ComponentModel.DataAnnotations;

namespace inventroy.Models
{
    public class Inwordstock
    {
        [Key]
        public int StockId { get; set; }

        public int  MaterialId { get; set; }
        public int PurchaseId { get; set; }
        public double Qty { get; set; }

        public string Unit { get; set; } = string.Empty;
        public double Cost { get; set; }
        public DateTime RecivedDate { get; set; } = DateTime.Now;
        public string? Note { get; set; }

    }
}
