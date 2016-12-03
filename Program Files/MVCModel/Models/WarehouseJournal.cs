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
    
    public partial class WarehouseJournal
    {
        public int NMVNTaskID { get; set; }
        public int JournalPrimaryID { get; set; }
        public Nullable<System.DateTime> JournalDate { get; set; }
        public string JournalReference { get; set; }
        public string JournalDescription { get; set; }
        public Nullable<int> WarehouseID { get; set; }
        public string WarehouseName { get; set; }
        public int CommodityID { get; set; }
        public string CommodityCode { get; set; }
        public string CommodityName { get; set; }
        public Nullable<int> AmountBegin { get; set; }
        public Nullable<int> AmountEnd { get; set; }
        public string SalesUnit { get; set; }
        public string WarehouseCode { get; set; }
        public Nullable<decimal> QuantityBeginREC { get; set; }
        public Nullable<int> QuantityBeginTRA { get; set; }
        public Nullable<decimal> QuantityInputINV { get; set; }
        public Nullable<int> UnitPriceInputINV { get; set; }
        public Nullable<int> AmountInputINV { get; set; }
        public Nullable<int> VATAmountInputINV { get; set; }
        public Nullable<int> GrossAmountInputINV { get; set; }
        public Nullable<decimal> QuantityInputTRA { get; set; }
        public Nullable<decimal> QuantityOutputINV { get; set; }
        public Nullable<int> AmountOutputINV { get; set; }
        public Nullable<decimal> QuantityOutputTRA { get; set; }
        public Nullable<decimal> QuantityEndREC { get; set; }
        public Nullable<int> QuantityEndTRA { get; set; }
        public int CommodityCategoryID { get; set; }
        public string CommodityCategory1 { get; set; }
        public string CommodityCategory2 { get; set; }
        public string CommodityCategory3 { get; set; }
    }
}
