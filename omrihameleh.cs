using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal f1 = new Fish();
             f1;//downcasting
            Fish s = new Fish(1,"sting","string",3);//not legel
            Animal a = s;//auto upcast the fish
            Fish s1 = (Fish)a;
            Console.WriteLine(s1.ToString()); 
            Console.ReadLine();
        }
    }
}
