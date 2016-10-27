using System;

namespace School
{
    class DuplicatedException : Exception
    {
        public DuplicatedException(string msg) : base(msg)
        {

        }
    }
}
