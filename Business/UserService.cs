using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AngularLogin_web_api.Data;
using AngularLogin_web_api.Models;

namespace AngularLogin_web_api.Business
{
    public class UserService
    {
        private ProjectContext _context;

        public UserService(ProjectContext context)
        {
            _context = context;
        }

        public User Obtain(string UserLogin)
        {
            UserLogin = UserLogin?.ToUpper();

            if (!String.IsNullOrWhiteSpace(UserLogin))
            {
                return _context.Users.Where(
                    p => p.UserLogin == UserLogin).FirstOrDefault();
            }
            else
            {
                return null;
            }
        }

        public IEnumerable<User> List()
        {
            return _context.Users.OrderBy(
                p => p.UserFullName).ToList();
        }

    }
}
