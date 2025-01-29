using System.ComponentModel.DataAnnotations;

namespace Bhutawala_Traders.Models
{
    public class InvoiceMaster
    {
        [Key]
        public int InvoiceId { get; set; }
        public int InvoiceNo { get; set; }
        public string CustomerName { get; set; }=string.Empty;
        public string ContactNo { get; set; }= string.Empty;
        public double GrossAmt { get; set; }
        public double GSTAmt { get; set; }
        public string? GST_Type { get; set; }
        public double Total { get; set; }
        public DateTime InvoiceDate { get; set; }=DateTime.Now;
        public DateTime NoticePeriod { get; set; }= DateTime.Now;
        public double GSTIN { get; set; }
        public int StaffId { get; set; }


    }
}
