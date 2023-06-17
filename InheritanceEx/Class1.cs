using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceEx  
{
    
    public class Mobile //parent class
    {
        public string os = "Android";
        public void MakeCalls() 
        {
            Console.WriteLine("Any mobiles can make calls");
        }
    }
}
