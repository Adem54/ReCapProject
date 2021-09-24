using Core.Entities.Concrete;
using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
 public  interface IUserService
    {
         void Add(User user);
         void Delete(User user);
        void  Update(User user);
         List<User> GetAll();
        User GetById(int userId);
        List<OperationClaim> GetClaims(User user);
        User GetByEmail(string email);


    }
}
