using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planen
{
    class Account
    {
        //Property
        private int _userID;
        private string _username;
        private string _password;
        private string _email;
        public int UserID
        {
            get { return _userID; }
        }
        public string Username
        {
            get { return _username; }
            set { _username = value; }
        }
        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }
        public void signUp() { }

        public void Login() { }
    }
    //Property Definition
}