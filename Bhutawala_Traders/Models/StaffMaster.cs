using System.ComponentModel.DataAnnotations;

namespace Bhutawala_Traders.Models
{
    public class StaffMaster
    {
        [Key]
        public int StaffId { get; set; }
        public string? FullName { get;set; }
        public string? Address { get; set; }
        public string? ContactNo { get; set; }
        public string? Category { get; set; }
        public string? Qualification { get; set; }
        public double AdhaarNo { get; set; }
        public int Age { get; set; }
        public DateTime DateOfJoining { get; set; } = DateTime.Now;
        public string? Email { get; set; }
        public string? Password { get; set; }
        public DateTime LogDate { get; set; } = DateTime.Now;
    }
}
