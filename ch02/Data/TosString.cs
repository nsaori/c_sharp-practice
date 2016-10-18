using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//.parse(a)
//.toString()  = a + " "

namespace Data
{
    class TosString
    {
        static void Main() {
            string s = "123";
            int i = int.Parse(s);
            Console.WriteLine(s + "\t" + s.GetType());
            Console.WriteLine(i + "\t" + i.GetType());
            Console.WriteLine();

            int ii = 123;
            string ss = ii.ToString();
            Console.WriteLine(ii +"\t"+ii.GetType());
            Console.WriteLine(ss + "\t" + ss.GetType());
            Console.WriteLine();

            string tt = " " + ii;   //ii+" "   ->문자가 된다(=tostring())
            Console.WriteLine(tt + "\t" + tt.GetType());
            Console.WriteLine();

            double d = 52.273103;
            Console.WriteLine(d);
            Console.WriteLine(d.ToString());
            Console.WriteLine(d.ToString("0"));
            Console.WriteLine(d.ToString("0.0"));
            Console.WriteLine(d.ToString("0.00"));
            Console.WriteLine(d.ToString("0.000"));
            Console.WriteLine(d.ToString("0.0000"));
            Console.WriteLine(d.ToString("0.00000"));
            Console.WriteLine(d.ToString("0.000000"));
            Console.WriteLine(d.ToString("0.0000000"));
            Console.WriteLine(d.ToString("0.00000000"));
            Console.WriteLine(d.ToString("0.000000000"));
            Console.WriteLine();

            Console.WriteLine(52 + 273);
            Console.WriteLine("52" + 273);
            Console.WriteLine(52 + "273");
            Console.WriteLine("52" + "273");
            Console.WriteLine();

            char c = 'a';
            string st = c + " ";   //x ;st = c 
            Console.WriteLine(c + "\t" + c.GetType());
            Console.WriteLine(st + "\t" + st.GetType());

        }
    }
}
