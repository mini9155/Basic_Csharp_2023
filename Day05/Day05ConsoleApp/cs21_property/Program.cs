using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs21_property
{
    internal class Program
    {
        class Boier
        {
            // 모든 클래스에 modify 안 적으면 기본이 private
            private int temp; //기본 멤버 변수

            public int Temp //프로퍼터(속성)
            {
                get { return Temp; }
                set
                {
                    if (value <= 10 || value > 70)
                    {
                        Temp = 10;
                    }
                    else
                    {
                        Temp = value;
                    }
                }
            }

            public void SetTemp(int temp)
            {
                if (temp <= 10 || temp >= 70)
                {
                    Console.WriteLine("수온 설정값이 너무 낮거나 높습니다. 10~70도 사이로 설정해주세요");
                    return;
                }
                this.temp = temp;
            }

            public int GetTemp()
            {
                return this.temp;
            }
        }

        class car
        {
            string name;
            string color;
            int year;
            string fueltype;
            int door;
            string tiretype;
            string company;
            int price;
            string carIdnumber;
            string carplatenumber;

            public string Name { get; set; }//필터링이 필요 없으면 멤버 변수 없이 프로퍼티로 대체
            public string Color { get; set; }
            // 들어오는 데이터를 필터링 할 때 private 멤버변수와 public 프로퍼티 둘 ㄷ ㅏ사용
            public int Year
            { get => year; set { if (value <= 1990 || value >= 2023)
                    {
                        value = 2023;
                    }

                    year = value;
                }
            }
            public string Fueltype
            {
                get => Fueltype;
                set
                {
                    if (value != "휘발유" || value != "경유")
                    {
                        value = "휘발유";
                    }

                    fueltype = value;
                }
            }
            public int Door { get => door; set => door = value; }
            public string Tiretype { get => tiretype; set => tiretype = value; }
            public string Company { get => company; set => company = value; }
            public int Price { get => price; set => price = value; }
            public string CarIdnumber { get => carIdnumber; set => carIdnumber = value; }
            public string Carplatenumber { get => carplatenumber; set => carplatenumber = value; }
        }
        interface IProduct
        {
            string PrductName { get; set; }
            void Produce();
        }
        class Myproduct : IProduct
        {
            private string ProductName;

            public string PrductName
            {
                get { return ProductName; }
                set { ProductName = value; }
            }

            public void Produce()
            {
                Console.WriteLine("{0}을 생산합니다.", ProductName);
            }

        }
        static void Main(string[] args)
        {
            Boier kitturamy = new Boier();
           
            //kitturamy.temp = 60;
            //kitturamy.temp = 300000;
            //kitturamy.temp = -12;
            kitturamy.SetTemp(50);
            Console.WriteLine(kitturamy.GetTemp());

            Boier naviem = new Boier();
            naviem.Temp = 5000;
            Console.WriteLine(naviem.Temp);
        }
    }
}
