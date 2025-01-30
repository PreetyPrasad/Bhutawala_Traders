using System.ComponentModel.DataAnnotations;

namespace Bhutawala_Traders.Models
{
    public class Supplier
    {
        public Supplier()
        {
            PurchaseMasters=new HashSet<PurchaseMaster>();
        }
        [Key]
        public int SupplierId { get; set; }
        [Required]
        public string? BusinessName { get; set; }
        [Required]
        public string? ContactNo { get; set; }
        [Required]
        public string? Email { get; set; }
        [Required]
        public string? Address { get; set; }
        [Required]
        public string? City { get; set; }
        [Required]
        public string? State { get; set; }
        [Required]
        public string? PinCode { get; set; }
        [Required]
        public string? GSTIN { get; set; }
        public string? PAN { get; set; }
        public string? AccountHolder { get; set; }
        [Required]
        public string? IFSC { get; set; }
        [Required]
        public string? AccountNo { get; set; }
        [Required]
        public string? BankName { get; set; }
        [Required]
        public DateTime LogDate { get; set; }= DateTime.Now;
        public ICollection<PurchaseMaster> PurchaseMasters { get; set; }
    }
}
