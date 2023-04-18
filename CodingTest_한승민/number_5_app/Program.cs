using System;

namespace number_5_app
{
    internal class Program
    {
        public interface IAnimal
        {
            string Name { get; set; }
            int Age { get; set; }
            void eat();
            void Sleep();

            void Sound();
        }

        class Dog : IAnimal
        {
            public string Name { get; set; }
            public int Age { get; set; }

            public void eat()
            {
                Console.WriteLine("{0}이 먹습니다", Name);
            }

            public void Sleep()
            {
                Console.WriteLine("{0}이 잔다", Name);

            }

            public void Sound()
            {
                Console.WriteLine("{0}이 멍멍 소리를 냅니다", Name);

            }
        }
        class Cat : IAnimal
        {
            public string Name { get; set; }
            public int Age { get; set; }

            public void eat()
            {
                Console.WriteLine("{0}이 먹습니다", Name);
            }

            public void Sleep()
            {
                Console.WriteLine("{0}이 잔다", Name);

            }

            public void Sound()
            {
                Console.WriteLine("{0}이 냐옹 소리를 냅니다", Name);

            }
        }
        class Horse : IAnimal
        {
            public string Name { get; set; }
            public int Age { get; set; }

            public void eat()
            {
                Console.WriteLine("{0}이 먹습니다", Name);
            }

            public void Sleep()
            {
                Console.WriteLine("{0}이 잔다", Name);

            }

            public void Sound()
            {
                Console.WriteLine("{0}이 히히힝 소리를 냅니다", Name);

            }
        }


        static void Main(string[] args)
        {


        }

    }
}
