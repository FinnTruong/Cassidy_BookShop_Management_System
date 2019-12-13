using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CassidyBookStore.DTO
{
    public class User
    {
        public User(int id, string firstName, string lastName, string phone, string email)
        {
            this.Id = id;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Phone = phone;
            this.Email = email;
        }

        public User(DataRow row)
        {
            this.Id = (int)row["id"];
            this.FirstName = row["firstName"].ToString();
            this.LastName = row["lastName"].ToString();
            this.Phone = row["phone"].ToString();
            this.Email = row["email"].ToString();
        }


        private int id;
        private string firstName;
        private string lastName;
        private string phone;
        private string email;

        public int Id { get => id; set => id = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Email { get => email; set => email = value; }
    }
}
