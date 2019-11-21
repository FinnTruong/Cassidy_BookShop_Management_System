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
        public Order(int id, int bookID, int customersID, DateTime? date, float discount, float total)
        {
            this.Id = id;
            this.CustomersID = customersID;
            this.Date = date;
            this.Discount = discount;
            this.Total = total;
        }

        public Order(DataRow row)
        {
            this.Id = (int)row["id"];
            this.CustomersID = (int)row["customersID"];
            this.Date = (DateTime?)row["date"];
            this.Discount = float.Parse(row["discount"].ToString());
            this.Total = float.Parse(row["total"].ToString());
        }


        public int Id { get => id; set => id = value; }
        public int CustomersID { get => customersID; set => customersID = value; }
        public DateTime? Date { get => date; set => date = value; }
        public float Total { get => total; set => total = value; }
        public float Discount { get => discount; set => discount = value; }

        private int id;

        private int customersID;

        private DateTime? date;

        private float total;

        private float discount;

    }
}
