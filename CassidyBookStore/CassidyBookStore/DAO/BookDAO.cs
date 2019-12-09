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

        public List<string> LoadBookTitle()
        {
            List<string> listBookTitle = new List<string>();

            string query = "SELECT BOOKTITLE FROM BOOKS";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                string bookTitle = item["BOOKTITLE"].ToString();
                listBookTitle.Add(bookTitle);
            }
            return listBookTitle;
        }

        public bool IsAcceptedBookTitle(string bookTitle)
        {
            string query = string.Format("SELECT * FROM BOOKS WHERE BOOKTITLE = '{0}'", bookTitle);
            DataTable result = DataProvider.Instance.ExecuteQuery(query);
            return result.Rows.Count > 0;
        }

        public string GetIdFromBookTitle(string bookTitle)
        {
            string query = string.Format("SELECT ID FROM BOOKS WHERE BOOKTITLE = '{0}'",bookTitle);
            object result = DataProvider.Instance.ExecuteScalar(query);
            return result.ToString();
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
            string query = "SELECT STOCK FROM BOOKS WHERE ID = " + id;

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

        public void UpdateStorage(int bookID, int remain)
        {
            string query = "USP_UpdateStorage @bookID , @bookSold";
            DataProvider.Instance.ExecuteQuery(query, new object[] { bookID, remain });
        }

        public List<Book> SearchBookByName(string name)
        {
            List<Book> listBook = new List<Book>();

            string query = string.Format("SELECT * FROM BOOKS WHERE BOOKTITLE LIKE '%{0}%'", name);

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Book book = new Book(item);
                listBook.Add(book);
            }
            return listBook;
        }

        public bool InsertBook(string bookTitle, string author, int stock, float cost, float price)
        {
            string query = string.Format("INSERT INTO BOOKS(BOOKTITLE, AUTHOR, STOCK, COST, PRICE) VALUES ('{0}', '{1}', {2}, {3}, {4})",bookTitle, author, stock ,cost, price);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool UpdateBook(int bookID, string bookTitle, string author, int stock, float cost, float price)
        {
            if (bookTitle != "" && author != "")
            {
                string query = string.Format("UPDATE BOOKS SET BOOKTITLE = '{0}', AUTHOR = '{1}', STOCK = {2}, COST = {3}, PRICE = {4} WHERE ID= {5}", bookTitle, author, stock, cost, price, bookID);
                int result = DataProvider.Instance.ExecuteNonQuery(query);
                return result > 0;
            }

            return false;
        }

        public bool DeleteBook(int bookID)
        {
            CartItemDAO.Instance.DeleteCartItemByBookID(bookID);
            string query = "DELETE FROM BOOKS WHERE ID = " + bookID;
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public int GetBookCount()
        {
            string query = "SELECT COUNT(*) FROM BOOKS";
            object result = DataProvider.Instance.ExecuteScalar(query);
            return (int)result;
        }

    }
}
