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
    using System.Collections.Generic;
    
    public partial class GoodsReceipt
    {
        public GoodsReceipt()
        {
            this.GoodsReceiptDetails = new HashSet<GoodsReceiptDetail>();
        }
    
        public int GoodsReceiptID { get; set; }
        public System.DateTime EntryDate { get; set; }
        public string Reference { get; set; }
        public int GoodsReceiptTypeID { get; set; }
        public int VoucherID { get; set; }
        public int UserID { get; set; }
        public int PreparedPersonID { get; set; }
        public int OrganizationalUnitID { get; set; }
        public int LocationID { get; set; }
        public int ApproverID { get; set; }
        public decimal TotalQuantity { get; set; }
        public string Description { get; set; }
        public string Remarks { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public System.DateTime EditedDate { get; set; }
        public bool Approved { get; set; }
        public Nullable<System.DateTime> ApprovedDate { get; set; }
        public bool InActive { get; set; }
        public bool InActivePartial { get; set; }
        public Nullable<System.DateTime> InActiveDate { get; set; }
        public decimal TotalAmount { get; set; }
        public decimal TotalVATAmount { get; set; }
        public decimal TotalGrossAmount { get; set; }
    
        public virtual ICollection<GoodsReceiptDetail> GoodsReceiptDetails { get; set; }
    }
}