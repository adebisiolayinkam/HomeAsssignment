//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Assesment.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Invoice
    {
        public int InvoiceNumber { get; set; }
        public string InvoiceDescription { get; set; }
        public double InvoiceAmount { get; set; }
        public System.DateTime InvoiceDate { get; set; }
        public System.DateTime DeliveryDate { get; set; }
        public System.DateTime SettleDate { get; set; }
        public double InvoiceVat { get; set; }
        public string Currency { get; set; }
        public double ExchangeRate { get; set; }
        public string Client { get; set; }
        public string OrderNumber { get; set; }
        public string SalesAgent { get; set; }
    }
}
