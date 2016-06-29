using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldApi
{
    public class Greeter
    {
        public static string Greet(string name = "")
        {
            return ($"Hello {name}").Trim();
        }
    }
}
