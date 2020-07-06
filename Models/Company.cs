using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AngularLogin_web_api.Models
{
    public class Company
    {
        public int CompanyID { get; set; }
        public string CompanyName { get; set; }

        public List<CompanyUser> CompanyUsers { get; set; }
    }
}
