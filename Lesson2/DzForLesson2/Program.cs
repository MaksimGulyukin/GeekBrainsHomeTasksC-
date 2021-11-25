using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DzForLesson2
{
    class Program
    {
        //Гулюкин
        //Написать метод, возвращающий минимальное из трёх чисел.

        static void Main(string[] args)
        {
            Console.WriteLine("Введите число а : ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число b : ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число c : ");
            int c = Convert.ToInt32(Console.ReadLine());
            if (a < b & a < c)
            {
                Console.WriteLine("Минимальное число : " + a);
            }
            else if (b < a & b < c)
            {
                Console.WriteLine("Минимальное число : " + b);
            } else
            {
                Console.WriteLine("Минимальное число : " + c);
            }
            Console.ReadKey();
            Cifri(args);
            Summ(args);
            Login(args);
        }

        //Гулюкин
        //Написать метод подсчета количества цифр числа.
       static void Cifri(string [] args)
        {

            Console.WriteLine("Введите число : ");
            int a = Convert.ToInt32(Console.ReadLine());
            int sum = (int)Math.Log10(a) + 1;
            Console.WriteLine("Количество цифр числа : " + sum);
            Console.ReadKey();
        }

        //Гулюкин
        //С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел.
        static void Summ(string [] args)
        {

            int summa = 0;
            int cifra = 0;

            do
            {
                Console.WriteLine("Введите число : ");
                cifra = int.Parse(Console.ReadLine());
                if (cifra > 0 && cifra % 2 == 1)
                    summa += cifra;
            } while (cifra != 0);
            Console.WriteLine("Сумма всех нечетных положительных чисел : " + summa);
            Console.ReadKey();

        }

        //Гулюкин
        //Реализовать метод проверки логина и пароля. На вход метода подается логин и пароль.
        //На выходе истина, если прошел авторизацию, и ложь, если не прошел (Логин: root, Password: GeekBrains).
        //Используя метод проверки логина и пароля, написать программу: пользователь вводит логин и пароль, программа пропускает его дальше или не пропускает.
        //С помощью цикла do while ограничить ввод пароля тремя попытками.

        static void Login(string [] args)
        {
            string login = "root";
            string password = "GeekBrains";
            int popitki = 0;

            do
            {
               
                Console.WriteLine("Введите логин : ");
                string checklogin = Console.ReadLine();
                Console.WriteLine("Введите пароль : ");
                string checkpassword = Console.ReadLine();
                if (login == checklogin && password == checkpassword)
                {
                    Console.WriteLine("Добро пожаловать!");
                    Console.ReadKey();
                    break;
                }
                Console.WriteLine("Неверно введен логин или пароль!");
                Console.ReadKey();
                popitki++;

            } while (popitki < 3);

        }



    }

}
