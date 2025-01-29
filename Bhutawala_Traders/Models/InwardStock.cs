using System.ComponentModel.DataAnnotations;

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
        public int MaterialId { get; set; }
        public Material? Materials {  get; set; }
        public int PurchaseId { get; set; }
        public PurchaseMaster? PurchaseMasters { get; set; }
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
        public int StaffId { get; set; }
        public StaffMaster? StaffMasters { get; set; }
        public ICollection<SalesReturnDetail> SalesReturnDetails { get; set; }
        public ICollection<PurchaseReturn>PurchaseReturns { get; set; }
    }
}
