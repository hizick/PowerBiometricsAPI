﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PowerBiometricsAPI.DomainModels;
using PowerBiometricsAPI.Data.Models;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Linq;


namespace PowerBiometricsAPI.Controllers
{
    //[Route("api/[controller]")]
    public class PowerBiometricsController : Controller
    {
        EnterpriseBaseContext _DBContext;
        public PowerBiometricsController(EnterpriseBaseContext _context)
        {
            _DBContext = _context;
        }

        // GET: api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        [HttpPost]
        public async Task<string> Post([FromHeader]List<Attendance> attendance)
        {
            List<PayrollHrpayrollAttHeader> payrollHrpayrollAttHeader = new List<PayrollHrpayrollAttHeader>();
            //Apitoken apiToken = new Apitoken();
            Attendance att = attendance.ElementAtOrDefault(0);

            bool status = false;
            string finalResult = "failed";
            try
            {
                var apiToken = await _DBContext.ApiToken.Where(a => a.Token == att.apiToken).FirstOrDefaultAsync();
                if (apiToken != null)
                {
                    if (attendance != null)
                    {
                        foreach (Attendance attendanceObj in attendance)
                        {
                            PayrollHrpayrollAttHeader payrollHrpayrollAttHeaderObj = new PayrollHrpayrollAttHeader();

                            payrollHrpayrollAttHeaderObj.CompanyId = apiToken.CompanyId;
                            payrollHrpayrollAttHeaderObj.DivisionId = apiToken.DivisionId;
                            payrollHrpayrollAttHeaderObj.DepartmentId = apiToken.DepartmentId;
                            payrollHrpayrollAttHeaderObj.AttendanceDate = attendanceObj.AttendanceDate;
                            payrollHrpayrollAttHeaderObj.Remarks = attendanceObj.Remarks;
                            payrollHrpayrollAttHeaderObj.ClosedDate = attendanceObj.ClosedDate;
                            payrollHrpayrollAttHeaderObj.ClosedBy = attendanceObj.ClosedBy;
                            payrollHrpayrollAttHeaderObj.Period = attendanceObj.Period;
                            payrollHrpayrollAttHeaderObj.Status = attendanceObj.Status;
                            payrollHrpayrollAttHeaderObj.Closed = attendanceObj.Closed;
                            payrollHrpayrollAttHeaderObj.Cleared = attendanceObj.Cleared;
                            payrollHrpayrollAttHeaderObj.EnteredBy = attendanceObj.EnteredBy;
                            payrollHrpayrollAttHeaderObj.EnteredDate = attendanceObj.EnteredDate;
                            payrollHrpayrollAttHeaderObj.BranchCode = attendanceObj.BranchCode;

                            _DBContext.Entry(payrollHrpayrollAttHeaderObj).State = EntityState.Added;

                            status = await insertAttendanceDetail(apiToken, attendanceObj.attendanceDetail);

                            if (status)
                            {
                                await _DBContext.SaveChangesAsync();
                            }

                        }
                        finalResult = "success";
                    }

                }
                else
                {
                    return finalResult = "Invalid Token";
                }
            }
            catch (Exception e)
            {
                finalResult = ExceptionExtensions.GetFullMessage(e);
            }
            return await Task.FromResult(finalResult);
        }

        private async Task<bool> insertAttendanceDetail(Apitoken apiToken, List<AttendanceDetail> attendanceDetail)
        {
            AttendanceDetail payrollHrpayrollAttDetail = new AttendanceDetail();
            List<AttendanceDetail> attend = attendanceDetail;

            bool status = false;
            PayrollEmployees employeeDeets = new PayrollEmployees();
            try
            {
                if (attendanceDetail != null)
                {
                    List<AttendanceDetail> att = attendanceDetail.GroupBy(x => x.EmployeeId).Select(g => g.First()).ToList();
                    foreach (AttendanceDetail attendanceDetailObj in att)
                    {
                        PayrollHrpayrollAttDetail payrollHrpayrollAttDetailObj = new PayrollHrpayrollAttDetail();
                        employeeDeets = await getEmployeeID(apiToken, attendanceDetailObj);
                        string employeeID = employeeDeets.EmployeeId;
                        string employeeName = employeeDeets.EmployeeFirstname + " " + employeeDeets.EmployeeName;

                        payrollHrpayrollAttDetailObj.CompanyId = apiToken.CompanyId;
                        payrollHrpayrollAttDetailObj.DivisionId = apiToken.DivisionId;
                        payrollHrpayrollAttDetailObj.DepartmentId = apiToken.DepartmentId;
                        payrollHrpayrollAttDetailObj.AttendanceDate = attendanceDetailObj.AttendanceDate;
                        payrollHrpayrollAttDetailObj.EmployeeId = employeeID == null || employeeID == "" ? attendanceDetailObj.EmployeeId : employeeID;
                        payrollHrpayrollAttDetailObj.EmployeeName = employeeName == null || employeeName == "" ? attendanceDetailObj.EmployeeName : employeeName;
                        payrollHrpayrollAttDetailObj.ExpectedTimeIn = attendanceDetailObj.ExpectedTimeIn;
                        payrollHrpayrollAttDetailObj.TimeIn = attendanceDetailObj.TimeIn;
                        payrollHrpayrollAttDetailObj.ShiftType = attendanceDetailObj.ShiftType;
                        payrollHrpayrollAttDetailObj.Absent = attendanceDetailObj.Absent;
                        payrollHrpayrollAttDetailObj.Remarks = attendanceDetailObj.Remarks;
                        payrollHrpayrollAttDetailObj.LatePeriod = attendanceDetailObj.LatePeriod;
                        payrollHrpayrollAttDetailObj.Period = attendanceDetailObj.Period;
                        payrollHrpayrollAttDetailObj.BranchCode = attendanceDetailObj.BranchCode;

                       
                        _DBContext.Entry(payrollHrpayrollAttDetailObj).State = EntityState.Added;

                    }

                    status = true; //gets result
                }

            }
            catch(Exception ex)
            {
                return status = false;
            }

            return await Task.FromResult(status);
        }

        public async Task<PayrollEmployees> getEmployeeID(Apitoken apiToken, AttendanceDetail attendanceDetail)
        {
            PayrollEmployees employeeDeets = new PayrollEmployees();
            try
            {
                PayrollEmployees empl = await _DBContext.PayrollEmployees.Where(x => x.CompanyId == apiToken.CompanyId &&
                                                     x.DivisionId == apiToken.DivisionId &&
                                                     x.DepartmentId == apiToken.DepartmentId &&
                                                     x.EmployeeBiometricID == attendanceDetail.EmployeeId).AsNoTracking().
                                                     FirstOrDefaultAsync();

                employeeDeets = empl;
            }
            catch (Exception ex)
            {
            }

            return employeeDeets; 
        }

        public bool apiResult()
        {
            bool apiStatus = false;
            return apiStatus;
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
        
    }
}
