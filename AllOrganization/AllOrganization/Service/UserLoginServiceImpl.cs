using System;
using AllOrganization.Models;
using AllOrganization.DAO;

namespace AllOrganization.Service
{
    public class UserLoginServiceImpl : IUserLoginService
    {
        private IUserLoginDAO userLoginDAO;

        public User Login(UserLogin userLogin)
        {
            userLoginDAO = new UserLoginDAOImpl();

            return userLoginDAO.Login(userLogin);
        }
    }
}
