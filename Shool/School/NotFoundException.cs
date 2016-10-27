using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    class NotFindException :Exception
    {
        public NotFindException(string msg) : base(msg) {

        }
    }
}
