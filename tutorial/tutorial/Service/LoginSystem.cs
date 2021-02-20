using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Text;
using tutorial.IService;

namespace tutorial.Service
{
    class LoginSystem : ISysLogin
    {
        private readonly ConcurrentDictionary<string, string> _users = new ConcurrentDictionary<string, string>();
        public bool Login(string Username, string Password)
        {
            if(Username == null || Password == null) throw new ArgumentNullException();
            string PasswordReal = "";
            if(_users.TryGetValue(Username, out PasswordReal))
            {
                if (Password.Equals(PasswordReal))
                {
                    return true;
                }
            }
            return false;
        }

        public bool Register(string Username, string Password)
        {
            if (Username == null || Password == null) throw new ArgumentNullException();
            return _users.TryAdd(Username, Password);
        }
    }
}
