using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs25_exception
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3 };
            try
            {
                for (var i = 0; i < 5; i++)
                {
                    Console.WriteLine(array[i]);
                }
            } catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                // 예외가 발생하더라도 무조건 처리해야 되는 로직
                //file 객체 close
                //db 연결 close
                // 네트워크 소켓 close
                Console.WriteLine("계속 가요!");
            }

            DiviedTest(array[2], array[0]);

            Console.WriteLine("프로그램 종료!!");

            try
            {
                Console.WriteLine("Test Test");
                throw new Exception("커스텀 예외");
                DiviedTest(array[2], 0);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            


        }

        private static void DiviedTest(int v1, int v2)
        {
            try
            {
                //throw new NotImplementedException(); // 예외 던지기
                Console.WriteLine(v1 / v2);
            }
            catch(Exception e)
            {
                throw new Exception("DivideTest 메서드에서 예외가 발생!");
            }
        }
    }
}
