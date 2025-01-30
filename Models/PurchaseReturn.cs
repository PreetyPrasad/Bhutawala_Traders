namespace inventroy.Models
{
    public class PurchaseReturn
    {
        public int PurchaseReturnId { get; set; }
        public int purchaseId { get; set; }
        public PurchaseMaster? PurchaseMaster { get; set; }
        public int StockId { get; set; }
        public Inwordstock? Inwordstock { get; set; }
        public double Qty { get; set; }
        public int Unit {  get; set; }
        public int Total {  get; set; }
        public DateTime ReturnDate { get; set; }
        public int StaffId { get; set; }

    }
}
