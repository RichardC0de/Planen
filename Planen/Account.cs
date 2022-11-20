using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planen
{
    public class Account
    {
        //Property
        private static int _userID;
        private string _username;
        private string _password;
        private string _email;
        public static int UserID
        {
            get { return _userID; }
            set { _userID = value; }
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