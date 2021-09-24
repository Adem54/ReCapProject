using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Security.Encryption
{
  public  class SecurityKeyHelper
    {
        public static SecurityKey CreateSecurityKey(string securityKey)
        {
            byte[] encodedBytes = Encoding.UTF8.GetBytes(securityKey);
            return new SymmetricSecurityKey(encodedBytes);
        }
    }
}
