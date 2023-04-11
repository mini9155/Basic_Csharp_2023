using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs23_collection
{
    class CustomEnumerator
    {
        int[] list = { 1, 3, 5, 7, 9 };

        public IEnumerator GetEnumerator()
        {
            yield return list[0]; // 메서드를 빠져나가지 않고 값만 돌려줌
            yield return list[1];
            yield return list[2];
            yield return list[3];
            yield break;
            //yield return list[4];
        }
    }

    class MyArrayList : IEnumerator, IEnumerable
    {
        int[] array;
        int position = -1;

        public MyArrayList()
        {
            this.array = new int[3];
        }
        //인덱서 프로퍼티
        public int this[int index]
        {
            get { return array[index]; }
            set
            {
                if (index >= array.Length)
                {
                    Array.Resize(ref array, index + 1);
                    Console.WriteLine("MyArrayList Resize : {0}", array.Length);
                }
                array[index] = value;
            }
        }

        public object Current
        {
            get
            {
                return array[position];
            }
        }

        public IEnumerator GetEnumerator()
        {
            for(var i = 0; i < array.Length; i++)
            {
                yield return array[i];
            }
        }

        public bool MoveNext()
        {
            if (position >= array.Length - 1)
            {
                Reset();
                return false;
            }

            position++;
            return position < array.Length;
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }

        internal class Program
        {
            static void Main(string[] args)
            {
                var obj = new CustomEnumerator();

                foreach (var item in obj)
                {
                    Console.WriteLine(item);
                }

                var myArrayList = new MyArrayList();
                for (var i = 0; i <= 5; i++)
                {
                    myArrayList[i] = i;// indexer 프로퍼티를 만들었기 때문에
                }
                foreach (var item in myArrayList) // IEnumerable 인터페이스를 구현했기 때문에
                {
                    Console.WriteLine(item);
                }
            }

            
        }
    }
}
