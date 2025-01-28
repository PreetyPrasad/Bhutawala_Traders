using System.ComponentModel.DataAnnotations;

namespace inventroy.Models
{
    public class InvoiceDate
    {
        [Key]
        public int InvoiceId { get; set; }

        public int MaterialId { get; set; }
        public double Rate { get; set; }
        public double Qty { get; set; } 
        public string unit { get; set; } = string.Empty;
        public double GST { get; set; }
        public double Total { get; set; }


    }
}
