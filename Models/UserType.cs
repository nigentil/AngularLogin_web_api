using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AngularLogin_web_api.Models
{
    public class UserType
    {

        public int UserTypeID { get; set; }
        public string UserTypeName { get; set; }

        public List<User> Users { get; set; }

    }
}
