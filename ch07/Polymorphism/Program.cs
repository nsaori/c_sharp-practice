//201024 polymorphism -다형성
//p.326
//큰 집합 = 작은 집합   ; memory 할당과는 무관하다.
//ex;   int i = 'A'; Animal c = new Cat();
//최상의 class; Object class첸 모든게 들어간다
//->3차원 배열은 쓰지않는다. (아리고리즘을 풀 땐 사용할 수도 있다)

//polymorphism -다형성
//1.definition(갹체 생성) 2.arry, list-> polymorphism로 만든다 3.4.5.
//3.polymorphic parameter 4.return 5.overriding



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {

            //1.definition
            Object o = 123;
            Object o1 = new Dog();

            int ii = 'A';    //자동 형변환 ; 큰 집합 = 작은 집합 
            Animal a = new Dog(); //상속한 부분(animal에 있는것)만 가능, dog의 있는 건 호풀 불가능하다.
            a.Eat();        //상속한 부분(animal에 있는것)만 사용 가능하다.
            // a.Bark();   //dog의 있는 건 호풀 불가능하다.
            //Animal c = new Cat();   //Animal type의 면수; polymarphism(다형성) ; 큰 집합(super class) = 작은 집합  
            //Animal d = new Dog();

            Console.WriteLine();

            //2.array
            Object[] oa = new Object[2];  //모든게 들어간다
            //3.parameter
            List<Object> olist = new List<object>();    //모든게 들어간다

            Console.WriteLine();
            int[] ia = new int[2];
            ia[0] = 'A';    //int 배열엔 int.char도 들어간다   *long면 int,char도 들어간다--

            Animal[] aa = new Animal[2];
            aa[0] = new Dog();
            aa[1] = new Cat();
            for (int i = 0; i < aa.Length; i++)
            {
                aa[i].Eat();
                aa[i].Sleep();
               
            }

            Console.WriteLine();
            List<Animal> list = new List<Animal>();
            list.Add(new Dog());
            list.Add(new Cat());
            foreach (var item in list)
            {
                item.Eat();
                item.Sleep();
                if (item is Cat) { ((Cat)item).Meow(); }   //(item is Cat) ->true/false
                if (item is Dog) { (item as Dog).Bark(); }  //(item as Dog) -> object/null
            }
            //4.return


            //5.overriding
            Animal d = new Dog();
            d.Eat();
            d = new Cat();
            d.Eat();
        }
    }
}


/*
 * public void Set(Animal A){
 // public void Set(int a){
 *  ...
 * }
 //Set('A');
 * Set(new DOg())  //polymorphic parameter
 * */