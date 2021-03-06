using Business.Abstract;
using Business.Constants;
using Core.Entities.Concrete;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class UserManager : IUserService
    {
        IUserDal _userDal;
        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }
        public void Add(User user)
        {
            _userDal.Add(user);
            
        }

        public void Delete(User user)
        {
            _userDal.Delete(user);
        }

        public  List<User> GetAll()
        {
            return _userDal.GetAll();
        }

        public User GetByEmail(string email)
        {
            return _userDal.Get(u => u.Email == email);
        }

        public User GetById(int userId)
        {
            return _userDal.Get(u => u.Id == userId);
        }

        public List<OperationClaim> GetClaims(User user)
        {
            return _userDal.GetClaims(user);
        }

        public void Update(User user)
        {
            _userDal.Update(user);
        }
    }
}
