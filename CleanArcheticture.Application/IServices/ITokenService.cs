using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace CleanArcheticture.Application
    {
    public interface ITokenService
        {
        string CreateToken(string userId, string userName, IEnumerable<string> roles, IEnumerable<Claim>? extraClaims = null);
        }
    }
