using System;

namespace cs27_delgatechain
{
    delegate void ThereIsAFire(string location);

    delegate int Calc(int a, int b);

    delegate string Concatenate(string[] args);

    class sample
    {
        private int valueA;

        public int ValueA
        {
            get => valueA; set => valueA = value;
        } // { get { return valueA; } set { valueA = value; } }

    }
    internal class Program
    {
        static string ProcConcate(string[] args)
        {
            string result = string.Empty;
            foreach (string s in args)
            {
                result += s;
            }
            return result;
        }


        static void Main(string[] args)
        {
            Calc plus = delegate (int a, int b)
            {
                return a + b;
            };

            Concatenate concat2 = (arr) =>
            {
                string res = string.Empty;
                foreach (string s in arr)
                {
                    res += s + "/";
                }
                return res;
            };
            Console.WriteLine(concat2(args));

        }
    }
}
