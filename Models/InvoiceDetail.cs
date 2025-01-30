using System.ComponentModel.DataAnnotations;

namespace inventroy.Models
{
    public class InvoiceDetail
    {


        public InvoiceDetail()
        {
            CreditNotes = new HashSet<CreditNote>();
            SellsReturnDetails = new HashSet<SellsReturnDetail>();

        }
        [Key]
        public int Id { get; set; }
        [Required]

        public int MaterialId { get; set; }
        public Material? Material { get; set; }
        [Required]
        public double Rate { get; set; }
        [Required]
        public double Qty { get; set; } 
        [Required]
        public string unit { get; set; } = string.Empty;
        [Required]
        public double GST { get; set; }
        [Required]
        public double Total { get; set; }
        

        public ICollection<CreditNote> CreditNotes { get; set; }

        public ICollection<SellsReturnDetail> SellsReturnDetails { get; set; }


    }
}
