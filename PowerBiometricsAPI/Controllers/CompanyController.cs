using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PowerBiometricsAPI.Data.Models;
using PowerBiometricsAPI.Data.Validators;
using Newtonsoft.Json.Linq;
using PowerBiometricsAPI.DomainModels;
using System.Net;

namespace PowerBiometricsAPI.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class CompanyController : ControllerBase
    {
        private EnterpriseBaseContext _DBContext;
        Extras utilities = new Extras();
        // GET api/values

        public CompanyController(EnterpriseBaseContext enterpriseBaseContext)
        {
            _DBContext = enterpriseBaseContext;
        }
        [HttpGet]
        public ContentResult Get()
        {
            string cont;
            string message = "CONNECTION ISSUES";
            try
            {
                PayrollEmployees user = _DBContext.PayrollEmployees.Where(x => x.EmployeeId == "Admin").FirstOrDefault();
                if (user != null)
                {
                    message = "CONNECTION OK";
                }
                //return message;
            }
            catch (Exception ex)
            {
                message = ex.Message;
            }
            cont = message == "CONNECTION OK" ? "<html><body><span style='color:green'>" + message + "</span></body></html>" : "<html><body><span style='color:red'>" + message + "</span></body></html>";
            return new ContentResult
            {
                ContentType = "text/html",
                StatusCode = (int)HttpStatusCode.OK,
                Content = cont
            };

        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public string Post([FromBody]Employees employees)
        {
            string message = "no";
            if (employees != null)
            {
                Apitoken apitoken = new Apitoken();
                string password = validatePassword(employees.EmployeePassword);
                try
                {
                    apitoken = _DBContext.ApiToken.Where(a => a.Token == employees.apiToken).FirstOrDefault();
                    if (apitoken != null)
                    {
                        PayrollEmployees empDetails = _DBContext.PayrollEmployees
                                                        .Where(x => x.CompanyId == apitoken.CompanyId &&
                                                        x.DivisionId == apitoken.DivisionId &&
                                                        x.DepartmentId == apitoken.DepartmentId &&
                                                        x.EmployeeId == employees.EmployeeId &&
                                                        x.EmployeePassword == password &&
                                                        x.EmployeeTypeId == "User").FirstOrDefault();

                        if (empDetails != null)
                        {
                            return message = "yes";
                        }
                        else
                        {
                            return message = "Incorrect Login Credentials";
                        }
                    }
                    else
                    {
                        return message = "Invalid Token";
                    }
                }
                catch (Exception ex)
                {
                    message = ex.Message;
                }
            };

            return message;           
        }

        public string validatePassword(string password)
        {
            string cnvtdPwrd = "";

            cnvtdPwrd = utilities.doConvertPwd(password);

            return cnvtdPwrd;
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
