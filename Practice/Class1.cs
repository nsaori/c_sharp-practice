using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Class1
    {
        int n;
        public int N {
            get { return n; }
            set { CheackN(value); }
        }

        private void CheackN(int n)
        {
            //throw new NotImplementedException();
            if (n >= 0)
            {
                this.n = n;
            }
            else {
                Console.Write("please enter a number bigger than 0");
            }
        }

        public Class1() {
            N = 1;
        }
        public Class1(int n) {
            N = n;
        }

    }
}
