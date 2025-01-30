namespace inventroy.Models
{
    public class DabitNote
    {
        public int NoteId { get; set; }
        public int PurchaseId { get; set; }
        public int Amount { get; set; }
        public DateTime NoteDate { get; set; }
        public DateTime LogDate { get; set; }
        public int StockId { get; set; }
        public  Inwordstock? Inwordstock { get; set; }
        public int StaffId {  get; set; }
        public StaffMaster? StaffMaster { get; set; }


    }
}
