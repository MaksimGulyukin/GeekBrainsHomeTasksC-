using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DZ4._2
{
    class Program
    {
        public static string DBLogIn = AppDomain.CurrentDomain.BaseDirectory + "dblogin.txt";
        public static string dbusername = string.Empty;
        public static string dbpassword = string.Empty;
        public static int again = 0;
        public static int re = 0;
        static void Main(string[] args)
        {
            

            do
            {
                string[] db = new string[100];
                Console.WriteLine("Enter the username:");
                string username = Console.ReadLine();
                Console.WriteLine("Enter the password:");
                string password = Console.ReadLine();
                using (StreamReader sr = new StreamReader(DBLogIn))
                    for (int i = 0; i < db.Length; i++)
                        db[i] = sr.ReadLine();
                for (int i = 0; i < db.Length; i++)
                {
                    if (db[i] == null)
                        break;
                    int to = db[i].IndexOf(';');
                    dbusername = db[i].Substring(0, to);
                    dbpassword = db[i].Substring(++to);
                    if (username == dbusername && password == dbpassword)
                    {
                        Console.WriteLine("Hello: " + dbusername);
                        re = 0;
                        break;
                    }
                    else
                        re++;
                }
                if (re++ > 0)
                {
                    again++;
                    Console.WriteLine("Username or password is invalid!Please try again");
                }
            } while (again < 3);
        }
    }
}
