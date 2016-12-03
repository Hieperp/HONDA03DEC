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
    
    public partial class StockTransfer
    {
        public StockTransfer()
        {
            this.StockTransferDetails = new HashSet<StockTransferDetail>();
        }
    
        public int StockTransferID { get; set; }
        public System.DateTime EntryDate { get; set; }
        public string Reference { get; set; }
        public Nullable<int> TransferOrderID { get; set; }
        public int WarehouseID { get; set; }
        public int StockTransferTypeID { get; set; }
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
    
        public virtual ICollection<StockTransferDetail> StockTransferDetails { get; set; }
        public virtual Warehouse Warehouse { get; set; }
        public virtual TransferOrder TransferOrder { get; set; }
        public virtual StockTransferType StockTransferType { get; set; }
    }
}
