﻿using System;
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
        //public void Display()
        //{
        //    Display2(ref name, ref name);
        //    System.Console.WriteLine(name);
        //}

        private void Display2(ref string x, ref string y)
        {
            
        }
        private void Display3(ref string x, ref string y)
        {
            System.Console.WriteLine(name);
            x = "sssssssssssssss";
            System.Console.WriteLine(name);
            y = "sssssssssssss";
            System.Console.WriteLine(name);
            name = "sssssssss";
        }
    }
}
