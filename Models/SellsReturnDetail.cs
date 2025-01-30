using System.ComponentModel.DataAnnotations;

namespace inventroy.Models
{
    public class SellsReturnDetail
    {
        [Key]
        public int SellsID { get; set; }
        [Required]
        public int InvoiceId { get; set; }
        [Required]
        public InvoiceDetail? InvoiceDate { get; set; }
        [Required]
        public int StockId { get; set; }
        public Inwordstock? Inwordstock {  get; set; } 
        [Required]
        public double Qty { get; set; }
        [Required]
        public string? unit {  get; set; }
        [Required]
        public int InvoiceDetailId { get; set; }
        public int StaffId { get; set; }
        public StaffMaster? StaffMaster { get; set; }
    }
}
