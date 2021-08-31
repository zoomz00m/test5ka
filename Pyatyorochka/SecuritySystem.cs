using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pyatyorochka
{
    class SecuritySystem
    {
        public bool OldEnough(User user)
        {
            if (user.Age >= 18)
                return true;
            return false;
        }
    }
}
