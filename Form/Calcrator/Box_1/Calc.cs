using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Box_1
{
    class CalcClass
    {
        private double su = 0.0;
        private char op = '=';

        public string Box_1(string ssu, string sop)
        {
            double d = double.Parse(ssu);
            switch (op)
            {
                case '=':
                    su = d;
                    break;
                case '+':
                    su = su + d;
                    break;
                case 'ㅡ':
                    su = su - d;
                    break;
                case 'X':
                case 'x':
                case '*':
                    su = su * d;
                    break;
                case '%':
                    su = su / d;
                    break;
            }
            op = sop[0];
            return su.ToString();

        }
    }
}
