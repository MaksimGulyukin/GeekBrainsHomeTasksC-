using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz2
{
    class Program
        //Гулюкин
        //Ввести вес и рост человека.Рассчитать и вывести индекс массы тела(ИМТ) по формуле I=m/(h* h); где m — масса тела в килограммах, h — рост в метрах
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите вес человека :");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите рост человека :");
            int h = Convert.ToInt32(Console.ReadLine());
            int I = m / (h * h);
            Console.WriteLine("Индекс массы тела равен " + I);
            Console.ReadKey();
        }
    }
}
