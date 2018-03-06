using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JenkinBuildApp_1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(createmessage());
        }
        public static String createmessage()
        {
            return "Hello Jenkins";
        }
    }
}
