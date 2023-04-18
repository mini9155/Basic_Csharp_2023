using System;

namespace number_3_app
{
    internal class Program
    {
        class Car
        {
            public string Name;
            public string Maker;
            public string Color;
            public int YearModel;
            public int MaxSpeed;
            public string UniqueNumber;
            public Car() { }

            public void start()
            {
                Console.WriteLine("{0}의 시동을 겁니다", Name);
            }
            public void Accelerate()
            {
                Console.WriteLine("최대시속 {0}km/h로 가속합니다", MaxSpeed);
            }

            public void TurnRight()
            {
                Console.WriteLine("{0}을 우회전 합니다",Name);
            }
            public void Brake()
            {
                Console.WriteLine("{0}의 브레이크를 밟습니다",Name);
            }
        }
        class ElectricCar : Car
        {
            public void ReCharge()
            {
                Console.WriteLine("달리면서 바테리를 충전합니다");
            }

        }
        class Hybridcar : ElectricCar
        {
        }
        static void Main(string[] args)
        {
            Hybridcar ioniq = new Hybridcar();
            ioniq.Name = "아이오닉";
            ioniq.Maker = "현대자동차";
            ioniq.Color = "White";
            ioniq.YearModel = 2018;
            ioniq.MaxSpeed = 220;
            ioniq.UniqueNumber = "54라3346";

            ioniq.start();
            ioniq.Accelerate();
            ioniq.ReCharge();
            ioniq.TurnRight();
            ioniq.Brake();
        }
    }
}
