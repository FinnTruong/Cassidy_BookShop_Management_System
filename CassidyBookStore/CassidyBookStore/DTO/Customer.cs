using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CassidyBookStore.DTO
{
    public class Customer
    {
        public Customer(int id, string fullname, string phone, string email, string address, string city, string country)
        {
            this.Id = id;
            this.FullName = fullname;
            this.Phone = phone;
            this.Email = email;
            this.Address = address;
            this.City = city;
        }

        public Customer(DataRow row)
        {
            this.Id = (int)row["id"];
            this.FullName = row["fullname"].ToString();
            this.Phone = row["phone"].ToString();
            this.Email = row["email"].ToString();
            this.Address = row["address"].ToString();
            this.City = row["city"].ToString();
        }
        private int id;
        private string fullName;
        private string phone;
        private string email;
        private string address;
        private string city;

        public int Id { get => id; set => id = value; }
        public string FullName { get => fullName; set => fullName = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Email { get => email; set => email = value; }
        public string Address { get => address; set => address = value; }
        public string City { get => city; set => city = value; }
    }
}
