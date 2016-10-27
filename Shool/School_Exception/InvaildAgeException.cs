using System;

namespace School
{
    class InvaildAgeException : Exception
    {
        public InvaildAgeException(string msg) : base(msg)
        {

        }
    }
}
