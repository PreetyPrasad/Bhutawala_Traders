﻿using System.ComponentModel.DataAnnotations;

namespace inventroy.Models
{
    public class CustomerInstallment
    {
        [Key]
        public int CustomerInstallmentId { get; set; }
        public int InvoicId { get; set; }
        public double Amount { get; set; }
        public string Paymentmode { get; set; } = string.Empty;
        public string? RefNo { get; set; }
        public DateTime PaymentDate { get; set; } = DateTime.Now; 
        public DateTime LogDate { get; set; } = DateTime.Now;


    }
}
