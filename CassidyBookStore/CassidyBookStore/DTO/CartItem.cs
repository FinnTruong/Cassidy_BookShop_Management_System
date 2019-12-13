using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CassidyBookStore.DTO
{
    public class CartItem
    {
        public CartItem(string bookTitle, int quantity, int price)
        {
            this.BookTitle = bookTitle;
            this.Quantity = quantity;
            this.Price = price;
            this.Total = quantity * price;
        }

        public CartItem(DataRow row)
        {
            this.BookTitle = row["bookTitle"].ToString();
            this.Quantity = (int)row["quantity"];
            this.Price = float.Parse(row["price"].ToString());
            this.Total = float.Parse(row["total"].ToString());
        }

        private string bookTitle;

        private int quantity;

        private float price;

        private float total;

        public string BookTitle { get => bookTitle; set => bookTitle = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public float Price { get => price; set => price = value; }
        public float Total { get => total; set => total = value; }
    }
}
