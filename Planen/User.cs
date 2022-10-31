using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planen
{
    class User
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
    }
    //Property Definition
    
    public Boolean signUp()
    {
        return true;
    }

    public Boolean Login()
    {
        return true;
    }
       
}
