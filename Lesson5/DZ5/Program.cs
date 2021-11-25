using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace DZ5
{
    class Program
    //Гулюкин
    //1. Создать программу, которая будет проверять корректность ввода логина. Корректным логином будет строка от 2 до 10 символов, содержащая только буквы латинского алфавита или цифры, при этом цифра не может быть первой:
    //а) без использования регулярных выражений;
    //б) ** с использованием регулярных выражений.
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Придумайте логин, логин должен состоять только из букв латинского алфавита и цифр, но цифра не может быть первой :");
            string login = Console.ReadLine();
            byte[] bytes = new byte[192];
            int kol = 0;
            for (int i = 0; i < 47; i++)
            {
                bytes[kol] = (byte)i;
                kol++;
            }
            for (int i = 58; i < 64; i++)
            {
                bytes[kol] = (byte)i;
                kol++;
            }
            for (int i = 91; i < 96; i++)
            {
                bytes[kol] = (byte)i;
                kol++;
            }
            for (int i = 123; i < 255; i++)
            {
                bytes[kol] = (byte)i;
                kol++;
            }

            char[] chars = System.Text.Encoding.ASCII.GetChars(bytes);

            bool flag = false;

            foreach (var item in chars)
            {
                for (int i = 0; i < login.Length; i++)
                {
                    if (login[i] == item)
                    {
                        flag = true;
                    }
                }
            }


            if (login.Length >= 2 && login.Length <= 10 && Char.IsDigit((char)login[0]) == false && flag == false)
                Console.WriteLine("Логин - {0} корректен", login);
            else
                Console.WriteLine("Логин не корректен");
            Console.ReadKey();
            Two(args);
        }

        static void Two(string[] args)
        {
            Console.WriteLine("Придумайте логин, логин должен состоять только из букв латинского алфавита и цифр, но цифра не может быть первой :");
            Regex login_regex = new Regex("^[a-zA-Zа-яА-Я][a-zA-Zа-яА-Я0-9]{2,9}$");
            string login = Console.ReadLine();

            if (login_regex.Match(login).Success)
            {
                Console.WriteLine("Некорректный логин!");
            }
            else
            {
                Console.WriteLine("Логин подходит!");
            }
            Console.ReadKey();
        }

    }
   
}
