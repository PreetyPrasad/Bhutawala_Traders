using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bhutawala_Traders.Models
{
    public class InwardStock
    {
        public InwardStock()
        {
            SalesReturnDetails=new HashSet<SalesReturnDetail>();
            PurchaseReturns = new HashSet<PurchaseReturn>();
        }
        [Key]
        public int StockId { get; set; }
        [ForeignKey(nameof(Material))]
        public int MaterialId { get; set; }
        [ForeignKey(nameof(PurchaseMaster))]
        public int PurchaseId { get; set; }
        [Required]
        public double Qty { get; set; }
        [Required]
        public string Unit { get; set; }=string.Empty;
        [Required]
        public double Cost { get; set; }
        [Required]
        public DateTime RecieveDate { get; set; }=DateTime.Now;
        [Required]
        public string? Note { get; set; }
        [ForeignKey(nameof(StaffMaster))]
        public int StaffId { get; set; }
        public ICollection<SalesReturnDetail> SalesReturnDetails { get; set; }
        public ICollection<PurchaseReturn>PurchaseReturns { get; set; }
    }
}
