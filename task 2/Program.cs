using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task 1 kalashnick
            
            int num1 = 53;
            int num2 = 47;
            int num3 = 98;

            int min2;
            int min3;

            if (num1 < num2)
            {
                min2 = num1;
            }
            else 
            {
                min2 = num2;
            }
            if ( min2 < num3)
            {
                min3 = min2;
            }
            else
            {
                min3 = num3;
            }

            Console.WriteLine($"Минимальное число равно: {min3}");

            Console.ReadLine();

            #endregion    

            #region Task 2 Kalashnick
                
            int n = int.Parse(Console.ReadLine());

            n = n / 10;

            Console.WriteLine("Остаток:{0}", n);
 
            Console.ReadKey();

            #endregion

            
           #region Task 3 Kalashnick

            int sum = 0;
            int num = 0;
 
            do
              {
                num = int.Parse(Console.ReadLine());
                if (num > 0 && num % 2 == 1)
                sum += num;
 
            } while (num != 0);
 
                Console.WriteLine("Sum: " + sum);
                
           #endregion 

            

            #region Task 4 Kalashnick

            string login = "root";
            string password = "GeekBrains";
            
            int count = 0;
            do
            {
                Console.WriteLine("Введите логин: ");
                string checkLogin = Console.ReadLine();
 
                Console.WriteLine("Введите пароль: ");
                string checkPassword = Console.ReadLine();
 
 
                if (login == checkLogin && password == checkPassword)
                {
                   
                    Console.WriteLine("Добро пожаловать");
                    Console.ReadLine();
                    break;
                }
                    Console.WriteLine("Неверно введен логин или пароль");
                    Console.ReadLine();
                    ++count;
            } while (count < 3);

             #endregion
            
            #region Task 5 Kalashnick

            double imt = 27.5;

            if ( imt <= 19.5)
            {
                Console.WriteLine("Вам необходимо поправиться");
            }
            else if (imt > 19.5 && imt < 27)
            {
                Console.WriteLine("У вас нормальный вес");
            }
            if (imt >= 27)
            {
                Console.WriteLine("Вам необходимо похудеть");
            }
          


            Console.ReadLine();

            #endregion

            
        }
    }
}
