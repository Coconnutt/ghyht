using System;

namespace ConsoleApp3
{
    class Program
    {
        static void task4()
        {
            int num;

            num = Convert.ToInt16(Console.ReadLine());

            switch (num)
            {
                case 1: Console.WriteLine("Плохо"); break;
                case 2: Console.WriteLine("Неудовлетворительно"); break;
                case 3: Console.WriteLine("Удовлетворительно"); break;
                case 4: Console.WriteLine("Хорошо"); break;
                case 5: Console.WriteLine("Отлично"); break;
                default: Console.WriteLine("Неправильное число"); break;
            }
            Console.ReadKey();
        }

        static void task5()
        {
            double a, b, z;

            Console.Write("Введи число a: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введи число b: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введи число операции(1 - сложение; 2 - вычитание; 3 - уможение; 4 - деление): ");
            z = Convert.ToInt32(Console.ReadLine());


            if (z == 1)
            {
                Console.WriteLine(a + b);
            }
            else if (z == 2)
            {
                Console.WriteLine(a - b);
            }
            else if (z == 3)
            {
                Console.WriteLine(a * b);
            }
            else if (z == 4)
            {
                Console.WriteLine(a / b);
            }
            Console.ReadKey();
        }

        static void task6()
        {
            double a, b;

            Console.Write("Введи двухзначное число: ");
            a = Convert.ToInt32(Console.ReadLine());

            b = a % 10;

            if (b == 1)
            {
                Console.WriteLine("Последняя цифра его квадрата - 1");
            }
            else if (b == 2)
            {
                Console.WriteLine("Последняя цифра его квадрата - 4");
            }
            else if (b == 3)
            {
                Console.WriteLine("Последняя цифра его квадрата - 9");
            }
            else if (b == 4)
            {
                Console.WriteLine("Последняя цифра его квадрата - 6");
            }
            else if (b == 5)
            {
                Console.WriteLine("Последняя цифра его квадрата - 5");
            }
            else if (b == 6)
            {
                Console.WriteLine("Последняя цифра его квадрата - 6");
            }
            else if (b == 7)
            {
                Console.WriteLine("Последняя цифра его квадрата - 9");
            }
            else if (b == 8)
            {
                Console.WriteLine("Последняя цифра его квадрата - 4");
            }
            else if (b == 9)
            {
                Console.WriteLine("Последняя цифра его квадрата - 1");
            }

            Console.ReadKey();
        }
        static void task7()
        {
            double a, b, c, d, q, w;

            Console.Write("Введи число a: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введи число b: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введи число c: ");
            c = Convert.ToInt32(Console.ReadLine());
            
            d = b * b - 4 * a * c;
            if (d == 0)
            {
                Console.WriteLine("1 корень");
                q = -b / (2 * a);
                Console.WriteLine(q);
            }
            else if (d > 0)
            {
                q = -b - Math.Sqrt(d) / (2 * a);
                w = -b + Math.Sqrt(d) / (2 * a);
                Console.WriteLine("2 корня");
                Console.WriteLine(q);
                Console.WriteLine(w);
            }
            else if (d < 0)
            {
                Console.WriteLine("нет корней");
            }
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            task7();
        }
    }
}
