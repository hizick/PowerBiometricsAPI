using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PowerBiometricsAPI.DomainModels
{
    public class Employees
    {
        public string EmployeeId { get; set; }
        public string apiToken { get; set; } //was meant to be passed in the url but it would affect the api contract for some apps.
        public string EmployeePassword { get; set; }
    }
}
