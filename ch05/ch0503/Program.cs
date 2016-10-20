//ch05 04 p247
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch0503
{
    class Book {
        public string name;
        public DateTime date;
        public string writer;
        public string publisher;
        public string place;
        public string derector;
        public string planner;
        public string editor;
        public string disigner;

        public string ToString() {
         
            return "\n 변  수 :  값 \n\n"+" 이  름 : "+ name + "\n초반발행: " +date+ "\n지 은 이: " +writer+ 
                "\n펴 낸 이: " +publisher+ "\n펴 낸 곳: " +place+ "\n책임편짐: " +derector+
                "\n 기  획 : " +planner+ "\n 편  집 : " +editor +"\n디 자 인: "+ disigner + "\n" ;
               
               // return { "\n 변  수: 값 \n\n이  름 : {0} \n초반발행: {1} \n지 은 이: {2} \n펴 낸 이: {3} \n펴 낸 곳: {4} \n책임편짐: {5} \n 기  획 : {6} \n 편  집 : {7} \n디 자 인: {8}",name,date,writer, publisher,place,derector,planner,editor,disigner};
        }

    }
    class Program
    {
        static void Main(string[] args)
        {

            Book b1 = new Book{
                name = "PHP 프로그래밍 입문",
                date = new DateTime(2013,5,20),
                writer = "황재호",
                publisher = "김태헌",
                place = "한빛아카데미(주)",
                derector = "김현용",
                planner = "김이화",
                editor = "김이화",
                disigner = "여동일",
            };

            Console.WriteLine(b1.ToString());
            
        }
    }
}
