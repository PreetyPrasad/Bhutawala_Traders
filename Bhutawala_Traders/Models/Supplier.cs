using System.ComponentModel.DataAnnotations;

namespace Bhutawala_Traders.Models
{
    public class Supplier
    {
        [Key]
        public int SupplierId { get; set; }
        public string? BusinessName { get; set; }
        public string? ContactNo { get; set; }
        public string? Address { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public string? PinCode { get; set; }
        public string? GSTIN { get; set; }
        public string? PAN { get; set; }
        public string? BankBranch { get; set; }
        public string? IFSC { get; set; }
        public string? AccountNo { get; set; }
        public string? BankName { get; set; }
        public DateTime LogDate { get; set; }= DateTime.Now;
        public string? Email { get; set; }
    }
}
