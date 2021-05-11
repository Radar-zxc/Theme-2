using System;
using System.Collections.Generic;
using System.Text;

namespace Theme_2
{
    static class Utilities
    {
        public static int InputCheck()
        {
            bool check;
            int n = 0;
            do
            {
                try
                {
                    n = Convert.ToInt32(Console.ReadLine());
                    check = true;
                }
                catch
                {
                    Console.WriteLine("Некорректный ввод");
                    check = false;
                }
            } while (!check);
            return n;
        }
        public static int CountCheck()
        {
            int n = -1;
            do
            {
                n = InputCheck();
                if (n < 0)
                {
                    Console.WriteLine("Ошибка ввода, введите неотрицательное число");
                }
            } while (n <0);
            return n;
        }
    }
}
