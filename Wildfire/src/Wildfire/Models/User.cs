using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace Wildfire.Models
{
    public class User
    {
        public string Login;
        public string Password;
        public string FirstName;
        public string lastName;
        public string User_Id;
    }

}
