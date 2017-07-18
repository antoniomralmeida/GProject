using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Security.Principal;

namespace ProgramName.Models.Extensions
{
    public static class IdentityExtensions
    {
        public static string GetUserProfile2(this IIdentity identity)
        {
            var claim = ((ClaimsIdentity)identity).FindFirst("Profile");
            // Test for null to avoid issues during local testing
            return (claim != null) ? claim.Value : string.Empty;
        }
    }
}