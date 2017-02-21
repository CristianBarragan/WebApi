using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Security.Principal;

namespace WebApi.Filters
{
    public class BasicAuthenticationIdentity : GenericIdentity
    {
        public string Password { get; set; }
        public string UserName { get; set; }
        public int UserId { get; set; }

        public BasicAuthenticationIdentity(string username, string password) : base(username, "Basic")
        {
            Password = password;
            UserName = username;
        }
    }
}