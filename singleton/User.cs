using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace singleton
{
    class User
    {
        private static User user;

        private User()
        {

        }

        public static User GetInstance()
        {
            if (user == null)
            {
                user = new User();
                return user;
            }
            return user;
        }

    }
}
