//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MVCModel.Models
{
    using System;
    
    public partial class VehiclesInvoiceIndex
    {
        public int SalesInvoiceID { get; set; }
        public System.DateTime EntryDate { get; set; }
        public string Reference { get; set; }
        public string VATInvoiceNo { get; set; }
        public string LocationCode { get; set; }
        public string CustomerDescription { get; set; }
        public string CommodityName { get; set; }
        public Nullable<decimal> GrossAmount { get; set; }
    }
}
