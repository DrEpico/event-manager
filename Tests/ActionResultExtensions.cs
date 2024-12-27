using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    public static class ActionResultExtensions
    {
        /// <summary>
        /// This custom extention method checks if the result is a success status code. Simulating EnsureSuccessCode() 
        /// method like behaviour as ASP.NET Core or the testing framework has no built in method for directly validating 
        /// success status codes in IActionResult.
        /// </summary>
        /// <param name="result">The returned object from an API</param>
        /// <exception cref="Xunit.Sdk.XunitException"></exception>
        public static void EnsureSuccessStatusCode(this IActionResult result)
        {
            if (result is ObjectResult objectResult)
            {
                if (objectResult.StatusCode is < 200 or >= 300)
                {
                    throw new Xunit.Sdk.XunitException($"Expected a 2xx status code but got {objectResult.StatusCode}.");
                }
            }
            else if (result is not NoContentResult && result is not OkResult && result is not CreatedAtActionResult)
            {
                throw new Xunit.Sdk.XunitException("Result is not a recognized success type.");
            }
        }
    }

}
