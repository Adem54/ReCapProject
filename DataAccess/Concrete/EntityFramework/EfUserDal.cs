using Core.DataAccess.EntityFramework;
using Core.Entities.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfUserDal : EfEntityRepostoryBase<User, ReCapContext>, IUserDal
    {
        public List<OperationClaim> GetClaims(User user)
        {
            using (ReCapContext context=new ReCapContext())
            {
                var result = from oC in context.OperationClaims
                             join uOC in context.UserOperationClaims
                             on oC.Id equals uOC.OperationClaimId
                             where uOC.UserId == user.Id
                             select new OperationClaim
                             {
                                 Id = oC.Id,
                                 Name = oC.Name
                             };
                return result.ToList();
            }              
        }
    }
}
