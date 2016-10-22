using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gugu
{
    class Gugudan
    {
        int n;
        public int N
        {
            get { return n; }
            set { CheackNum(value); }
        }
        private void CheackNum(int n)
        {
            if (2 <= n&& n <= 9)
            {
                this.n = n;
            }
            else {
                Console.WriteLine("2~9를 입력해주세요.");
                Environment.Exit(0);
            }
        }

        
        public Gugudan(int n) {
            N = n;
        }
        public Gugudan()
        {
            N = 2;
        }

        public void PrintAll()
        {

            for (int i = 1; i <= 9; i++) 
            {
                for (int j = 2; j <= N; j++)
                {
                    Console.Write(j+"x" +i +"="+ i*j +"\t");
                 }
                Console.WriteLine();
            }
        }
    }
}
