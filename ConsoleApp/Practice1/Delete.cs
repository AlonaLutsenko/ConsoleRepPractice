using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Practice1
{
    internal class Delete
    {
        String str = "GeeksForGeeks";

        Console.WriteLine("String    : " + str);
  
        // retrieve the substring from index 0 to length 8
        Console.WriteLine("Sub String1: " + str.Substring(0, 8));
  
        // retrieve the substring from index 5 to length 3
        Console.WriteLine("Sub String2: " + str.Substring(5, 3));
    }
}
