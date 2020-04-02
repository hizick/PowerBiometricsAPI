﻿using System;
using System.Collections.Generic;

namespace PowerBiometricsAPI.Data.Models
{
    public partial class EdiinvoiceDetail
    {
        public string CompanyId { get; set; }
        public string DivisionId { get; set; }
        public string DepartmentId { get; set; }
        public string InvoiceNumber { get; set; }
        public decimal InvoiceLineNumber { get; set; }
        public string ItemId { get; set; }
        public string WarehouseId { get; set; }
        public string SerialNumber { get; set; }
        public double? OrderQty { get; set; }
        public bool? BackOrdered { get; set; }
        public double? BackOrderQty { get; set; }
        public string ItemUom { get; set; }
        public double? ItemWeight { get; set; }
        public string Description { get; set; }
        public double? DiscountPerc { get; set; }
        public bool? Taxable { get; set; }
        public string CurrencyId { get; set; }
        public double? CurrencyExchangeRate { get; set; }
        public decimal? ItemCost { get; set; }
        public decimal? ItemUnitPrice { get; set; }
        public decimal? Total { get; set; }
        public double? TotalWeight { get; set; }
        public string GlsalesAccount { get; set; }
        public string ProjectId { get; set; }
        public string TrackingNumber { get; set; }
        public string DetailMemo1 { get; set; }
        public string DetailMemo2 { get; set; }
        public string DetailMemo3 { get; set; }
        public string DetailMemo4 { get; set; }
        public string DetailMemo5 { get; set; }
        public string LockedBy { get; set; }
        public DateTime? LockTs { get; set; }
        public string TaxGroupId { get; set; }
        public decimal? TaxAmount { get; set; }
        public double? TaxPercent { get; set; }
        public decimal? SubTotal { get; set; }
        public string BranchCode { get; set; }
    }
}
