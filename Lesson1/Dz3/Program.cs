using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz3
{
    class Program  //Гулюкин
                  //Написать программу обмена значениями двух переменных:
                 //а) с использованием третьей переменной;

    {
        static void Main(string[] args)
        {
            
            int a = 2;
            int b = 3;
            int c;
            Console.WriteLine(Convert.ToInt32(a) + " " + Convert.ToInt32(b));
            c = a;
            a = b;
            b = c;
            Console.WriteLine(Convert.ToInt32(a) + " " + Convert.ToInt32(b));
            Console.ReadKey();
        }
    }
}
