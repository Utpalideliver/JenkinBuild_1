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
            Console.WriteLine(createmessage_1());
        }
        public static String createmessage()
        {
            return "Hello Jenkins";
        }
        public static String createmessage_1()
        {
            return "Hello Jenkins New";
        }
    }
}
