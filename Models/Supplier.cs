namespace inventroy.Models
{
    public class Supplier
    {
        public int SupplierId { get; set; }
        public string? BusinessName { get; set; }
        
        public string? ContactNo { get; set; } 
        public String? Address { get; set; } 
        public string? City { get; set; } 
        public string? State {  get; set; } 
        public string? PinCode { get; set; } 
        public string? GSTIN { get; set; } 
       
        public String? PAN { get; set; }
        public string? BanckBranch { get; set; } 
        public string? IFSC { get; set; }
        public string? AccountNo { get; set; }
        public string? BankName { get; set; }
        public DateTime LogDate { get; set; } = DateTime.Now;
        public string? Email { get; set; }

    }
}
