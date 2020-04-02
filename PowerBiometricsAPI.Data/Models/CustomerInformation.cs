﻿using System;
using System.Collections.Generic;

namespace PowerBiometricsAPI.Data.Models
{
    public partial class CustomerInformation
    {
        public string CompanyId { get; set; }
        public string DivisionId { get; set; }
        public string DepartmentId { get; set; }
        public string CustomerId { get; set; }
        public string AccountStatus { get; set; }
        public string CustomerName { get; set; }
        public string CustomerAddress1 { get; set; }
        public string CustomerAddress2 { get; set; }
        public string CustomerAddress3 { get; set; }
        public string CustomerCity { get; set; }
        public string CustomerState { get; set; }
        public string CustomerZip { get; set; }
        public string CustomerCountry { get; set; }
        public string CustomerPhone { get; set; }
        public string CustomerFax { get; set; }
        public string CustomerEmail { get; set; }
        public string CustomerWebPage { get; set; }
        public string CustomerLogin { get; set; }
        public string CustomerPassword { get; set; }
        public string CustomerPasswordOld { get; set; }
        public DateTime? CustomerPasswordDate { get; set; }
        public bool? CustomerPasswordExpires { get; set; }
        public int? CustomerPasswordExpiresDate { get; set; }
        public string CustomerFirstName { get; set; }
        public string CustomerLastName { get; set; }
        public string CustomerSalutation { get; set; }
        public string Attention { get; set; }
        public string CustomerTypeId { get; set; }
        public string TaxIdno { get; set; }
        public string VattaxIdnumber { get; set; }
        public string VatTaxOtherNumber { get; set; }
        public string CurrencyId { get; set; }
        public string GlsalesAccount { get; set; }
        public string TermsId { get; set; }
        public string TermsStart { get; set; }
        public string EmployeeId { get; set; }
        public string TaxGroupId { get; set; }
        public string PriceMatrix { get; set; }
        public DateTime? PriceMatrixCurrent { get; set; }
        public string CreditRating { get; set; }
        public decimal? CreditLimit { get; set; }
        public string CreditComments { get; set; }
        public string PaymentDay { get; set; }
        public DateTime? ApprovalDate { get; set; }
        public DateTime? CustomerSince { get; set; }
        public bool? SendCreditMemos { get; set; }
        public bool? SendDebitMemos { get; set; }
        public bool? Statements { get; set; }
        public string StatementCycleCode { get; set; }
        public string CustomerSpecialInstructions { get; set; }
        public string CustomerShipToId { get; set; }
        public string CustomerShipForId { get; set; }
        public string ShipMethodId { get; set; }
        public string WarehouseId { get; set; }
        public string RoutingInfo1 { get; set; }
        public string RoutingInfo2 { get; set; }
        public string RoutingInfo3 { get; set; }
        public DateTime? RoutingInfoCurrent { get; set; }
        public string FreightPayment { get; set; }
        public bool? PickTicketsNeeded { get; set; }
        public bool? PackingListNeeded { get; set; }
        public bool? SpecialLabelsNeeded { get; set; }
        public bool? CustomerItemCodes { get; set; }
        public bool? ConfirmBeforeShipping { get; set; }
        public bool? Backorders { get; set; }
        public bool? UseStoreNumbers { get; set; }
        public bool? UseDepartmentNumbers { get; set; }
        public string SpecialShippingInstructions { get; set; }
        public string RoutingNotes { get; set; }
        public bool? ApplyRebate { get; set; }
        public double? RebateAmount { get; set; }
        public string RebateGlaccount { get; set; }
        public string RebateAmountNotes { get; set; }
        public bool? ApplyNewStore { get; set; }
        public double? NewStoreDiscount { get; set; }
        public string NewStoreGlaccount { get; set; }
        public string NewStoreDiscountNotes { get; set; }
        public bool? ApplyWarehouse { get; set; }
        public double? WarehouseAllowance { get; set; }
        public string WarehouseGlaccount { get; set; }
        public string WarehouseAllowanceNotes { get; set; }
        public bool? ApplyAdvertising { get; set; }
        public double? AdvertisingDiscount { get; set; }
        public string AdvertisingGlaccount { get; set; }
        public string AdvertisingDiscountNotes { get; set; }
        public bool? ApplyManualAdvert { get; set; }
        public double? ManualAdvertising { get; set; }
        public string ManualAdvertisingGlaccount { get; set; }
        public string ManualAdvertisingNotes { get; set; }
        public bool? ApplyTrade { get; set; }
        public double? TradeDiscount { get; set; }
        public string TradeDiscountGlaccount { get; set; }
        public string TradeDiscountNotes { get; set; }
        public string SpecialTerms { get; set; }
        public string Ediqualifier { get; set; }
        public string Ediid { get; set; }
        public string EditestQualifier { get; set; }
        public string EditestId { get; set; }
        public string EdicontactName { get; set; }
        public string EdicontactAgentFax { get; set; }
        public string EdicontactAgentPhone { get; set; }
        public string EdicontactAddressLine { get; set; }
        public bool? EdipurchaseOrders { get; set; }
        public bool? Ediinvoices { get; set; }
        public bool? Edipayments { get; set; }
        public bool? EdiorderStatus { get; set; }
        public bool? EdishippingNotices { get; set; }
        public bool? Approved { get; set; }
        public string ApprovedBy { get; set; }
        public DateTime? ApprovedDate { get; set; }
        public string EnteredBy { get; set; }
        public bool? ConvertedFromVendor { get; set; }
        public bool? ConvertedFromLead { get; set; }
        public string CustomerRegionId { get; set; }
        public string CustomerSourceId { get; set; }
        public string CustomerIndustryId { get; set; }
        public bool? Confirmed { get; set; }
        public DateTime? FirstContacted { get; set; }
        public DateTime? LastFollowUp { get; set; }
        public DateTime? NextFollowUp { get; set; }
        public bool? ReferedByExistingCustomer { get; set; }
        public string ReferedBy { get; set; }
        public DateTime? ReferedDate { get; set; }
        public string ReferalUrl { get; set; }
        public bool? Hot { get; set; }
        public string PrimaryInterest { get; set; }
        public string LockedBy { get; set; }
        public DateTime? LockTs { get; set; }
        public double? AccountBalance { get; set; }
        public bool? KnowYourCustomer { get; set; }
        public string CustomerOtherName { get; set; }
        public string BranchCode { get; set; }
    }
}
