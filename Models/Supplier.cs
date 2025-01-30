using System.ComponentModel.DataAnnotations;

namespace inventroy.Models
{
    public class Supplier
    {
        public Supplier()
        {
            StaffMasters = new HashSet<StaffMaster>();

        }
        [Key]
        public int SupplierId { get; set; }
        [Required]
        public string? BusinessName { get; set; }
        [Required]
        public string? ContactNo { get; set; } 
        [Required]
        public String? Address { get; set; } 
        [Required]
        public string? City { get; set; } 
        [Required]
        public string? State {  get; set; } 
        [Required]
        public string? PinCode { get; set; }
            [Required]
        public string? GSTIN { get; set; } 
        [Required]
       
        public String? PAN { get; set; }
        [Required]
        public string? BanckBranch { get; set; } 
        [Required]
        public string? IFSC { get; set; }
        [Required]
        public string? AccountNo { get; set; }
        [Required]
        public string? BankName { get; set; }
        [Required]
        public DateTime LogDate { get; set; } = DateTime.Now;
        [Required]
        public string? Email { get; set; }
        public ICollection<StaffMaster> StaffMasters { get; set; }



    }
}
