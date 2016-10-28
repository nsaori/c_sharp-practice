//p.520

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DElegateRand
{
    class LinqXml
    {
        static void Main(string[] args)
        {
            string url = "http://www.kma.go.kr/wid/queryDFSRSS.jsp?zone=4420033000";
            XElement xElement = XElement.Load(url);
            Console.WriteLine(xElement);
            Console.WriteLine();

            var xmlQuery = from item in xElement.Descendants("data")
                               //select item;
                           select new {
                               Hour = item.Element("hour").Value,
                               Day = item.Element("day").Value,
                               Temp = item.Element("temp").Value,
                               WdKor = item.Element("wdkor").Value,
                               WfKor = item.Element("wfKor").Value,
                               Tmn = item.Element("tmn").Value,
                               Tmx = item.Element("tmx").Value
                           };

            /*
            foreach (var item in xmlQuery)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();*/
            /*
            foreach (var item in xmlQuery)
            {
                Console.Write(item.Element("hour").Value+"\t");
                Console.Write(item.Element("day").Value + "\t");
                Console.Write(item.Element("temp").Value + "\t");
                Console.Write(item.Element("wdkor").Value + "\t");
                Console.Write(item.Element("wfKor").Value + "\t");
                Console.Write(item.Element("tmn").Value + "\t");
                Console.Write(item.Element("tmx").Value + "\t");
                Console.WriteLine();
            }*/
            foreach (var item in xmlQuery)
            {
                Console.Write(item.Hour + "\t");
                Console.Write(item.Day + "\t");
                Console.Write(item.Temp + "\t");
                Console.Write(item.WdKor + "\t");
                Console.Write(item.WfKor + "\t");
                Console.Write(item.Tmn + "\t");
                Console.Write(item.Tmx + "\t");
                Console.WriteLine();
            }
        }
    }
}
