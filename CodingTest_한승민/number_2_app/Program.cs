using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace number_5_app
{
    internal class Program
    {
        class Boiler
        {
            public Boiler()
            {
                Brand = string.Empty;
                Voltage = 0;
                Temperature = 0;
            }

            public string Brand { get; set; }

            private int voltage;
            public int Voltage
            {
                get { return voltage; }
                set
                {
                    if (value == 110 || value == 220)
                    {
                        voltage = value;
                    }
                }
            }

            private int temperature;
            public int Temperature
            {
                get { return temperature; }
                set
                {
                    if (value >= 70)
                    {
                        temperature = 70;
                    }
                    else if (value <= 5)
                    {
                        temperature = 5;
                    }
                    else
                    {
                        temperature = value;
                    }
                }
            }

            public void printAll()
            {
                Console.WriteLine(Brand);
                Console.WriteLine(Voltage);
                Console.WriteLine(Temperature);
            }
        }


        static void Main(string[] args)
        {
            Boiler kiturrami = new Boiler
            {
                Brand = "귀뚜라미",
                Voltage = 220,
                Temperature = 45
            };
            kiturrami.printAll();

        }

    }
}
