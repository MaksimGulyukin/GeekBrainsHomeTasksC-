using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz1 
{
    class Program
    //Гулюкин
    //Написать программу «Анкета». Последовательно задаются вопросы (имя, фамилия, возраст, рост, вес). В результате вся информация выводится в одну строчку:
    //а) используя склеивание;
    //б) используя форматированный вывод;
	//в) используя вывод со знаком $.

    {
        static void Main(string[] args)
        {
            Console.WriteLine("Как вас зовут?");
            string name = Console.ReadLine();
            Console.WriteLine("Какая у вас фамилия?");
            string surname = Console.ReadLine();
            Console.WriteLine("Сколько вам лет?");
            string age = Console.ReadLine();
            Console.WriteLine("Какой у вас рост?");
            string height = Console.ReadLine();
            Console.WriteLine("Какой у вас вес?");
            string weight = Console.ReadLine();
             Console.WriteLine( name + " " + surname + " " + age + " " + height + " " + weight ); // Задание а)
             Console.WriteLine("{0} {1} {2} {3} {4} ", name, surname, age, height, weight);// Задание б)
             Console.WriteLine($"Имя : {name} Фамилия : {surname} Возраст : {age} Рост : {height} Вес : {weight}");
             Console.ReadKey();
            
        }
    }
}
