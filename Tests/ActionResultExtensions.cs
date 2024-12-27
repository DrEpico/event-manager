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
