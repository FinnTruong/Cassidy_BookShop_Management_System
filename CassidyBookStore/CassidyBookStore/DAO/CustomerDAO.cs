using CassidyBookStore.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CassidyBookStore.DAO
{
    public class CustomerDAO
    {
        private static CustomerDAO instance;
        public static CustomerDAO Instance
        {
            get { if (instance == null) instance = new CustomerDAO(); return CustomerDAO.instance; }
            private set => instance = value;
        }
        private CustomerDAO() { }

        public void AddNewCustomer(string fullname, string phone, string email, string address, string city)
        {
            string query = string.Format("INSERT INTO CUSTOMERS(FULLNAME,PHONE,EMAIL,ADDRESS,CITY) VALUES (N'{0}', '{1}', '{2}', '{3}', '{4}')", fullname, phone, email, address, city);
            DataProvider.Instance.ExecuteQuery(query);
            
        }

        public List<Customer> SearchCustomer(string searchString)
        {
            List<Customer> list = new List<Customer>();

            string query = string.Format("SELECT * FROM CUSTOMERS WHERE ID LIKE '%{0}%' OR FULLNAME LIKE '%{0}%' OR PHONE LIKE '%{0}%' OR EMAIL LIKE '%{0}%' OR ADDRESS LIKE '%{0}%' OR CITY LIKE '%{0}%'", searchString);

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Customer customer = new Customer(item);
                list.Add(customer);
            }
            return list;
        }

        public bool IsExistedEmail(string email)
        {
            string query = string.Format("SELECT * FROM CUSTOMERS WHERE EMAIL = '{0}'", email);
            DataTable result = DataProvider.Instance.ExecuteQuery(query);
            return result.Rows.Count > 0;
        }

        public int GetMaxIDCustomer()
        {
            try
            {
                return (int)DataProvider.Instance.ExecuteScalar("SELECT MAX(ID) FROM CUSTOMERS");
            }
            //Khong ton tai ID Order nao
            catch
            {
                return 0;
            }
        }

        public int GetCustomerCount()
        {
            string query = "SELECT COUNT(*) FROM CUSTOMERS";
            object result = DataProvider.Instance.ExecuteScalar(query);
            return (int)result;
        }
    }
}
