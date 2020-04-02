﻿using System;
using System.Collections.Generic;

namespace PowerBiometricsAPI.Data.Models
{
    public partial class LedgerAccountTypes
    {
        public string CompanyId { get; set; }
        public string DivisionId { get; set; }
        public string DepartmentId { get; set; }
        public string GlaccountType { get; set; }
        public string LockedBy { get; set; }
        public DateTime? LockTs { get; set; }
        public string GlaccountTypeDescription { get; set; }
        public string BranchCode { get; set; }
    }
}
