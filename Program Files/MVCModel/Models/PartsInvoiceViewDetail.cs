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
    
    public partial class PartsInvoiceViewDetail
    {
        public int SalesInvoiceDetailID { get; set; }
        public int SalesInvoiceID { get; set; }
        public int CommodityID { get; set; }
        public string CommodityCode { get; set; }
        public string CommodityName { get; set; }
        public int WarehouseID { get; set; }
        public string WarehouseCode { get; set; }
        public Nullable<decimal> QuantityAvailable { get; set; }
        public decimal Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal DiscountPercent { get; set; }
        public decimal Amount { get; set; }
        public decimal VATPercent { get; set; }
        public decimal VATAmount { get; set; }
        public decimal GrossAmount { get; set; }
        public string Remarks { get; set; }
        public Nullable<bool> IsWarrantyClaim { get; set; }
        public int CommodityTypeID { get; set; }
        public decimal ListedPrice { get; set; }
        public decimal GrossPrice { get; set; }
        public Nullable<bool> IsBonus { get; set; }
    }
}
