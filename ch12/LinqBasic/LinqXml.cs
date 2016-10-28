//p.520

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DElegateRand
{
    class Program
    {
        static void Main(string[] args)
        {
            string url = "http://www.kma.go.kr/wid/queryDFSRSS.jsp?zone=4420033000";
            XElement xElement = XElement.Load(url);
            Console.WriteLine(xElement);
        }
    }
}
