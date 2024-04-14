using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentSystem.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int Level { get; set; }

        public User(int id, string name, string username, string password, int level)
        {
            this.Id = id;
            this.Name = name;
            this.Username = username;
            this.Password = password;
            this.Level = level;
        }
    }
}
