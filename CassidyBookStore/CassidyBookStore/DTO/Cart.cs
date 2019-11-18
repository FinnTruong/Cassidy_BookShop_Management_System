using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CassidyBookStore.DTO
{
    public class Cart
    {
        public Cart(string bookTitle, int quantity, int price, int total = 0)
        {
            this.BookTitle = bookTitle;
            this.Quantity = quantity;
            this.Price = price;
            this.Total = total;
        }

        public Cart(DataRow row)
        {
            this.BookTitle = row["bookTitle"].ToString();
            this.Quantity = (int)row["quantity"];
            this.Price = (int)row["price"];
            this.Total = (int)row["total"];
        }

        private string bookTitle;

        private int quantity;

        private int price;

        private int total;

        public string BookTitle { get => bookTitle; set => bookTitle = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public int Price { get => price; set => price = value; }
        public int Total { get => total; set => total = value; }
    }
}
