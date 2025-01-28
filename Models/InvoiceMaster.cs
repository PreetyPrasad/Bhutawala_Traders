using System.ComponentModel.DataAnnotations;

namespace inventroy.Models
{
    public class InvoiceMaster
    {
        [Key]
        public int InvoiceId {  get; set; }
        public int InvoiceNo { get; set; }
        public string CustomerName { get; set; } = string.Empty;
        public string ContactNo { get; set; }= string.Empty;
        public double GrossAmount { get; set; }
        public double GSTAmount {  get; set; }
        public string GST_TYPE { get; set; }

        public double Total {  get; set; }
        public DateTime InvoiceDate { get; set; } = DateTime.Now;
        public DateTime NoticePeriod { get; set; }  =DateTime.Now;

    }
}
