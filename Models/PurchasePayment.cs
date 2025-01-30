namespace inventroy.Models
{
    public class PurchasePayment
    {
        public int PaymentId { get; set; }
        public int PurchaseId { get; set; }
        public PurchaseMaster? PurchaseMaster { get; set; }
        public double? Amount { get; set; }
        public double? PaymentMode { get; set; }
        public string? RefNo { get; set; }
        public DateTime? PaymentDate { get; set; }= DateTime.Now;
        public DateTime? LogDate {  get; set; }= DateTime.Now;







    }
}
