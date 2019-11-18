using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CassidyBookStore.DAO
{
    public class AccountDAO
    {
        private static AccountDAO instance;

        public static AccountDAO Instance
        { 
            get {if (instance == null) instance = new AccountDAO(); return instance; }
            private set => instance = value;
        }

        private AccountDAO()
        {

        }

        public bool Login(string username, string password)
        {
            string query = "USP_Login @username , @password";

            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { username, password });


            return result.Rows.Count > 0;
        }

        public string ReturnUsersFirstName(string username, string password)
        {
            string query = "SELECT FIRSTNAME FROM ACCOUNT JOIN USERS ON USERSID = ID WHERE USERNAME = N'" + username + "' AND PASSWORD = N'" + password + "' ";

            object result = DataProvider.Instance.ExecuteScalar(query);

            return result.ToString();


        }
    }
}
