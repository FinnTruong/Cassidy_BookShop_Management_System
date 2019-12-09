using CassidyBookStore.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CassidyBookStore.DAO
{
    public class OrderDAO
    {
        private static OrderDAO instance;

        public static OrderDAO Instance
        {
            get { if (instance == null) instance = new OrderDAO(); return OrderDAO.instance; }
            private set => instance = value;
        }

        private OrderDAO() { }

        public List<Order> GetListOrder()
        {
            List<Order> listOrder = new List<Order>();

            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM ORDERS");

            foreach (DataRow item in data.Rows)
            {
                Order order = new Order(item);
                listOrder.Add(order);
            }

            return listOrder;
        }

        public void AddNewOrder()
        {
            DataProvider.Instance.ExecuteQuery("EXEC USP_AddNewOrder");
        }
        public bool UpdateOrder(int customersID, float discount, float total, int orderID)
        {
            string query = string.Format("UPDATE ORDERS SET DATE = GETDATE(), CUSTOMERSID = {0}, DISCOUNT = {1}, TOTAL = {2} WHERE ID = {3}", customersID, discount, total, orderID);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public int GetMaxIDOrder()
        {
            try
            {
                return (int)DataProvider.Instance.ExecuteScalar("SELECT MAX(ID) FROM ORDERS");
            }
            //Khong ton tai ID Order nao
            catch
            {
                return 0;
            }
        }

        public int GetTotal(int id)
        {
            try
            {
                return (int)DataProvider.Instance.ExecuteScalar("SELECT TOTAL FROM ORDER WHERE ID = " + id);
            }
            catch
            {
                return 0;
            }
        }

        public int GetOrderCount()
        {
            string query = "SELECT COUNT(*) FROM ORDERS";
            object result = DataProvider.Instance.ExecuteScalar(query);
            return (int)result;
        }

        public List<Order> SearchOrder(string searchString)
        {
            List<Order> listOrder = new List<Order>();

            string query = string.Format("SELECT O.ID,FULLNAME,CONVERT(DATE,GETDATE()) AS DATE,TOTAL, O.STATUS FROM ORDERS O JOIN CUSTOMERS C ON O.CUSTOMERSID = C.ID WHERE FULLNAME LIKE '%{0}%'", searchString);

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Order order = new Order(item);
                listOrder.Add(order);
            }
            return listOrder;
        }

        public void FinalizedOrder(int orderID)
        {
            string query = "UPDATE ORDERS SET STATUS = 1 WHERE ID = " + orderID;
            DataProvider.Instance.ExecuteQuery(query);
        }

        public void AbortedOrder(int orderID)
        {
            string query = "UPDATE ORDERS SET STATUS = 2 WHERE ID = " + orderID;
            DataProvider.Instance.ExecuteQuery(query);
        }
    }
}
