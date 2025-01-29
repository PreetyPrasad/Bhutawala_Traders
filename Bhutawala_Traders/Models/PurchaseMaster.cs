using System.ComponentModel.DataAnnotations;

namespace Bhutawala_Traders.Models
{
    public class PurchaseMaster
    {
        [Key]
        public int PurchaseId { get; set; }
        public int SupplierId { get; set; }
        public double GrossTotal { get; set; }
        public double GST { get; set; }
        public string? GST_Type { get; set; }
        public double Total { get; set; }
        public DateTime PurchaseDate { get; set; }= DateTime.Now;
        public string? BillNo { get; set; }
        public DateTime NoticePeriod { get; set; }=DateTime.Now;
        public string? Note { get; set; }
    }
}
