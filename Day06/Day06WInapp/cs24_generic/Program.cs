using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs24_generic
{
    internal class Program
    {
        #region<일반화 메서드>
        // 일반화 예제
        // 일반화 클래스 // where T : class 사용할 타입은 무조건 클래스
        class MyArray<T> where T : class 
        {
            // 밑에 타입을 받아서 씀
        }
        // 일반화
        static void CopyArray<T>(T[] source, T[]target) // 형식에 상관 없이 하나로 합침
        {
            for (var i  = 0; i < source.Length; i++)
            {
                target[i] = source[i];
            }
        }
        #endregion
        #region<하나로 합치자>
        //static void CopyArray(long[] source, long[] target)
        //{
        //    for (var i = 0; i < source.Length; i++)
        //    {
        //        target[i] = source[i];
        //    }
        //}
        //static void CopyArray(float[] source, float[] target)
        //{
        //    for (var i = 0; i < source.Length; i++)
        //    {
        //        target[i] = source[i];
        //    }
        //}
        #endregion

        static void Main(string[] args)
        {
            #region<일반화 시키기>
            int[] source = { 2,4,6,8,10 };
            int[] target = new int[source.Length];

            CopyArray(source, target);
            foreach (var item in target)
            {
                Console.WriteLine(item);
            }
            long[] source2 = { 2100000, 2300000, 3300000, 5600000, 7800000 };
            long[] target2 = new long[source2.Length];

            CopyArray(source2, target2);
            foreach (var item in target2)
            {
                Console.WriteLine(item);
            }

            float[] source3 = { 3.14f, 3.15f, 3.16f, 3.17f };
            float[] target3 = new float[source3.Length];


            CopyArray(source3, target3);
            foreach (var item in target3)
            {
                Console.WriteLine(item);
            }
            #endregion

            //일반화 컬렉션
            List<int> list = new List<int>();
            for(var i = 10; i>0; i--)
            {
                list.Add(i);
            }
            foreach(var item in list)
            {
                Console.WriteLine(item);
            }
            list.Remove(3);

            foreach(var item in list)
            { Console.WriteLine(item); }
            
            list.Sort();

            foreach(var item in list)
            { Console.WriteLine(item); }


            List<MyArray<string>> MyStringArray = new List<MyArray<string>>();

            Stack<float> stFloat = new Stack<float>();
            stFloat.Push(1.0f);
            stFloat.Push(-1.0f);
            stFloat.Push(0.0f);
            stFloat.Push(1.0f);
            stFloat.Push(0.0f);

            //foreach(var item in stFloat)
            //{
            //    Console.WriteLine(item);
            //}
            while(stFloat.Count > 0)
            {
                Console.WriteLine(stFloat.Pop());
            }

            Queue<string> qStrings = new Queue<string>();
            qStrings.Enqueue("Hello");
            qStrings.Enqueue("world");
            qStrings.Enqueue("My");
            qStrings.Enqueue("C#");
            while (qStrings.Count > 0)
            {
                Console.WriteLine(qStrings.Dequeue());
            }
            //일반화 딕셔너리
            Dictionary<string, int> dicNumbers = new Dictionary<string, int>();
            dicNumbers["하나"] = 1;
            dicNumbers["둘"] = 2;
            dicNumbers["셋"] = 3;
            dicNumbers["넷"] = 4;

            Console.WriteLine(dicNumbers["셋"]);
        }
    }
}
