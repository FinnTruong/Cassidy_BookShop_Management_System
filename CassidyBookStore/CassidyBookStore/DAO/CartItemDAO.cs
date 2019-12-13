using CassidyBookStore.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CassidyBookStore.DAO
{
    public class CartItemDAO
    {
        private static CartItemDAO instance;

        public static CartItemDAO Instance
        {
            get { if (instance == null) instance = new CartItemDAO(); return CartItemDAO.instance; }
            private set => instance = value;
        }

        private CartItemDAO() { }

        public List<CartItem> GetListCartByOrder(int id)
        {
            List<CartItem> listCart = new List<CartItem>();

            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT BOOKTITLE, QUANTITY, B.PRICE, TOTAL FROM BOOKS B JOIN CART C ON B.ID = C.BOOKID WHERE ORDERID = " + id);

            foreach (DataRow item in data.Rows)
            {
                CartItem cart = new CartItem(item);
                listCart.Add(cart);
            }

            return listCart;
        }

        public void AddToCart(int orderID, int bookID, int quantity, float price)
        {
            DataProvider.Instance.ExecuteNonQuery("USP_AddToCart @orderID , @bookID , @quantity , @price", new object[] { orderID, bookID, quantity, price });
        }
        
        public void DeleteCartItemByBookID(int id)
        {
            DataProvider.Instance.ExecuteQuery("DELETE FROM CART WHERE BOOKID = " + id);
        }

        //Clear Cart When Press Clear All Button
        public void ClearAllCartItem(int id)
        {
            DataProvider.Instance.ExecuteQuery("DELETE FROM CART WHERE ORDERID = " + id);
        }

        public float GetCartTotalByOrder(int id)
        {
            try
            {
                object result = DataProvider.Instance.ExecuteScalar("SELECT SUM(TOTAL) FROM CART WHERE ORDERID = " + id);
                return float.Parse(result.ToString());
            }  
            catch
            {
                return 0;
            }
                                  
        }

        public bool IsCartEmpty(int orderID)
        {
            string query = "SELECT * FROM CART WHERE ORDERID = " + orderID;
            DataTable result = DataProvider.Instance.ExecuteQuery(query);
            return result.Rows.Count == 0;            
        }
    }
}
