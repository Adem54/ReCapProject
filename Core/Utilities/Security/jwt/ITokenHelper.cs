using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Security.jwt
{
   public interface ITokenHelper
    {
        AccessToken CreateToken(User user, List<OperationClaim> operationClaims);
    }
}
//AccessToken uretecek operasyon olunca tabi ki tipi AccessToken tipinde olacak
//Peki bize neler lazm bize User bilgisi ve OperationClaim bilgisi lazm..