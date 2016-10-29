//p.520
//http://www.kma.go.kr/index.jsp
// -> RSS
//http://www.kma.go.kr/weather/lifenindustry/sevice_rss.jsp?sido=4400000000&gugun=4420000000&dong=4420033000&x=33&y=6

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
            //Console.WriteLine(xElement);
            //Console.WriteLine();

            var xmlQuery = from item in xElement.Descendants("data")
                           select new {
                               Hour = item.Element("hour").Value,
                               Day = item.Element("day").Value,
                               Temp = item.Element("temp").Value,
                               WdKor = item.Element("wdKor").Value,
                               WfKor = item.Element("wfKor").Value,
                               Tmn = item.Element("tmn").Value,
                               Tmx = item.Element("tmx").Value
                           };

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
