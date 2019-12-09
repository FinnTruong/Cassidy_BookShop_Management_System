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

        public string ReturnUsernameFromUserID(int id)
        {
            string query = "SELECT USERNAME FROM ACCOUNT JOIN USERS ON USERSID = ID WHERE USERSID = " + id;
            object result = DataProvider.Instance.ExecuteScalar(query);
            return result.ToString();
        }

        public void InsertAccount(string username, string password, int userID)
        {
            string query = string.Format("INSERT INTO ACCOUNT VALUES('{0}','{1}',{2})",username,password, userID);
            DataProvider.Instance.ExecuteQuery(query);           
        }

        public void UpdateAccount(int id, string username, string password)
        {
            string query = string.Format("UPDATE ACCOUNT SET USERNAME = '{0}', PASSWORD = '{1}' WHERE USERSID = {2}", username, password, id);
            DataProvider.Instance.ExecuteQuery(query);
        }

        public void UpdateUsername(int id, string username)
        {
            string query = string.Format("UPDATE ACCOUNT SET USERNAME = '{0}' WHERE USERSID = {1}", username, id);
            DataProvider.Instance.ExecuteQuery(query);
        }

        public void DeleteAccount(int userID)
        {
            string query = "DELETE FROM ACCOUNT WHERE USERSID = " + userID;
            DataProvider.Instance.ExecuteQuery(query);
        }

        public bool IsValidAccountName(string name)
        {
            string query = string.Format("SELECT * FROM ACCOUNT WHERE USERNAME = '{0}'",name);
            object result = DataProvider.Instance.ExecuteScalar(query);
            return result == null;
        }

        public bool DoesCurrentPasswordValid(string password,int userId)
        {
            string query = "SELECT PASSWORD FROM ACCOUNT JOIN USERS ON USERSID = ID WHERE USERSID = " + userId;
            object result = DataProvider.Instance.ExecuteScalar(query);
            return result.ToString() == password;
        }
    }
}
