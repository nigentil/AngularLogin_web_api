using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AngularLogin_web_api.Models
{
    public class User
    {
        public int UserID { get; set; }
        public string UserLogin { get; set; }
        public string UserPassword { get; set; }
        public string UserFullName { get; set; }
        public bool UserActive  { get; set; }

        public UserType UserType { get; set; }
        public int UserTypeID { get; set; }

        public List<CompanyUser> CompanyUsers { get; set; }
    }
}
