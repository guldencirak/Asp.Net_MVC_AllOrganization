using System;
using AllOrganization.Models;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data;

namespace AllOrganization.DAO
{
    public class UserLoginDAOImpl : IUserLoginDAO
    {
        private MySqlConnection _con = new
            MySqlConnection("Server=127.0.0.1; Port=3306; Database=OrganizationDB; Uid=spstudent; Pwd=spstudent;");
       
        public User Login(UserLogin userLogin)
        {
            User user = null;
            try
            {
                string cmdStr = "select * from User where Username=@uname and Password=@pwd";
                MySqlCommand cmd = new MySqlCommand(cmdStr, _con);
                cmd.Parameters.AddWithValue("@uname", userLogin.Username);
                cmd.Parameters.AddWithValue("@pwd", userLogin.Password);

                _con.Open();

                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    user = new User((string)dr[1],(string)dr[2],(string)dr[3]);
                }
            }
            catch (Exception exc) 
            { 
                
            }
            finally
            {
                if (_con.State == ConnectionState.Open)
                    _con.Close();
            }

            return user;
        }
    }
}
