using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoopark.Model
{
    public class User
    {
        
        private int _id;
        private string _username;
        private string _password;

        [Key]
        public int Id { get => _id; set => _id = value; }
        public string Username { get => _username; set => _username = value; }
        public string Password { get => _password; set => _password = value; }

        public User()
        {
        }

        public User(string username)
        {
            Username = username;
        }
    }
}
