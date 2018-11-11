using System;
namespace AllOrganization.Models
{
    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string EMail { get; set; }
        public DateTime ExpiredDate { get; set; }

        public User(string Username,string Password,string EMail)
        {
            this.Username = Username;
            this.Password = Password;
            this.EMail = EMail;
            //this.ExpiredDate = ExpiredDate;
        }
    }
}
