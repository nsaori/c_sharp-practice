using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    class DuplicationException : Exception
    {
        public DuplicationException(string msg) : base(msg) {

        }
    }
}
