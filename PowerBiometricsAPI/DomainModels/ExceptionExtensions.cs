using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PowerBiometricsAPI.DomainModels
{
    public static class ExceptionExtensions
    {
        public static string GetFullMessage(this Exception ex)
        {
            string error = ex.InnerException == null ? ex.Message : ex.Message + " --> " + ex.InnerException.GetFullMessage();
            return error;
        }
    }
}
