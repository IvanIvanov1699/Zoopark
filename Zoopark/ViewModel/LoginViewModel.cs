using Microsoft.Toolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoopark.Commands;
using Zoopark.DbContexts;
using Zoopark.Model;

namespace Zoopark.ViewModel
{ 
    
    public class LoginViewModel : ViewModelBase
    {
        public ZooDatabaseContext dbContext = new ZooDatabaseContext();

        private string _username;
        private string _password;
        private ViewModelBase _viewModel;
        private List<User> _users;

        public string Password
        {
            get { return _password; }
            set
            {
                if (value != null)
                {
                    _password = value;
                    OnPropertyChanged("Password");
                }
            }
        }

        public string Username 
        { 
            get { return _username; } 
            set { _username = value; OnPropertyChanged("Username"); } 
        }



        public List<User> Users { get; set; }
        public ViewModelBase ViewModel
        {
            get { return _viewModel; }
            set
            {
                _viewModel = value;
                OnPropertyChanged(nameof(ViewModel));
            }
        }

        public int ValidateLogin()
        {
            if (Username != null && Password != null)
                return dbContext.Users.FirstOrDefault(u => u.Username == this.Username && u.Password == this.Password).Id;
            return 0;
        }


        public CommandBase ChangeViewCommand { get; set; }

        public LoginViewModel()
        {
            ChangeViewCommand = new ChangeViewCommand(this);
        }
    }
}
