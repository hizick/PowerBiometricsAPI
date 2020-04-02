﻿using System;
using System.Collections.Generic;

namespace PowerBiometricsAPI.Data.Models
{
    public partial class PortalBannerTypes
    {
        public string CompanyId { get; set; }
        public string DivisionId { get; set; }
        public string DepartmentId { get; set; }
        public string PortalId { get; set; }
        public string PortalBannerType { get; set; }
        public string PortalBannerTypeDescription { get; set; }
        public string LockedBy { get; set; }
        public DateTime? LockTs { get; set; }
        public string BranchCode { get; set; }
    }
}
