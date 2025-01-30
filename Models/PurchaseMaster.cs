using System.ComponentModel.DataAnnotations;

namespace inventroy.Models
{
    public class PurchaseMaster
    {
       
        [Key]
        public int PurchaseId { get; set; }
        [Required]
        public int SupplierId {  get; set; }
        public Supplier? Supplier { get; set; }
        [Required]
        public double GrossTotal { get; set; }
        [Required]
        public string? GST_Type { get; set; }
        [Required]
        public Double Total { get; set; }
        [Required]
        public DateTime PurchaseDate { get; set; } = DateTime.Now;
        [Required]
        public string? BillNo { get; set; }
        [Required]
        public DateTime NoticePeriod { get; set; }
        [Required]
        public string? Note {  get; set; }
        public int StaffId { get; set; }    


    }
}
