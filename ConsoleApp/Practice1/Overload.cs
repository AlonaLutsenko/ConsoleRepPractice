using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Practice1
{
    public class Overload
    {
        private string name = "Akhil";

        public void Display()
        {
            Display2(ref name, ref name);
            System.Console.WriteLine(name);
        }

        private void Display2(ref string x, ref string y)
        {
            System.Console.WriteLine(name);
            x = "Akhil 1";
            System.Console.WriteLine(name);
            y = "Akhil 2";
            System.Console.WriteLine(name);
            name = "Akhil 3";
        }
    }
}
