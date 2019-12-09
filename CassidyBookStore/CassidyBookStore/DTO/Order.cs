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
        public Order(int id,  string customer, DateTime? date, float total, int status)
        {
            this.Id = id;
            this.Customer = customer;
            this.Date = date;
            this.Total = total;
            this.Status = status;
        }

        public Order(DataRow row)
        {
            this.Id = (int)row["id"];
            this.Customer = row["fullname"].ToString();
            this.Date = (DateTime?)row["date"];  
            this.Total = float.Parse(row["total"].ToString());
            this.Status = (int)row["status"];
        }


        public int Id { get => id; set => id = value; }

        public string Customer { get => customer; set => customer = value; }
        public DateTime? Date { get => date; set => date = value; }
        public float Total { get => total; set => total = value; }

        public int Status { get => status; set => status = value; }

        private int id;

        private string customer;

        private DateTime? date;

        private float total;

        private int status;

    }
}
