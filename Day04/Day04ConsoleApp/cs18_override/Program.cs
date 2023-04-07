﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs18_override
{
    class ArmorSuite
    {
        public virtual void Init()
        {
            Console.WriteLine("기본 아머 슈트");
        }
    }

    class IronMan : ArmorSuite 
    {
        public override void Init()
        {
            base.Init();
            Console.WriteLine("리필서 빔!");
        }
    }

    class WarMachine : ArmorSuite
    {
        public override void Init()
        {
            // 부모가 가진 것을 실행하고 싶지 않으면 base.init을 안 적으면 된다
            base.Init(); 
            Console.WriteLine("미니건");
            Console.WriteLine("돌격소총");
        }
    }

    class Parent
    {
        public void CurrentMethod()
        {
            Console.WriteLine("부모클래스 메서드");
        }
    }

    class Chid: Parent 
    {
        public new void CurrentMethod()
        {
            Console.WriteLine("자식 클래스 메서드");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("아머슈트 생산");
            ArmorSuite suite = new ArmorSuite();
            suite.Init();

            Console.WriteLine("워머신 생산");
            WarMachine machine = new WarMachine();
            machine.Init();

            Console.WriteLine("아이언맨 생산");
            IronMan iron = new IronMan();
            iron.Init();

        }
    }
}
