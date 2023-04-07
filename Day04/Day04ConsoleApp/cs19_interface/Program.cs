using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs19_interface
{
    // 클래스 상속을 하면 안에 함수를 써서
    // 무조건 구현 해야 함
    interface ILogger // 인터페이스를 상속하는 것은 구현
    {
        
        void WriteLog(string log);
    }
    interface IFormattableLogger : ILogger
    {
        void WriteLog(string format, params object[] args); // args 다중 파라미터
    }
    class ConsoleLogger : ILogger
    {
        public void WriteLog(string log)
        {
            Console.WriteLine("{0} {1}",DateTime.Now.ToLocalTime(),log);
        }
    }
    class ConsoleLogger2 : IFormattableLogger
    {
        public void WriteLog(string format, params object[] args)
        {
            string message = string.Format(format, args);
            Console.WriteLine("{0}, {1}",DateTime.Now.ToLocalTime(),message);
        }

        public void WriteLog(string log)
        {
            Console.WriteLine("{0} {1}", DateTime.Now.ToLocalTime(), log);
        }
    }

    class car
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public void Stop()
        {
            Console.WriteLine("정지");
        }
    }

    interface IHoverable
    {
        void Hover(); // 물에서 달린다
    }

    interface IFlyable
    {
        void Fly(); // 날다
    }
    //C# 다중 상속
    class FlyHoverCar : car, IFlyable, IHoverable 
    {
        public void Fly()
        {
            Console.WriteLine("납니다");
        }

        public void Hover()
        {
            Console.WriteLine("뜹니다");
        }

    internal class Program
    {
        static void Main(string[] args)
        {
            ILogger logger = new ConsoleLogger();
            // ConsoleLogger logger = new ConsoleLogger(); 이것도 됨

            logger.WriteLog("안녕!!");

            IFormattableLogger logger2 = new ConsoleLogger2 ();
            logger2.WriteLog("{0} x {1} = {2}", 6, 5, 6 * 5);
        }
    }
}
