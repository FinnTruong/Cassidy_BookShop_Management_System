using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CassidyBookStore.DAO
{
    public class Book
    {
        public Book(int id, string bookTitle, string author, int stock, float cost, float price)
        {
            this.Id = id;
            this.BookTitle = bookTitle;
            this.Author = author;
            this.Stock = stock;
            this.Cost = cost;
            this.Price = price;
        }

        public Book(DataRow row)
        {
            this.Id = (int)row["id"];
            this.BookTitle = row["bookTitle"].ToString();
            this.Author = row["author"].ToString();
            this.Stock = (int)row["stock"];
            this.Cost = float.Parse(row["cost"].ToString());
            this.Price = float.Parse(row["price"].ToString());
        }

        private int id;

        private string bookTitle;

        private string author;

        private int stock;

        private float cost;

        private float price;

        public int Id { get => id; set => id = value; }
        public string BookTitle { get => bookTitle; set => bookTitle = value; }
        public string Author { get => author; set => author = value; }
        public int Stock { get => stock; set => stock = value; }
        public float Cost { get => cost; set => cost = value; }
        public float Price { get => price; set => price = value; }
    }
}
