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
    
    public partial class Quotation
    {
        public Quotation()
        {
            this.QuotationDetails = new HashSet<QuotationDetail>();
            this.SalesInvoices = new HashSet<SalesInvoice>();
        }
    
        public int QuotationID { get; set; }
        public System.DateTime EntryDate { get; set; }
        public string Reference { get; set; }
        public int CustomerID { get; set; }
        public int PaymentTermID { get; set; }
        public int ServiceContractID { get; set; }
        public int EmployeeID { get; set; }
        public int UserID { get; set; }
        public int PreparedPersonID { get; set; }
        public int OrganizationalUnitID { get; set; }
        public int LocationID { get; set; }
        public int ApproverID { get; set; }
        public decimal TotalQuantity { get; set; }
        public decimal TotalAmount { get; set; }
        public decimal TotalVATAmount { get; set; }
        public decimal TotalGrossAmount { get; set; }
        public decimal AverageDiscountPercent { get; set; }
        public string Damages { get; set; }
        public string Causes { get; set; }
        public string Solutions { get; set; }
        public string Description { get; set; }
        public string Remarks { get; set; }
        public bool IsFinished { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public System.DateTime EditedDate { get; set; }
        public bool Approved { get; set; }
        public Nullable<System.DateTime> ApprovedDate { get; set; }
        public bool InActive { get; set; }
        public bool InActivePartial { get; set; }
        public Nullable<System.DateTime> InActiveDate { get; set; }
    
        public virtual Customer Customer { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual ICollection<QuotationDetail> QuotationDetails { get; set; }
        public virtual ServiceContract ServiceContract { get; set; }
        public virtual ICollection<SalesInvoice> SalesInvoices { get; set; }
    }
}
