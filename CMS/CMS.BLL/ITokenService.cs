using CMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace CMS.BLL
{
    public interface ITokenService
    {
        string GenerateAccessToken(User user, string role);
        string GenerateRefreshToken();
        ClaimsPrincipal GetPrincipalFromExpiredToken(string token);

        public ClaimsPrincipal ValidateToken(string token);
    }
}
