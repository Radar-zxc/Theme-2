using System;
using System.IO;
namespace Theme_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task1();
            //Task2();
            //Task3();
            //Task4();
            //Task5();
            //Task6();
            //Task7();
            //Task8();
            //Task9();
            //Task10();
            //Task11();
            //Task12();
            //Arrays.Task1();
            //Arrays.Task2();
            //Arrays.Task3();
            //Arrays.Task4();
            //Arrays.Task5();
            //Arrays.Task6();
            Arrays.Task7();
            //Strings.Task1();
            //Strings.Task2();
            //Strings.Task3();
            //Strings.Task4();
            //Strings.Task5();
            //Strings.Task6();
            //Strings.Task7();
            //Strings.Task8();
            //Strings.Task9();
            //Strings.Task10();
        }
        //Ввести трехзначное число. Посчитать сумму цифр, вывести на экран.
        public static void Task1()
        {
            Console.WriteLine("Введите трехзначное число");
            int x;
            do
            {
                x = Utilities.InputCheck(); 
                if (Math.Abs(x) < 100 || Math.Abs(x) > 999)
                {
                    Console.WriteLine("Число не трехзначное, введите новое число");
                }
            } while (Math.Abs(x) < 100 || Math.Abs(x) > 999);
            int sum = 0;
            while (x != 0)
            {
                sum = Math.Abs(x % 10) + sum;
                x = x / 10;
            }
            Console.WriteLine($"Сумма цифр равна {sum}");
        }
        //Вводить числа, пока не будет введен ноль. Вывести число с максимальной суммой цифр в нем
        public static void Task2()
        {
            int x;
            int max = 0;
            int sumMax = 0;
            int sumCurrent = 0;
            int copy;
            Console.WriteLine("Введите числа, после ввода цифры 0 ввод будет завершен");
            do
            {
                x = Utilities.InputCheck();
                copy = x;
                while (copy != 0)
                {
                    sumCurrent = Math.Abs(copy % 10) + sumCurrent;
                    copy = copy / 10;
                }
                if (sumMax < sumCurrent)
                {
                    sumMax = sumCurrent;
                    max = x;
                    sumCurrent = 0;
                }
            } while (x != 0);
            Console.WriteLine($"Число с максимальной суммой цифр {max}");
        }
        //Ввести n чисел (n задается пользователем). Посчитать сумму трех первых нечетных.
        public static void Task3()
        {
            Console.WriteLine("Введите количество чисел");
            int n = Utilities.CountCheck();
            int sum = 0;
            int x;
            int count = 0;
            int i = 0;
            if (n != 0)
            {
                Console.WriteLine("Введите числа");
            }
            while (i < n)
            {
                x = Utilities.InputCheck();
                if (x % 2 != 0 && count < 3)
                {
                    sum = sum + x; 
                    count++;       
                }
                i++;
            }
            if (i == n && count < 3 && count != 0)
            {
                Console.WriteLine($"В списке чисел было меньше трех нечетных, вывод суммы имеющихся нечетных чисел : {sum}");
            }
            else if (count == 0)
            {
                Console.WriteLine("В списке чисел нет нечетных чисел");
            }
            else
            {
                Console.WriteLine($"Сумма требуемых чисел равна: {sum}");
            }
        }
        //Ввести n чисел (n задается пользователем). Посчитать сумму трех последних нечетных.
        public static void Task4()
        {
            Console.WriteLine("Введите количество чисел");
            int n = Utilities.CountCheck();
            int sum = 0;
            int x;
            int i = 0;
            int last = 0;
            int mid = 0;
            int first = 0;
            if (n != 0)
            {
                Console.WriteLine("Введите числа");
            }
            while (i < n)
            {
                x = Utilities.InputCheck();
                if (last != 0 && x % 2 != 0)
                {
                    sum = sum - first + x;
                    first = mid;
                    mid = last;
                    last = x; 
                }
                else if (x % 2 != 0)
                {
                    if (first == 0)
                    {
                        sum = sum + x;
                        first = x;
                    }
                    else
                    if (mid == 0)
                    {
                        sum = sum + x;
                        mid = x;
                    }
                    else
                    if (last == 0)
                    {
                        sum = sum + x;
                        last = x;
                    }
                }
                i++;
            }
            if (last != 0)
            {
                Console.WriteLine($"Сумма требуемых чисел равна: {sum}");
            }
            else if (first == 0)
            {
                Console.WriteLine("В списке чисел нет нечетных чисел");
            }
            else
            {
                Console.WriteLine($"В списке чисел было меньше трех нечетных, вывод суммы имеющихся нечетных чисел : {sum}");
            }
        }
        //Ввести m и n, где m и n - два целых числа не больше 20. Звездочками на экране нарисовать
        public static void Task5()
        {
            Console.WriteLine("Введите 2 числа m и n отражающие размерность фигуры");
            int n = Utilities.CountCheck();
            int m = Utilities.CountCheck();
            PrintRectangle(n, m);
            Console.WriteLine();
            PrintTriangleLeftDown(n);
            Console.WriteLine();
            PrintTriangleRightDown(n);
            Console.WriteLine();
            PrintTriangleLeftUp(n);
            Console.WriteLine();
            PrintTriangleRightUp(n);
            Console.WriteLine();
            PrintRhombus(n);
            Console.WriteLine();
            static void PrintRectangle(int n, int m)
            {
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
            }
            static void PrintTriangleLeftDown(int n)
            {
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j <= i; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
            }
            static void PrintTriangleRightDown(int n)
            {
                int j;
                for (int i = 0; i < n; i++)
                {
                    for (j = 0; j < n - i - 1; j++)
                    {
                        Console.Write(" ");
                    }
                    for (int k = j; k < n; k++)
                    {
                        Console.Write("*");
                    }
                    Console.Write('\n');
                }
            }
            static void PrintTriangleRightUp(int n)
            {
                int j;
                for (int i = 0; i < n; i++)
                {
                    for (j = 0; j < i; j++)
                    {
                        Console.Write(" ");
                    }
                    for (int k = j; j < n; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
            }
            static void PrintTriangleLeftUp(int n)
            {
                int j;
                for (int i = 0; i < n; i++)
                {
                    for (j = 0; j < n - i; j++)
                    {
                        Console.Write("*");
                    }
                    for (int k = j; j < n; j++)
                    {
                        Console.Write(" ");
                    }
                    Console.WriteLine();
                }
            }
            static void PrintRhombus(int k)
            {
                int i, j, n = 2 * k, mid = n / 2;
                for (i = 0; i < n - 1; i++)
                {
                    for (j = 0; j < n; j++)
                    {
                        if (i < mid)
                        {
                            if (j >= mid - i && j <= mid + i)
                                Console.Write("*");
                            else
                                Console.Write(" ");
                        }
                        else
                        {
                            if (j >= mid + i - n + 2 && j <= mid - i + n - 2)
                                Console.Write("*");
                            else
                                Console.Write(" ");
                        }
                    }
                    Console.Write('\n');
                }
            }
        }
        //Посчитать сумму ряда
        //а) 1 + 2 + 3 + .................. + 50
        //     б)  2+4+6+8+10 + .....  +50
        //    в)  1+3+5+7+9....

        public static void Task6()
        {
            TaskA();
            TaskB();
            TaskC();
            static void TaskA()
            {
                int sum = 0;
                for (int i = 1; i <= 50; i++)
                {
                    sum = sum + i;
                }
                Console.WriteLine($"Сумма равна {sum}");
            }
            static void TaskB()
            {
                int sum = 0;
                for (int i = 2; i <= 50; i = i + 2)
                {
                    sum = sum + i;
                }
                Console.WriteLine($"Сумма равна {sum}");
            }
            static void TaskC()
            {
                Console.WriteLine("Введите конечное положительное нечетное число ряда ");
                int n = Utilities.CountCheck();
                while (Math.Abs(n) % 2 == 0)
                {
                    Console.WriteLine("Ошибка ввода , повторите попытку ");
                    n = Utilities.CountCheck();
                }
                int sum = 0;
                for (int i = 1; i <= n; i = i + 2)
                {
                    sum = sum + i;
                }
                Console.WriteLine($"Сумма равна {sum}");
            }
        }
        //Посчитать сумму  6 + 10 + 14 + ................... + 46. Сколько слагаемых?
        public static void Task7()
        {
            int sum = 0;
            int count = 0;
            for (int i = 6; i <= 46; i = i + 4)
            {
                sum = sum + i;
                count++;
            }
            Console.WriteLine($"Сумма равна {sum}");
            Console.WriteLine($"Количество элементов равно {count}");
        }
        //Посчитать сумму  6 + 10 + 14 + ...................   , всего 10 слагаемых.
        public static void Task8()
        {
            int sum = 0;
            int x = 6;
            for (int i = 0; i < 10; i++)
            {
                sum = sum + x;
                x = x + 4;
            }
            Console.WriteLine($"Сумма равна {sum}");
        }
        //Посчитать сумму 1+2+4+8+16+....., всего 11 слагаемых.
        public static void Task9()
        {
            int sum = 0;
            int x = 1;
            for (int i = 0; i < 11; i++)
            {
                sum = sum + x;
                x = x * 2;
            }
            Console.WriteLine($"Сумма равна {sum}");
        }
        //Посчитать сумму  6 + 10 + 14 + ..................., 
        //Остановиться, когда сумма превысит 100. Сколько слагаемых?
        public static void Task10()
        {
            int sum = 0;
            int x = 6;
            int count = 0;
            while (sum <= 100)
            {
                sum = sum + x;
                x = x + 4;
                count++;
            }
            Console.WriteLine($"Сумма равна {sum}");
            Console.WriteLine($"Количество элементов равно {count}");
        }
        //Посчитать сумму  6 + 10 + 14 + ..................., 
        //последнюю, которая еще не превышает 100. Сколько слагаемых?
        public static void Task11()
        {
            bool flag = true;
            int sum = 0;
            int x = 6;
            int count = 0;
            while (flag)
            {
                if (sum + x < 100)
                {
                    sum = sum + x;
                    x = x + 4;
                    count++;
                }
                else flag = false;
            }
            Console.WriteLine($"Сумма равна {sum}");
            Console.WriteLine($"Количество элементов равно {count}");
        }
        //Посчитать сумму первых n чисел Фиббоначи: 1 + 1 + 2 + 3 + 5 + 8 +  13 + … n задается пользователем
        public static void Task12()
        {
            int n = Utilities.CountCheck();
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum = sum + Number(i);
            }
            Console.WriteLine(sum);

            static int Number(int n)
            {
                int number = 0;
                if (n <= 2)
                {
                    number = 1;
                }
                else
                {
                    number = Number(n - 1) + Number(n - 2);
                }
                return number;
            }
        }
    }
}
