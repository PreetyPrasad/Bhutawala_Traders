using System.ComponentModel.DataAnnotations;

namespace inventroy.Models
{
    public class Inwordstock
    {
        [Key]
        public int StockId { get; set; }

        public int  MaterialId { get; set; }
        public Material? Material { get; set; }
        public int PurchaseId { get; set; }
        public PurchaseMaster? PurchaseMaster { get; set; }
        public double Qty { get; set; }

        public string Unit { get; set; } = string.Empty;
        public double Cost { get; set; }
        public DateTime RecivedDate { get; set; } = DateTime.Now;
        public string? Note { get; set; }
        public int StaffId { get; set; }
        public StaffMaster? StaffMaster { get; set; }

    }
}
