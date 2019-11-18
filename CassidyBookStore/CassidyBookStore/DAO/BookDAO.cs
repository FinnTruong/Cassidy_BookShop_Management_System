using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CassidyBookStore.DAO
{
    public class BookDAO
    {
        private static BookDAO instance;

        public static BookDAO Instance
        {
            get { if (instance == null) instance = new BookDAO(); return BookDAO.instance; }
            private set { BookDAO.instance = value; }
        }

        private BookDAO() { }

        public bool IsAcceptedID(int id)
        {
            string query = "SELECT * FROM BOOKS WHERE ID = " + id;

            DataTable result = DataProvider.Instance.ExecuteQuery(query);

            return result.Rows.Count > 0;
        }

        public string GetBookTitle(int id)
        {
            string query = "SELECT BOOKTITLE FROM BOOKS WHERE ID = " + id;

            object result = DataProvider.Instance.ExecuteScalar(query);

            return result.ToString();
        }

        public string GetAuthor(int id)
        {
            string query = "SELECT AUTHOR FROM BOOKS WHERE ID = " + id;

            object result = DataProvider.Instance.ExecuteScalar(query);

            return result.ToString();
        }

        public string GetStock(int id)
        {
            string query = "SELECT QUANTITY FROM BOOKS WHERE ID = " + id;

            object result = DataProvider.Instance.ExecuteScalar(query);

            return result.ToString();
        }

        public string GetCost(int id)
        {
            string query = "SELECT COST FROM BOOKS WHERE ID = " + id;

            object result = DataProvider.Instance.ExecuteScalar(query);

            return result.ToString();
        }

        public string GetPrice(int id)
        {
            string query = "SELECT PRICE FROM BOOKS WHERE ID = " + id;

            object result = DataProvider.Instance.ExecuteScalar(query);

            return result.ToString();
        }

    }
}
