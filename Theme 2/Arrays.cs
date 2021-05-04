﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Theme_2
{
    class Arrays
    {
        //Ввести n целых чисел (n задается пользователем). Какая цифра встречается чаще других? 
        //Если таких цифр несколько – вывести ту из них, 
        //которая обозначает наибольшее число, а также сколько раз она встретилась.
        public static void Task1()
        {
            Console.WriteLine("Введите количество чисел");
            int n = InputCheck();
            int maxCount = 0, maxDigit = -1;
            int[] numbers = new int[10];
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = InputCheck();
                int copy = arr[i];
                while (copy != 0)
                {
                    numbers[copy % 10]++;
                    copy = copy / 10;
                }
            }
            for (int i = 0; i < 10; i++)
            {
                if (numbers[i] >= maxCount && i >= maxDigit)
                {
                    maxCount = numbers[i];
                    maxDigit = i;
                }
            }
            Console.WriteLine($"Самая частая цифра: {maxDigit}");
            Console.WriteLine($"Количество появлений самой частой цифры {maxCount}");
        }
        //Ввести массив целых чисел. Длина массива задается пользователем. 
        //Определить, упорядочен ли он по возрастанию. По убыванию?
        public static void Task2()
        {
            Console.WriteLine("Введите количество чисел");
            int n = InputCheck();
            bool ascendingOrder = true, descendingOrder = true;
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = InputCheck();
            }

            int j = 1;
            int x = arr[0];
            while (ascendingOrder && j < n) //проверка возрастания
            {
                if (arr[j] < x)
                {
                    ascendingOrder = false;
                }
                else
                {
                    x = arr[j];
                }
                j++;
            }
            j = 1;
            x = arr[0];
            while (descendingOrder && j < n) // проверка убывания
            {
                if (arr[j] > x)
                {
                    descendingOrder = false;
                }
                else
                {
                    x = arr[j];
                }
                j++;
            }
            if (descendingOrder && ascendingOrder)
            {
                Console.WriteLine("Массив состоит из одинаковых чисел");
            } else if (!descendingOrder && !ascendingOrder)
            {
                Console.WriteLine("Массив неупорядоченный");
            } else if (!descendingOrder && ascendingOrder)
            {
                Console.WriteLine("Массив упорядочен по возрастанию");
            }
            else if (descendingOrder && !ascendingOrder)
            {
                Console.WriteLine("Массив упорядочен по убыванию");
            }
        }
        //Ввести массив целых чисел в диапазоне [-100,100]. Длина массива задается пользователем. 
        //а) Найти минимальный элемент
        //б) Найти максимальный элемент
        //в) найти минимальное нечетное
        //г) найти минимальное четное
        //д) найти минимальный и максимальный элементы и поменять их местами

        public static void Task3()
        {
            Console.WriteLine("Введите количество чисел");
            int n = InputCheck();
            Console.WriteLine("Введите значения от [-100 до 100]");
            int[] arr = new int[n];
            int x;
            for (int i = 0; i < n; i++)
            {
                x = InputCheck();
                while (x > 100 || x < -100)
                {
                    Console.WriteLine("Ошибка ввода ,введите значение от [-100 до 100]");
                    x = InputCheck();
                }
                arr[i] = x;
            }
            int min = arr[0];
            for (int i = 1; i < n; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }
            Console.WriteLine($"Минимальный элемент равен {min}");
            int max = arr[0];
            for (int i = 1; i < n; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            Console.WriteLine($"Максимальный элемент равен {max}");
            int minOdd = 101;
            for (int i = 0; i < n; i++)
            {
                if (arr[i] % 2 != 0 && arr[i] < minOdd)
                {
                    minOdd = arr[i];
                }
            }
            if (minOdd!=101) Console.WriteLine($"Минимальный нечетный элемент равен {minOdd}");
            else
            {
                Console.WriteLine("Нечетных элементов нет");
            }
            int minEven = 101;
            for (int i = 0; i < n; i++)
            {
                if (arr[i] % 2 == 0 && arr[i] < minEven)
                {
                    minEven = arr[i];
                }
            }
            if (minEven!=101) Console.WriteLine($"Минимальный четный элемент равен {minEven}"); 
            else
            {
                Console.WriteLine("Четных элементов нет");
            }
            int[] arrMax = new int[n / 2];
            int[] arrMin = new int[n / 2];
            arrMax[0] = -1;
            arrMin[0] = -1;
            max = -101;
            min = 101;
            int j = 0, k = 0;
            for (int i = 0; i < n; i++)
            {
                if (arr[i] >= max)
                {
                    max = arr[i];
                }
                if (arr[i] <= min)
                {
                    min = arr[i];
                }
            }
            for (int i = 0; i < n; i++)
            {
                if (arr[i] == max)
                {
                    arrMax[j] = i;
                    j++;
                } else if (arr[i] == min)
                {
                    arrMin[k] = i;
                    k++;
                }
            }
            int length = arrMax.Length;
            for (int i = 0; i < length; i++)
            {
                Swap(arr, arrMax[i], arrMin[i]);
            }
            Print(arr, n);
        }
        // Ввести два упорядоченных массива (контроль за корректностью ввода). 
        // Слить их в один упорядоченный массив без использования сортировки.
        public static void Task4()
        {
            Console.WriteLine("Введите количество чисел в первом массиве");
            int n = InputCheck();
            Console.WriteLine("Введите количество чисел во втором массиве");
            int p = InputCheck();
            int[] arr1 = new int[n];
            int[] arr2 = new int[p];
            for (int i = 0; i < n; i++)
            {
                arr1[i] = InputCheck();
            }
            for (int i = 0; i < p; i++)
            {
                arr2[i] = InputCheck();
            }
            int l = n + p;
            int[] arr3 = new int[l];
            int j = 0, k = 0;
            for (int i =  0; i< l; i++)
            {
                if (j < n && k < p && arr1[j] < arr2[k])
                {
                    arr3[i] = arr1[j];
                    j++;
                }
                else if(j < n || k < p)
                {
                    arr3[i] = arr2[k];
                    k++;
                }
            }
            Print(arr3, l);
        }
        //Считать из файла массив целых чисел. Упорядочить по возрастанию. Вывести обратно в файл.
        public static void Task5()
        {
            int[] arr;
            using (var sr = new StreamReader("inp.txt"))
            {
                arr = sr.ReadToEnd().Split().Select(int.Parse).ToArray();
                sr.Close();
            }
            Print(arr, arr.Length);
            int temp;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            Print(arr, arr.Length);
            using (StreamWriter sw = new StreamWriter("inp.txt", false,Encoding.Default))
            { 
                foreach (int i in arr)
                {
                    sw.Write($"{i} ");
                }
                sw.Close();
            }
        }
        // Считать из файла массив целых чисел. Упорядочить по убыванию. Вывести обратно в файл.
        public static void Task6()
        {
            int[] arr;
            using (var sr = new StreamReader("inp1.txt"))
            {
                arr = sr.ReadToEnd().Split().Select(int.Parse).ToArray();
                sr.Close();
            }
            Print(arr, arr.Length);
            int temp;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] < arr[j])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            Print(arr, arr.Length);
            using (StreamWriter sw = new StreamWriter("inp1.txt", false, Encoding.Default))
            {
                foreach (int i in arr)
                {
                    sw.Write($"{i} ");
                }
                sw.Close();
            }
        }
        //Сдвинуть массив [1..n] циклически влево (вправо) на m позиций.
        //«Падающие» элементы должны уходить в хвост (в голову).
        public static void Task7()
        {
            Console.WriteLine("Введите конечное число ");
            int n = InputCheck();
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = i+1;
            }
            Print(arr, n);
            Console.WriteLine("Введите количество сдвига позиций ");
            int tmp, m = InputCheck();
            m = m % n;
            for (int i = 0; i<m; i++) //сдвиг вправо
            {
                tmp = arr[n-1];
                for (int j = n-2; j>=0;j--)
                {
                    arr[j + 1] = arr[j];
                }
                arr[0] = tmp;
            }
            Print(arr, n);
            for (int i = 0; i < m; i++) //сдвиг влево
            {
                tmp = arr[0];
                for (int j = 1; j < n; j++)
                {
                    arr[j-1] = arr[j];
                }
                arr[n-1] = tmp;
            }
            Print(arr, n);
        }
        static void Print(int[] arr, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write($"{arr[i]} ");
            }
            Console.WriteLine();
        }
        static void Swap(int[] arr, int pos1, int pos2)
        {
            int temp = arr[pos1];
            arr[pos1] = arr[pos2];
            arr[pos2] = temp;
        }
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
    }
}

