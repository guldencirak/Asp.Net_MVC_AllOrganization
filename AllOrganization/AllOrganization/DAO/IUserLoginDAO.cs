using System;
using AllOrganization.Models;

namespace AllOrganization.DAO
{
    public interface IUserLoginDAO
    {
        User Login(UserLogin userLogin);
    }
}
