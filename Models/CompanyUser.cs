using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Threading.Tasks;

namespace AngularLogin_web_api.Models
{
    public class CompanyUser
    {
        public Company Company { get; set; }
        public User User { get; set; }
        public int CompanyID { get; set; }
        public int UserID { get; set; }
    }
}
