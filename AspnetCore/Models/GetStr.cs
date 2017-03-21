using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspnetCore.Models
{
   
    public class GetStr
    {
        public static string getss(string a) {
            Startup.connectionString = "abc";
            return a;
        }
    }
}
