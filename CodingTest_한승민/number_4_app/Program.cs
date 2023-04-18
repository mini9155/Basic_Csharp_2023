using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace number_4_app
{
    internal class Program
    {


        static void Main(string[] args)
        {
            var Rainbow = new Dictionary<string, string>();

            Rainbow.Add("Red", "빨간색");
            Rainbow.Add("Orange", "주황색");
            Rainbow.Add("Yellow", "노란색");
            Rainbow.Add("Green", "초록색");
            Rainbow.Add("Blue", "파란색");
            Rainbow.Add("Navy", "남색");
            Rainbow.Add("Purple", "보라색");

            Console.WriteLine("무지개는 빨간색, 주황색, 노란색, 초록색, 파란색, 남색, 보라색 입니다");

            string keyToGet = "Purple";
            var result = Rainbow.FirstOrDefault(kvp => kvp.Key.Equals(keyToGet));

            Console.WriteLine(result);
        }
    }
}
