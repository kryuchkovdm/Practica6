using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication29
{
    class Program
    {
        public static double A(int n, double a1, double a2, double a3)
        {

            if (n == 1)
            {
                return a1;
            }
            else if (n == 2)
            {
                return a2;
            }
            else if (n == 3)
            {
                return a3;
            }
            else
            {
                return (A(n - 1, a1, a2, a3) / 2 + A(n - 2, a1, a2, a3) / 2 + A(n - 3, a1, a2, a3) / 2);
            }



        }
        static void Try(out double inputnumber)//проверка правильности ввода числа
        {
            inputnumber = 0;
            bool flag = true;
            while (flag == true)
            {
                try
                {
                    string x = Console.ReadLine();
                    inputnumber = double.Parse(x);
                    flag = false;
                }
                catch
                {
                    Console.WriteLine("Неверное значение! Введите число");
                    flag = true;
                }
            }
        }

        static void Main(string[] args)
        {
            string answer = "yes";


            while (answer == "yes")
            {

                Console.WriteLine("Введите a1");
                Console.Write("a1=");
                double a1;
                Try(out a1);
                Console.WriteLine("Введите a2");
                Console.Write("a2=");
                double a2;
                Try(out a2);
                Console.WriteLine("Введите a3");
                Console.Write("a3=");
                double a3;
                Try(out a3);
                Console.WriteLine("Введите M");
                Console.Write("M=");
                double M;
                Try(out M);
                Console.WriteLine();
                int n = 1;
                if (A(n, a1, a2, a3) <= M)
                {
                    while (A(n, a1, a2, a3) <= M)
                    {
                        Console.Write("{0} ", A(n, a1, a2, a3));
                        n++;
                    }
                }
                else
                {
                    if (n == 1)
                    {
                        Console.WriteLine("Последовательность пуста");
                    }
                    else
                    {
                        Console.WriteLine("Элемент последовательности превысил значение M");
                    }
                }
                Console.WriteLine();
                bool f = true;
                n = 1;
                if (A(n, a1, a2, a3) <= M)
                {
                    while (A(n, a1, a2, a3) <= M)
                    {
                        if (A(n, a1, a2, a3) == M && f)
                        {
                            Console.Write("Элемент под номером {0} равен значению M", n);
                            f = false;
                        }
                        n++;
                    }
                }
                if (f)
                {
                    Console.WriteLine("Равенство не выполняется");
                }
                Console.WriteLine();
                Console.WriteLine("Продолжить? yes/no");
                answer = Console.ReadLine();

            }

        }
    }
}

