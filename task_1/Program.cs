using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region task 1 Anton Kalashnick

            Console.WriteLine("Введите ваше имя");
            String name = Console.ReadLine();
            Console.WriteLine("Введите вашу фамилию");
            String surname = Console.ReadLine();
            Console.WriteLine("Введите ваш возраст");
            String age = Console.ReadLine();
            Console.WriteLine("Введите ваш рост");
            String height = Console.ReadLine();
            Console.WriteLine("Введите ваш вес");
            String weight = Console.ReadLine();


            Console.WriteLine("Ваше имя " + name + ", " + "Ваша фамилия " + surname + ", " + "Ваш возраст " + age + ", " + "Ваш рост " + height + ", " + "Ваш вес " + weight);

            Console.WriteLine("Ваше имя {0}, Ваша фамилия {1}, Ваш возраст {2}, Ваш рост {3}, Ваш вес {4}", name, surname, age, height, weight);

            Console.WriteLine($"Ваше имя {name}, Ваша фамилия {surname}, Ваш возраст {age}, Ваш рост {height}, Ваш вес {weight}");

            Console.ReadLine();

            #endregion

            #region task 2 Anton Kalashnick

            Console.WriteLine("Введите ваш рост: ");
            double input1 = Double.Parse(Console.ReadLine());
            Console.WriteLine("И пожалуйста еще вес: ");
            double input2 = Double.Parse(Console.ReadLine());

            double number1;
            double number2;

            number1 = Convert.ToDouble(input1);
            number2 = Convert.ToDouble(input2);

            double number3 = number1 / (number2 * number2);

            Console.WriteLine("Ваш индекс массы тела: " + number3);

            Console.ReadLine();

            #endregion

            #region task 3 Anton Kalashnick

            Console.WriteLine("Введите точку координат X1");
            double x1 = Double.Parse(Console.ReadLine());
            Console.WriteLine("Введите точку координат Y1");
            double y1 = Double.Parse(Console.ReadLine());
            Console.WriteLine("Введите точку координат X2");
            double x2 = Double.Parse(Console.ReadLine());
            Console.WriteLine("Введите точку координат Y2");
            double y2 = Double.Parse(Console.ReadLine());
            double dist = 0;

            //dist = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

            //Console.WriteLine("Расстояния между точками {0}", dist);

            Console.ReadLine();

            static double Distance = (double x1, double y1, double x2, double y2){

                double R = Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2);
                return R;
            }









            #endregion

            #region task 4 Anton Kalashnick

            // С использованием третьей переменной

            int a = 7;
            int b = 9;

            int tmp;

            tmp = a;
            a = b;
            b = tmp;

            // Без использования третьей переменной

            int a = 7;
            int b = 9;

            b = a + b;
            a = b - a;
            b = b - a;

            a = 9;
            b = 7;



            #endregion




        }
    }
}
