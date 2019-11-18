using CassidyBookStore.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CassidyBookStore.DAO
{
    public class CartDAO
    {
        private static CartDAO instance;

        public static CartDAO Instance
        {
            get { if (instance == null) instance = new CartDAO(); return CartDAO.instance; }
            private set => instance = value;
        }

        private CartDAO() { }

        public List<Cart> GetListCartByTable()
        {
            List<Cart> listCart = new List<Cart>();

            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT BOOKS.BOOKTITLE, ORDERS.QUANTITY, PRICE, TOTAL FROM BOOKS JOIN ORDERS ON BOOKS.ID = BOOKID");

            foreach (DataRow item in data.Rows)
            {
                Cart cart = new Cart(item);
                listCart.Add(cart);
            }

            return listCart;
        }
    }
}
