using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CassidyBookStore.DTO
{
    public class Expense
    {
        public Expense(int id, string title, float amount, string date, string description)
        {
            this.Id = id;
            this.Title = title;
            this.Amount = amount;
            this.Date = date;
            this.Description = description;
        }

        public Expense(DataRow row)
        {
            this.Id = (int)row["id"];
            this.Title = row["title"].ToString();
            this.Amount = float.Parse(row["amount"].ToString());
            this.Date = row["date"].ToString();
            this.Description = row["description"].ToString();
        }

        private int id;
        private string title;
        private float amount;
        private string date;
        private string description;

        public int Id { get => id; set => id = value; }
        public string Title { get => title; set => title = value; }
        public float Amount { get => amount; set => amount = value; }
        public string Date { get => date; set => date = value; }
        public string Description { get => description; set => description = value; }
    }
}
