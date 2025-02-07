﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bhutawala_Traders.Models
{
    public class PurchaseMaster
    {
        public PurchaseMaster()
        {
            InwardStocks=new HashSet<InwardStock>();
            PurchasePayments=new HashSet<PurchasePayment>();
            PurchaseReturns=new HashSet<PurchaseReturn>();
        }
        [Key]
        public int PurchaseId { get; set; }
        [ForeignKey(nameof(Supplier))]
        public int SupplierId { get; set; }
        [Required]
        public string? BillNo { get; set; }
        [Required]
        public double GrossTotal { get; set; }
        [Required]
        public double GST { get; set; }
        [Required]
        public string? GST_Type { get; set; }
        [Required]
        public double Total { get; set; }
        [Required]
        public DateTime PurchaseDate { get; set; }= DateTime.Now;
        [Required]
        public DateTime NoticePeriod { get; set; }=DateTime.Now;
        [Required]
        public string? Note { get; set; }
        public ICollection<InwardStock> InwardStocks { get; set; }
        public ICollection<PurchasePayment> PurchasePayments { get; set; }
        public ICollection<PurchaseReturn> PurchaseReturns { get; set; }
    }
}
