using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trainer.Classes
{
    internal class GetDATA
    {
        public string login { get; set; }
        public string password { get; set; }

        public static bool IsEqual(GetDATA user1, GetDATA user2)
        {
            if (user1 == null || user2 == null) { return false; }
            if (user1.login != user2.login)
            {
                return false;
            }
            if (user1.password != user2.password)
            {
                return false;
            }

            return true;
        }
    }
}
