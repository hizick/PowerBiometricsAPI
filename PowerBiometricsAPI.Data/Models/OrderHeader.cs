﻿using System;
using System.Collections.Generic;

namespace PowerBiometricsAPI.Data.Models
{
    public partial class OrderHeader
    {
        public string CompanyId { get; set; }
        public string DivisionId { get; set; }
        public string DepartmentId { get; set; }
        public string OrderNumber { get; set; }
        public string TransactionTypeId { get; set; }
        public string OrderTypeId { get; set; }
        public DateTime? OrderDate { get; set; }
        public DateTime? OrderDueDate { get; set; }
        public DateTime? OrderShipDate { get; set; }
        public DateTime? OrderCancelDate { get; set; }
        public DateTime? SystemDate { get; set; }
        public bool? Memorize { get; set; }
        public string PurchaseOrderNumber { get; set; }
        public string TaxExemptId { get; set; }
        public string TaxGroupId { get; set; }
        public string CustomerId { get; set; }
        public string TermsId { get; set; }
        public string CurrencyId { get; set; }
        public double? CurrencyExchangeRate { get; set; }
        public decimal? Subtotal { get; set; }
        public double? DiscountPers { get; set; }
        public decimal? DiscountAmount { get; set; }
        public double? TaxPercent { get; set; }
        public decimal? TaxAmount { get; set; }
        public decimal? TaxableSubTotal { get; set; }
        public decimal? Freight { get; set; }
        public bool? TaxFreight { get; set; }
        public decimal? Handling { get; set; }
        public decimal? Advertising { get; set; }
        public decimal? Total { get; set; }
        public string EmployeeId { get; set; }
        public decimal? Commission { get; set; }
        public decimal? CommissionableSales { get; set; }
        public decimal? ComissionalbleCost { get; set; }
        public bool? CustomerDropShipment { get; set; }
        public string ShipMethodId { get; set; }
        public string WarehouseId { get; set; }
        public string ShipForId { get; set; }
        public string ShipToId { get; set; }
        public string ShippingName { get; set; }
        public string ShippingAddress1 { get; set; }
        public string ShippingAddress2 { get; set; }
        public string ShippingAddress3 { get; set; }
        public string ShippingCity { get; set; }
        public string ShippingState { get; set; }
        public string ShippingZip { get; set; }
        public string ShippingCountry { get; set; }
        public DateTime? ScheduledStartDate { get; set; }
        public DateTime? ScheduledEndDate { get; set; }
        public DateTime? ServiceStartDate { get; set; }
        public DateTime? ServiceEndDate { get; set; }
        public string PerformedBy { get; set; }
        public string GlsalesAccount { get; set; }
        public string Glcogaccount { get; set; }
        public string PaymentMethodId { get; set; }
        public decimal? AmountPaid { get; set; }
        public decimal? BalanceDue { get; set; }
        public decimal? UndistributedAmount { get; set; }
        public string CheckNumber { get; set; }
        public DateTime? CheckDate { get; set; }
        public string CreditCardTypeId { get; set; }
        public string CreditCardName { get; set; }
        public string CreditCardNumber { get; set; }
        public DateTime? CreditCardExpDate { get; set; }
        public string CreditCardCsvnumber { get; set; }
        public string CreditCardBillToZip { get; set; }
        public string CreditCardValidationCode { get; set; }
        public string CreditCardApprovalNumber { get; set; }
        public bool? Backordered { get; set; }
        public bool? Picked { get; set; }
        public DateTime? PickedDate { get; set; }
        public bool? Printed { get; set; }
        public DateTime? PrintedDate { get; set; }
        public bool? Shipped { get; set; }
        public DateTime? ShipDate { get; set; }
        public string TrackingNumber { get; set; }
        public bool? Billed { get; set; }
        public DateTime? BilledDate { get; set; }
        public bool? Invoiced { get; set; }
        public string InvoiceNumber { get; set; }
        public DateTime? InvoiceDate { get; set; }
        public bool? Posted { get; set; }
        public DateTime? PostedDate { get; set; }
        public double? AllowanceDiscountPerc { get; set; }
        public decimal? CashTendered { get; set; }
        public string MasterBillOfLading { get; set; }
        public DateTime? MasterBillOfLadingDate { get; set; }
        public string TrailerNumber { get; set; }
        public string TrailerPrefix { get; set; }
        public string HeaderMemo1 { get; set; }
        public string HeaderMemo2 { get; set; }
        public string HeaderMemo3 { get; set; }
        public string HeaderMemo4 { get; set; }
        public string HeaderMemo5 { get; set; }
        public string HeaderMemo6 { get; set; }
        public string HeaderMemo7 { get; set; }
        public string HeaderMemo8 { get; set; }
        public string HeaderMemo9 { get; set; }
        public bool? Approved { get; set; }
        public string ApprovedBy { get; set; }
        public DateTime? ApprovedDate { get; set; }
        public string EnteredBy { get; set; }
        public string Signature { get; set; }
        public string SignaturePassword { get; set; }
        public string SupervisorSignature { get; set; }
        public string SupervisorPassword { get; set; }
        public string ManagerSignature { get; set; }
        public string ManagerPassword { get; set; }
        public string LockedBy { get; set; }
        public DateTime? LockTs { get; set; }
        public string BankId { get; set; }
        public string OriginalOrderNumber { get; set; }
        public DateTime? OriginalOrderDate { get; set; }
        public string DeliveryNumber { get; set; }
        public string HeaderMemo10 { get; set; }
        public string HeaderMemo11 { get; set; }
        public string HeaderMemo12 { get; set; }
        public string Ullage1 { get; set; }
        public string Ullage2 { get; set; }
        public string Ullage3 { get; set; }
        public string Ullage4 { get; set; }
        public string Ullage5 { get; set; }
        public string Ullage6 { get; set; }
        public string Ullage7 { get; set; }
        public string Ullage8 { get; set; }
        public string Ullage9 { get; set; }
        public string Ullage10 { get; set; }
        public string Ullage11 { get; set; }
        public string Ullage12 { get; set; }
        public bool? Merged { get; set; }
        public bool? Created { get; set; }
        public bool? FinanceApproved { get; set; }
        public DateTime? FinanceApprovedDate { get; set; }
        public string FinanceComment { get; set; }
        public DateTime? FinanceReturnedDate { get; set; }
        public string FinanceApprovedBy { get; set; }
        public bool? Bdmapproved { get; set; }
        public DateTime? BdmapprovedDate { get; set; }
        public string Bdmcomment { get; set; }
        public DateTime? BdmreturnedDate { get; set; }
        public bool? Fmapproved { get; set; }
        public DateTime? FmapprovedDate { get; set; }
        public string Fmcomment { get; set; }
        public DateTime? FmreturnedDate { get; set; }
        public string FmapprovedBy { get; set; }
        public bool? Mdapproved { get; set; }
        public DateTime? MdapprovedDate { get; set; }
        public string Mdcomment { get; set; }
        public string MdapprovedBy { get; set; }
        public DateTime? MdreturnedDate { get; set; }
        public bool? Regularized { get; set; }
        public bool? Fmvoid { get; set; }
        public DateTime? FmvoidedDate { get; set; }
        public string ReceiptId { get; set; }
        public bool? CommercialApproved { get; set; }
        public DateTime? CommercialApprovedDate { get; set; }
        public string CommercialComment { get; set; }
        public DateTime? CommercialReturnedDate { get; set; }
        public string CommercialApprovedBy { get; set; }
        public bool? Cooapproved { get; set; }
        public DateTime? CooapprovedDate { get; set; }
        public string Coocomment { get; set; }
        public string CooapprovedBy { get; set; }
        public DateTime? CooreturnedDate { get; set; }
        public DateTime? EnteredDate { get; set; }
        public string BranchCode { get; set; }
    }
}
