using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CassidyBookStore.DTO
{
    public class Order
    {
        public Order(int id, int bookID, int customersID, DateTime? date, int discount, int total)
        {
            this.Id = id;
            this.BookID = bookID;
            this.CustomersID = customersID;
            this.Date = date;
            this.Discount = discount;
            this.Total = total;
        }

        public Order(DataRow row)
        {
            this.Id = (int)row["id"];
            this.BookID = (int)row["bookID"];
            this.CustomersID = (int)row["customersID"];
            this.Date = (DateTime?)row["date"];
            this.Discount = (int)row["discount"];
            this.Total = (int)row["total"];
        }


        public int Id { get => id; set => id = value; }
        public int BookID { get => bookID; set => bookID = value; }
        public int CustomersID { get => customersID; set => customersID = value; }
        public DateTime? Date { get => date; set => date = value; }
        public int Total { get => total; set => total = value; }
        public int Discount { get => discount; set => discount = value; }

        private int id;

        private int bookID;

        private int customersID;

        private DateTime? date;

        private int total;

        private int discount;
    }
}
