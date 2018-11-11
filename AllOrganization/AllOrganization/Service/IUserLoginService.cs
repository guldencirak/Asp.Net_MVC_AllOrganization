using System;
using AllOrganization.Models;

namespace AllOrganization.Service
{
    public interface IUserLoginService
    {
        User Login(UserLogin userLogin);
    }
}
