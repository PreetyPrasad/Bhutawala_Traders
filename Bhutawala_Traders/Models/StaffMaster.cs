using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography;

namespace Bhutawala_Traders.Models
{
    public class StaffMaster
    {
        public StaffMaster()
        {
            InwardStocks=new HashSet<InwardStock>();
            InvoiceMasters = new HashSet<InvoiceMaster>();
            CreditNotes = new HashSet<CreditNote>();
            CustomerInstallments=new HashSet<CustomerInstallment>();
            ApplyCredits = new HashSet<ApplyCredit>();
        }
        [Key]
        public int StaffId { get; set; }
        [Required]
        public string? FullName { get;set; }
        [Required]
        public string? Address { get; set; }
        [Required]
        public string? ContactNo { get; set; }
        [Required]
        public string? Category { get; set; }
        [Required]
        public string? Qualification { get; set; }
        [Required]
        public double AdhaarNo { get; set; }
        [Required]
        public int Age { get; set; }
        [Required]
        public DateTime DateOfJoining { get; set; } = DateTime.Now;
        [Required]
        public string? Email { get; set; }
        [Required]
        public string? Password { get; set; }
        public DateTime LogDate { get; set; } = DateTime.Now;

        public ICollection<InwardStock> InwardStocks { get; set; }
        public ICollection<InvoiceMaster> InvoiceMasters { get; set; }
        public ICollection<CreditNote> CreditNotes { get; set; }
        public ICollection<CustomerInstallment> CustomerInstallments { get; set; }
        public ICollection<ApplyCredit>ApplyCredits { get; set; }

        }
    }
