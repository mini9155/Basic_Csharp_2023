
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wf13_bookrentalshop.Helpers
{
    internal class Commons
    {

        //ConnString이라는 문자열, 모든 프로그램 상에서 다 사용 가능
        public static readonly string ConnString = "Server=localhost;" +
            "Port=3306;" +
            "Database=bookrentalshop;" +
            "Uid=root;" +
            "Pwd=12345";
    }
}
