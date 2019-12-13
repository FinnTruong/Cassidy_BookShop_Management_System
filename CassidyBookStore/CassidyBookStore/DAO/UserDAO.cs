using CassidyBookStore.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CassidyBookStore.DAO
{
    public class UserDAO
    {
        private static UserDAO instance;

        public static UserDAO Instance
        {
            get { if (instance == null) instance = new UserDAO(); return UserDAO.instance; }
            private set => instance = value;
        }

        private UserDAO() { }

        public int GetMaxIDUser()
        {
            try
            {
                return (int)DataProvider.Instance.ExecuteScalar("SELECT MAX(ID) FROM USERS");
            }
            //Khong ton tai ID Order nao
            catch
            {
                return 0;
            }
        }

        public void InsertUser(string firstName, string lastName, string phone, string email)
        {
            string query = string.Format("INSERT INTO USERS(FIRSTNAME,LASTNAME,PHONE,EMAIL) VALUES('{0}','{1}','{2}','{3}')", firstName, lastName, phone, email);
            DataProvider.Instance.ExecuteQuery(query);            
        }

        public void UpdateUser(string firstName, string lastName, string phone, string email, int id)
        {
            string query = string.Format("UPDATE USERS SET FIRSTNAME = '{0}', LASTNAME = '{1}', PHONE = '{2}', EMAIL = '{3}' WHERE ID = {4}", firstName, lastName, phone, email, id);
            DataProvider.Instance.ExecuteQuery(query);
        }

        public void DeleteUser(int id)
        {
            string query = "DELETE FROM USERS WHERE ID = " + id;
            DataProvider.Instance.ExecuteQuery(query);
        }

        public List<User> SearchUserByName(string name)
        {
            List<User> list = new List<User>();

            string query = string.Format("SELECT * FROM USERS WHERE CONCAT(FIRSTNAME,' ',LASTNAME) LIKE '%{0}%' ", name);

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                User user = new User(item);
                list.Add(user);
            }
            return list;
        }


    }
}
