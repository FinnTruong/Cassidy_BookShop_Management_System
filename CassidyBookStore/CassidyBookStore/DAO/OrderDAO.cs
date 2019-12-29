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


        public List<Order> SearchOrder(string searchString)
        {
            List<Order> listOrder = new List<Order>();

            string query = string.Format("SELECT O.ID,FULLNAME,DATE,TOTAL, O.STATUS FROM ORDERS O JOIN CUSTOMERS C ON O.CUSTOMERSID = C.ID WHERE FULLNAME LIKE '%{0}%'", searchString);

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
            string query = "UPDATE ORDERS SET STATUS = 1 WHERE STATUS = 0 AND ID = " + orderID;
            DataProvider.Instance.ExecuteQuery(query);
        }

        public void AbortedOrder(int orderID)
        {
            string query = "UPDATE ORDERS SET STATUS = 2 WHERE STATUS = 0 AND ID = " + orderID;
            DataProvider.Instance.ExecuteQuery(query);
        }

        public float GetThisMonthIncome(string month)
        {
            float temp = 0;
            string query = string.Format("SELECT SUM(TOTAL) FROM ORDERS WHERE MONTH(DATE) = {0} AND YEAR(DATE) = YEAR(GETDATE()) AND STATUS <> 2",month);
            object result = DataProvider.Instance.ExecuteScalar(query);
            if (result != null && float.TryParse(result.ToString(), out temp))
                return temp;
            return 0;                
        }

        public float GetYearIncome(string year)
        {
            float temp = 0;
            string query = string.Format("SELECT SUM(TOTAL) FROM ORDERS WHERE YEAR(DATE) = {0} AND STATUS <>2 ", year);
            object result = DataProvider.Instance.ExecuteScalar(query);
            if (result != null && float.TryParse(result.ToString(), out temp))
                return temp;
            return 0;
        }

        public int GetThisMonthTotalOrders(string month)
        {
            string query = string.Format("SELECT COUNT(*) FROM ORDERS WHERE MONTH(DATE) = {0} AND YEAR(DATE) = YEAR(GETDATE()) AND STATUS = 1", month);
            object result = DataProvider.Instance.ExecuteScalar(query);
            if (result == null)
                return 0;
            else
                return int.Parse(result.ToString());            
        }

        public DataTable FilterByDate(DateTime from, DateTime to)
        {
            string fromDate = from.ToString("MM/dd/yyyy");
            string toDate = to.ToString("MM/dd/yyyy");
            string query = string.Format("SELECT ORDERS.ID, FULLNAME, DATE, TOTAL, STATUS FROM ORDERS JOIN CUSTOMERS ON CUSTOMERSID = CUSTOMERS.ID" +
                " WHERE DATE BETWEEN '{0}' AND '{1}'", fromDate, toDate);
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public int GetTotalOrder()
        {
            string query = "SELECT COUNT(*) FROM ORDERS";
            object result = DataProvider.Instance.ExecuteScalar(query);
            int total = int.Parse(result.ToString());
            if (total <= 0)
                return 0;
            return total - 1;
        }

        public int GetTotalOrderInPeriod(DateTime from, DateTime to)
        {
            string fromDate = from.ToString("MM/dd/yyyy");
            string toDate = to.ToString("MM/dd/yyyy");
            string query = string.Format("SELECT COUNT(*) FROM ORDERS WHERE DATE BETWEEN '{0}' AND '{1}'", fromDate, toDate);
            object result = DataProvider.Instance.ExecuteScalar(query);
            if (result == null)
                return 0;
            return int.Parse(result.ToString());
        }
    }
}
