using Microsoft.AspNetCore.Mvc;
using static ProjeVek.WebUI.Management.Authorize.ClaimRequirementFitler;

namespace ProjeVek.WebUI.Management.Authorize
{
    public class AuthorizeAttribute : TypeFilterAttribute
    {
        public AuthorizeAttribute() : base(typeof(ClaimRequirementFilter))
        {
            Arguments = new object[] { };
        }
    }
}


