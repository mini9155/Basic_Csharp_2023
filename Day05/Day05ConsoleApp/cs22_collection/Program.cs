using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs22_collection
{
    internal class Program
    {
        class MylList
        {
            int[] array;
            public MylList() 
            {
                array = new int[3];
            }
            public int Length
            {
                get { return array.Length; }
            }
            public int this[int index]
            {
                get { return array[index]; }
                set { 
                    if (index >= array.Length) // 3보다 커지면
                    { 
                        Array.Resize<int>(ref array, index + 1); 
                        Console.WriteLine("MyList Resized : {0}",array.Length);

                    }
                    array[index] = value;
                } // 3보다 커지면
            }

        }
        static void Main(string[] args)
        {
            int[] array = new int[5];
            array[0] = 1;
            array[1] = 2;
            array[2] = 3;
            array[3] = 4;
            array[4] = 5; // 지정범위를 벗어날 수 없다

            Console.WriteLine(array[1]);

            char[] oldstring = new char[5]; // 옛날 방식 - 문자열의 길이를 지정해야함 , c에서만
            string curString = "154"; //문자열 길이 제한 없음
            Console.WriteLine(curString);

            // ArrayList
            ArrayList list = new ArrayList();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            list.Add(6);
            list.Add(7);
            list.Add(8);  //위의 배열과 차이점 - 길이의 제약이 없음

            Console.WriteLine(list[7]);

            ArrayList list2 = new ArrayList();
            list2.Add(8);
            list2.Add(1);
            list2.Add(15);
            list2.Add(2);
            list2.Add(3);
            list2.Add(10);

            foreach (var item in list2)
            {
                Console.WriteLine(item);
            }

            //리스트에서 데이터 삭제
            Console.WriteLine("10 삭제 후");
            list2.Remove(10);
            Console.WriteLine("3번째 데이터 삭제");
            list2.RemoveAt(3);

            foreach (var item in list2)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("0번째 위치 7 추가");
            list2.Insert(0, 7);

            foreach(var item in list2)
            {
                Console.Write(item);
            }

            Console.WriteLine("정렬");
            list2.Sort();
            foreach(var item in list2)
            {
                Console.WriteLine(item);
            }

            //ArrayList .add(), Insert(x,val), RemoveAt(x), sort(), Reserve()


            MylList mylList = new MylList();
            for(int i = 1; i <= 5; i++)
            {
                mylList[i] = i * 5;
            }

            for (int i = 0; i < mylList.Length; i++)
            {
                Console.WriteLine(mylList[i]);
            }
        }
    }
}
