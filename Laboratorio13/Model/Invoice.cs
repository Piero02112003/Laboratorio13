﻿namespace Laboratorio13.Model
{
    public class Invoice
    {
        public int InvoiceId { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public DateTime Date { get; set; }
        public string InvoiceNumber { get; set; }    
        public float Total { get; set; }
        
    }
}
