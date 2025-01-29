using System;
using System.ComponentModel.DataAnnotations;

namespace Bhutawala_Traders.Models
{
    public class InvoiceDetail
    {
        [Key]
        public int InvoiceDetailId { get; set; }
        public int MaterialId { get; set; }
        public double Rate { get; set; }
        public double Qty { get; set; }
        public string Unit { get; set; } = string.Empty;
        public double GST { get; set; }
        public double Total { get; set; }
    }
}
