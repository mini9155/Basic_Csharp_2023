using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs30_filereadwrite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string line = string.Empty; // 텍스트를 읽어와서 출력
            StreamReader reader = null;

            try
            {
                reader = new StreamReader(@".\python.py"); // 스트림리더 파일 연결

                line = reader.ReadLine(); // 한 줄 씩 읽음

                while(line != null) // 읽을 게 없을 때 까지
                {
                    Console.WriteLine(line);
                    line = reader.ReadLine();
                }
            }
            catch(Exception e)
            {
                Console.WriteLine($"예외! {e}");
            }
            finally 
            {
                reader.Close(); //파일을 읽으면 무조건 마지막에
            }
            // 읽기 끝

            StreamWriter writer = new StreamWriter(@".\pythonByCsharp.py");
            try
            {
                writer.WriteLine("import sys;");
                writer.WriteLine("");
                writer.WriteLine("print(sys.executable);");
            }
            catch(Exception e)
            {
                Console.WriteLine($"예외! {e.Message}");
            }
            finally { writer.Close(); }
            Console.WriteLine("파일생성 완료!");
        }
    }
}
