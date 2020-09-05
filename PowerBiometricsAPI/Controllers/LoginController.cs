using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PowerBiometricsAPI.Data.Models;
using PowerBiometricsAPI.Data.Validators;
using PowerBiometricsAPI.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PowerBiometricsAPI.Controllers
{
    public class LoginController: Controller
    {
        private readonly EnterpriseBaseContext dbContext;
        Extras utilities = new Extras();
        public LoginController(EnterpriseBaseContext enterpriseBaseContext) => 
            this.dbContext = enterpriseBaseContext;

        [HttpPost]
        [Route("api/Login")]
        public async Task<IActionResult> Login([FromBody] Employees employees)
        {
            string message;
            if (employees is null)
                return BadRequest("Invalid data passed");

            Apitoken apitoken = new Apitoken();
            string password = validatePassword(employees.EmployeePassword);
            try
            {
                apitoken = await dbContext.ApiToken.SingleOrDefaultAsync(a => a.Token == employees.apiToken);
                if (apitoken == null) return NotFound("Invalid Token");

                PayrollEmployees empDetails = await dbContext.PayrollEmployees
                                .FirstOrDefaultAsync(x => x.CompanyId == apitoken.CompanyId
                                && x.DivisionId == apitoken.DivisionId
                                && x.DepartmentId == apitoken.DepartmentId
                                && x.EmployeeId == employees.EmployeeId
                                && x.EmployeePassword == password
                                && x.EmployeeTypeId.ToLower() == "user");

                if (empDetails == null)
                    message = "no";
                message = "yes";
            }
            catch (Exception)
            {
                throw;
            }
            return Ok(message);
        }

        private string validatePassword(string password)
        {
            var cnvtdPwrd = utilities.doConvertPwd(password);

            return cnvtdPwrd;
        }
    }
}
