//ch5 p.207 Class start
//20161019
//class 생성3가지 1. 프로그램 안에, 2.클래스, 3. 안에파일 따로
//1.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ClassUses
{
    class Car
    {  //car.cs(class file 따로) 로 만들어도 된다.
       //data, 변수
        public string name;
        public int number;
        public DateTime inTime;
        public DateTime outTime;

        //logic, method
        public void SetInTime()
        {
            this.inTime = DateTime.Now;
        }
        public void SetOutTime()
        {
            this.outTime = DateTime.Now;
        }
    }
}
        
