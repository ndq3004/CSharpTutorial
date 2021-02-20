using System;
using System.Collections.Generic;
using System.Text;

namespace tutorial.IService
{
    interface ISysLogin
    {
        bool Login(string Username, string Password);
        bool Register(string Username, string Password);
    }
}
