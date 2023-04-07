using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs17_inheritance
{
    #region<상속>
    // 상속 해줄 부모 클래스
    class Parent
    {
        public string Name; // 상속   할 때 private를 쓰면 안 됨
        public Parent(string Name)
        {
            this.Name = Name;
            Console.WriteLine("{0} from Parent  생성자",Name);
        }
        public void ParentMethod()
        {
            Console.WriteLine("{0} from Parent 메서드",Name);
        }
    }

    // 상속 받을 자식 클래스
    class Child : Parent
    {
        // 부모 생성자를 먼저 실행한 뒤 자신 생성자를 실행
        public Child(string Name) : base(Name) 
        {
            Console.WriteLine("{0} from Child 생성자",Name);
        }

        public void ChildMethod()
        {
            Console.WriteLine("{0} from Child 메서드", Name);
        }
    }
    #endregion

    // 클래스 간 형 변환 DB처리,DI
    class Mammal // 포유류
    {
        public void Nurse()
        {
            Console.WriteLine("포유류 기르다");
        }
    }

    class Dogs:Mammal 
    {
        public void Bark()
        {
            Console.WriteLine("멍멍!!");
        }
    }
    class Cat : Mammal
    {
        public void Meow()
        {
            Console.WriteLine("야옹!!!");
        }
    }

    class Elephant : Mammal
    {
        public void  Poo()
        {
            Console.WriteLine("뿌우우");
        }
    }

    class ZooKeeper
    {
        public void Wash(Mammal mammal)
        {
            if (mammal is Elephant)
            {
                var animal = mammal as Elephant;
                Console.WriteLine("코끼리를 씻긴다");
                animal.Poo();
            }
            else if (mammal is Dogs)
            {
                var animal = mammal as Dogs;
                Console.WriteLine("강아지를 씻긴다");
                animal.Bark();
            }
            else if (mammal is Cat)
            {
                var animal = mammal as Cat;
                Console.WriteLine("고양이를 씻긴다");
                animal.Meow();
            }
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            #region<기본 상속 개념>
            Parent p = new Parent("P");
            p.ParentMethod();

            // 자식클래스는 부모 클래스의 속성, 기능을 모두 쓸 수 있다!
            Console.WriteLine("자식 클래스 생성");
            Child c = new Child("C");
            c.ParentMethod();
            c.ChildMethod();
            #endregion
            #region<클래스 간 형식 변환>
            // Mammal mammal = new Mammal(); // 기본
            Mammal mammal = new Dogs();
            // Dogs dogs = new Mammal(); // 자식이 부모한테는 ㄴㄴ

            if (mammal is Dogs)
            {
                Dogs midDog = mammal as Dogs;
                midDog.Bark();
            }
            Dogs dog2 = new Dogs();
            Cat cat2 = new Cat();
            Elephant el2 = new Elephant();
            

            ZooKeeper keeper = new ZooKeeper();

            #endregion
        }
    }
}
