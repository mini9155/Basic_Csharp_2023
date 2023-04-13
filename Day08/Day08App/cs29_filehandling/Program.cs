using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs29_filehandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // DIrectory == Folder
            // "C:\" / C
            string di = @"C:\DEV\Langs\Python311"; // 현재 디렉토리(상대 경로), ..은 부모 디렉토리
            Console.WriteLine("현재디렉토리 정보");
            

            var dirs = Directory.GetDirectories(di);
            Console.WriteLine(dirs);
            foreach(var dir in dirs)
            {
                var dirInfo = new DirectoryInfo(dir);
                Console.WriteLine("{0}", dirInfo.Attributes);
                Console.WriteLine("{0}", dirInfo.FullName);
            }

            var files = Directory.GetFiles(di);
            foreach(var file in files)
            {
                var fileInfo = new FileInfo(file);

                Console.WriteLine("{0}", fileInfo.Attributes);
            }
            // 특정경로에 하위폴더 / 하위파일 조회
            string path = @"C:\Temp\Csharp_Bank"; // 만들고자 하는 폴더
            string sfile = "Test.log"; // 생성할 파일

            if (Directory.Exists(path))
            {
                File.Create(path+@"\"+sfile); //C:\Temp\Csharp_Bank\Testlog
            }
            else
            {
                Console.WriteLine("해당경로가 없습니다{0}", path);
                Directory.CreateDirectory(path);

                Console.WriteLine("경로를 생성하여 파일을 생성합니다");
                File.Create(path + @"\" + sfile);

            }

        }
    }
}
