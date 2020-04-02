﻿using System;
using System.Collections.Generic;

namespace PowerBiometricsAPI.Data.Models
{
    public partial class AccessPermissions
    {
        public string CompanyId { get; set; }
        public string DivisionId { get; set; }
        public string DepartmentId { get; set; }
        public string EmployeeId { get; set; }
        public string DefaultPageToDisplay { get; set; }
        public string MachineName { get; set; }
        public bool? RestrictMultipleLogins { get; set; }
        public string Ipaddress { get; set; }
        public bool? RestrictSecurityIp { get; set; }
        public short? SecurityLevel { get; set; }
        public bool? Oeview { get; set; }
        public bool? Oeadd { get; set; }
        public bool? Oeedit { get; set; }
        public bool? Oedelete { get; set; }
        public bool? Oereports { get; set; }
        public bool? Oesetup { get; set; }
        public bool? Arview { get; set; }
        public bool? Aradd { get; set; }
        public bool? Aredit { get; set; }
        public bool? Ardelete { get; set; }
        public bool? Arreports { get; set; }
        public bool? Arsetup { get; set; }
        public bool? Poview { get; set; }
        public bool? Poadd { get; set; }
        public bool? Poedit { get; set; }
        public bool? Podelete { get; set; }
        public bool? Poreports { get; set; }
        public bool? Posetup { get; set; }
        public bool? Apview { get; set; }
        public bool? Apadd { get; set; }
        public bool? Apedit { get; set; }
        public bool? Apdelete { get; set; }
        public bool? Apchecks { get; set; }
        public bool? Apreports { get; set; }
        public bool? Apsetup { get; set; }
        public bool? Glview { get; set; }
        public bool? Gladd { get; set; }
        public bool? Gledit { get; set; }
        public bool? Gldelete { get; set; }
        public bool? Glreports { get; set; }
        public bool? Glfinancials { get; set; }
        public bool? GlmonthEnd { get; set; }
        public bool? GlyearEnd { get; set; }
        public bool? Glsetup { get; set; }
        public bool? Emview { get; set; }
        public bool? Emadd { get; set; }
        public bool? Emedit { get; set; }
        public bool? Emdelete { get; set; }
        public bool? Emreports { get; set; }
        public bool? Emsetup { get; set; }
        public bool? Prview { get; set; }
        public bool? Pradd { get; set; }
        public bool? Predit { get; set; }
        public bool? Prdelete { get; set; }
        public bool? Prchecks { get; set; }
        public bool? Prreports { get; set; }
        public bool? Prsetup { get; set; }
        public bool? Whpick { get; set; }
        public bool? Whpack { get; set; }
        public bool? Whship { get; set; }
        public bool? Whprint { get; set; }
        public bool? Whreceive { get; set; }
        public bool? Whtransfer { get; set; }
        public bool? Whadjust { get; set; }
        public bool? Whsetup { get; set; }
        public bool? Woview { get; set; }
        public bool? Woadd { get; set; }
        public bool? Woedit { get; set; }
        public bool? Wodelete { get; set; }
        public bool? Woreports { get; set; }
        public bool? Woforecast { get; set; }
        public bool? Wosetup { get; set; }
        public bool? Adview { get; set; }
        public bool? Adsetup { get; set; }
        public bool? Adsecurity { get; set; }
        public bool? ChallangeView { get; set; }
        public bool? ChallangeAdd { get; set; }
        public bool? ChallangeEdit { get; set; }
        public bool? ChallangeDelete { get; set; }
        public bool? ChallangeReports { get; set; }
        public bool? ChallangeSetup { get; set; }
        public bool? AuditView { get; set; }
        public bool? AuditAdd { get; set; }
        public bool? AuditEdit { get; set; }
        public bool? AuditDelete { get; set; }
        public bool? AuditReports { get; set; }
        public bool? AuditSetup { get; set; }
        public bool? ApproveCustomer { get; set; }
        public bool? ApproveVendor { get; set; }
        public bool? ApprovePayment { get; set; }
        public bool? ApprovePurchase { get; set; }
        public bool? ApproveTransfer { get; set; }
        public bool? ApproveAdjustment { get; set; }
        public bool? ApproveReceipt { get; set; }
        public bool? ApprovePayroll { get; set; }
        public bool? ApproveApchedks { get; set; }
        public bool? ApproveEmployees { get; set; }
        public bool? ApproveItems { get; set; }
        public bool? ApproveLowMargins { get; set; }
        public bool? ApproveOrders { get; set; }
        public bool? ApproveContract { get; set; }
        public bool? ApproveReturns { get; set; }
        public bool? ApproveRma { get; set; }
        public string LockedBy { get; set; }
        public DateTime? LockTs { get; set; }
        public bool? Cbaview { get; set; }
        public bool? Cbaadd { get; set; }
        public bool? Cbaedit { get; set; }
        public bool? Cbadelete { get; set; }
        public bool? Cbcview { get; set; }
        public bool? Cbcadd { get; set; }
        public bool? Cbcedit { get; set; }
        public bool? Cbcdelete { get; set; }
        public bool? Cbrview { get; set; }
        public bool? Cbradd { get; set; }
        public bool? Cbredit { get; set; }
        public bool? Cbrdelete { get; set; }
        public bool? Cbpview { get; set; }
        public bool? Cbpadd { get; set; }
        public bool? Cbpedit { get; set; }
        public bool? Cbpdelete { get; set; }
        public bool? Cbpadview { get; set; }
        public bool? Cbpapview { get; set; }
        public bool? Cbppview { get; set; }
        public bool? Cbtview { get; set; }
        public bool? Cbtadd { get; set; }
        public bool? Cbtedit { get; set; }
        public bool? Cbtdelete { get; set; }
        public bool? Cbtapview { get; set; }
        public bool? Cbtpview { get; set; }
        public bool? Cbrcview { get; set; }
        public bool? Cbrcadd { get; set; }
        public bool? Cbrcedit { get; set; }
        public bool? Cbrcdelete { get; set; }
        public bool? Glbview { get; set; }
        public bool? Glbadd { get; set; }
        public bool? Glbedit { get; set; }
        public bool? Glbdelete { get; set; }
        public bool? Glfview { get; set; }
        public bool? Glfadd { get; set; }
        public bool? Glfedit { get; set; }
        public bool? Glfdelete { get; set; }
        public bool? Gllaview { get; set; }
        public bool? Gllaadd { get; set; }
        public bool? Gllaedit { get; set; }
        public bool? Glladelete { get; set; }
        public bool? Gllpview { get; set; }
        public bool? Gllpadd { get; set; }
        public bool? Gllpedit { get; set; }
        public bool? Gllpdelete { get; set; }
        public bool? Gljview { get; set; }
        public bool? Gljadd { get; set; }
        public bool? Gljedit { get; set; }
        public bool? Gljdelete { get; set; }
        public bool? Gljapview { get; set; }
        public bool? Gljpview { get; set; }
        public bool? Faview { get; set; }
        public bool? Faadd { get; set; }
        public bool? Faedit { get; set; }
        public bool? Fadelete { get; set; }
        public bool? InvView { get; set; }
        public bool? InvAdd { get; set; }
        public bool? InvEdit { get; set; }
        public bool? InvDelete { get; set; }
        public bool? InvCview { get; set; }
        public bool? InvCadd { get; set; }
        public bool? InvCedit { get; set; }
        public bool? InvCdelete { get; set; }
        public bool? InvFview { get; set; }
        public bool? InvFadd { get; set; }
        public bool? InvFedit { get; set; }
        public bool? InvFdelete { get; set; }
        public bool? InvAview { get; set; }
        public bool? InvAadd { get; set; }
        public bool? InvAedit { get; set; }
        public bool? InvAdelete { get; set; }
        public bool? InvTview { get; set; }
        public bool? InvTadd { get; set; }
        public bool? InvTedit { get; set; }
        public bool? InvTdelete { get; set; }
        public bool? InvTaview { get; set; }
        public bool? InvTpview { get; set; }
        public bool? InvIview { get; set; }
        public bool? InvIadd { get; set; }
        public bool? InvIedit { get; set; }
        public bool? InvIdelete { get; set; }
        public bool? InvIaview { get; set; }
        public bool? InvIpview { get; set; }
        public bool? InvRview { get; set; }
        public bool? InvRadd { get; set; }
        public bool? InvRedit { get; set; }
        public bool? InvRdelete { get; set; }
        public bool? InvRaview { get; set; }
        public bool? InvRpview { get; set; }
        public bool? ProdView { get; set; }
        public bool? ProdAdd { get; set; }
        public bool? ProdEdit { get; set; }
        public bool? ProdDelete { get; set; }
        public bool? ProdWaview { get; set; }
        public bool? ProdWiview { get; set; }
        public bool? ProdWcview { get; set; }
        public bool? Oebview { get; set; }
        public bool? Oehview { get; set; }
        public bool? Oepview { get; set; }
        public bool? Oeiview { get; set; }
        public bool? Ariview { get; set; }
        public bool? Ariadd { get; set; }
        public bool? Ariedit { get; set; }
        public bool? Aridelete { get; set; }
        public bool? Cbprview { get; set; }
        public bool? Aripost { get; set; }
        public bool? HrpayAdsetup { get; set; }
        public bool? HrpayTransView { get; set; }
        public bool? HrpayTransAdd { get; set; }
        public bool? HrpayTransEdit { get; set; }
        public bool? HrpayTransDelete { get; set; }
        public bool? HrpayEmpView { get; set; }
        public bool? HrpayEmpAdd { get; set; }
        public bool? HrpayEmpEdit { get; set; }
        public bool? HrpayEmpDelete { get; set; }
        public bool? HrpayProcessView { get; set; }
        public bool? HrpayReportView { get; set; }
        public bool? HrpayEmpAcctView { get; set; }
        public bool? HrpayEmpAcctAdd { get; set; }
        public bool? HrpayEmpAcctEdit { get; set; }
        public bool? HrpayEmpAcctDelete { get; set; }
        public bool? ProjView { get; set; }
        public bool? ProjAdd { get; set; }
        public bool? ProjEdit { get; set; }
        public bool? ProjDelete { get; set; }
        public bool? ProjApprove { get; set; }
        public bool? IsUser { get; set; }
        public bool? WebParamAdd { get; set; }
        public bool? WebParamEdit { get; set; }
        public bool? WebParamView { get; set; }
        public bool? Mtarview { get; set; }
        public bool? Mtapview { get; set; }
        public bool? Mtglview { get; set; }
        public bool? MtinventoryView { get; set; }
        public bool? Mtmrpview { get; set; }
        public bool? MtfundView { get; set; }
        public bool? Mtcrmview { get; set; }
        public bool? MtpayrollView { get; set; }
        public bool? MtsystemView { get; set; }
        public bool? MtreportsView { get; set; }
        public bool? MtfixedAssetView { get; set; }
        public bool? MtprojectView { get; set; }
        public bool? RtfinancialView { get; set; }
        public bool? Rtarview { get; set; }
        public bool? Rtapview { get; set; }
        public bool? Rtglview { get; set; }
        public bool? RtinventoryView { get; set; }
        public bool? Rtcrmview { get; set; }
        public bool? RtpayrollView { get; set; }
        public bool? RtsystemView { get; set; }
        public bool? RtfixedAssetView { get; set; }
        public bool? RtprojectView { get; set; }
        public bool? RtfundView { get; set; }
        public bool? Adreports { get; set; }
        public bool? InvReports { get; set; }
        public bool? Fareports { get; set; }
        public bool? Cbreports { get; set; }
        public bool? Pjreports { get; set; }
        public bool? Araright { get; set; }
        public bool? Cbaright { get; set; }
        public bool? Faright { get; set; }
        public bool? Oaright { get; set; }
        public bool? Paright { get; set; }
        public bool? Aparight { get; set; }
        public bool? Inaright { get; set; }
        public bool? Praright { get; set; }
        public bool? Pyaright { get; set; }
        public bool? ProjectAright { get; set; }
        public bool? Glaright { get; set; }
        public bool? CbauditRight { get; set; }
        public bool? Oemview { get; set; }
        public bool? MtrequisitionsView { get; set; }
        public bool? Rqdelete { get; set; }
        public bool? Rqedit { get; set; }
        public bool? Rqadd { get; set; }
        public bool? Rqview { get; set; }
        public bool? Rqapproval { get; set; }
        public bool? Rqaright { get; set; }
        public bool? Rqreports { get; set; }
        public string BranchCode { get; set; }
    }
}