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
           

    }
}
