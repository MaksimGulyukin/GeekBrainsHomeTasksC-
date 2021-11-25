using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ3
{
    class Program
    {
        //Гулюкин
        //а) С клавиатуры вводятся числа, пока не будет введён 0 (каждое число в новой строке).
        //Требуется подсчитать сумму всех нечётных положительных чисел. Сами числа и сумму вывести на экран, используя tryParse.

        static void Main(string[] args)
        {
            int summa = 0;
            string cifra;
            int c;
            

            do
            {
                Console.WriteLine("Введите число : ");
                cifra = Console.ReadLine();
                int res = Convert.ToInt32(int.TryParse(cifra, out c));
                if (res > 0 && res % 2 == 1)
                    summa += res;
                
            } while (Convert.ToInt32(cifra) != 0); //К сожалению так и не понял как завершить цикл, так же пробовал указывать переменную с,
                                                   //а так же пробовал в условие вписать что для прерывания цикла должно быть != "0"
                                                   //while (cifra != "0");
                                                   //while (с != 0);

            Console.ReadKey();
        }
         
    }
}
