using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceEx
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Android android = new Android();
            android.MakeCalls();
            android.os = "ios";
            Console.WriteLine(android.os);
        }
    }
}
