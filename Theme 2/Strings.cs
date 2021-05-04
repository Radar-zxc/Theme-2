using System;
using System.Collections.Generic;
using System.Text;

namespace Theme_2
{
    static class Strings
    {
        //1. Даны переменные 
        //hello = "Привет!"
        //name = "Меня зовут ..."
        //age = "Мне ... лет"
        //Оперируя переменными составить полноценное предложение 
        //всеми возможными способами(форматирование, интерполяция)

        public static void Task1()
        {
            string hello = "Привет!";
            string name = "Меня зовут ";
            string age = "Мне лет.";
            string _name = "Паша";
            string _age = "9";
            char ch = ' ';
            int i = age.IndexOf(ch);
            age = age.Insert(i+1, _age+' ');
            Console.WriteLine($"{hello} {name}{_name}. {age}");
            Console.WriteLine($"{hello} {age} {name}{_name}.");
            Console.WriteLine(hello+' ' + name + _name + '.'+' ' + age);
            Console.WriteLine(hello + ' ' +age  + ' ' + name +_name+ '.');
            string fullName = name + _name + '.';
            Console.WriteLine(String.Format("{0} {2} {1}",hello , fullName,age));
            Console.WriteLine(String.Format("{0} {1} {2}", hello, fullName, age));
            Console.WriteLine(String.Format("{2} {0} {1}", hello, fullName, age));
        }
        // Дан массив строк ["apple", "banana", "orange", "kiwi", "mango"]
         // - Вывести все значения через ", "
          //  - Вывести все значения построчно

        public static void Task2()
        {
            string[] arr = new string[] { "apple", "banana", "orange", "kiwi", "mango" };
            for(int i = 0; i<arr.Length;i++)//вывод через запятую
            {
                Console.Write(arr[i]);
                if (i < arr.Length - 1)
                {
                    Console.Write(',');
                }
                else
                {
                    Console.Write('.');
                }
            }
            Console.WriteLine('\n');
            foreach (string i in arr)// вывод построчно
            {
                Console.WriteLine(i);
            }
        }
        //3. Сравнить две строки и вывести результат сравнения
           // - "привет" и "здравствуйте"
           // - "двацдать" и "двенадцать"
            //- "синус" и "синусоида"
            //- "14" и "81"

        public static void Task3()
        {
            ResultCheck(String.Compare("привет", "здравствуйте"));
            ResultCheck(String.Compare("двацдать" , "двенадцать"));
            ResultCheck(String.Compare("синус" , "синусоида"));
            ResultCheck(String.Compare("14" , "81"));

            static void ResultCheck(int result)
            {
                if (result <0)
                {
                    Console.WriteLine("Первая строка стоит по алфавиту выше второй");
                }else if (result == 0)
                {
                    Console.WriteLine("Строки одинаковы");
                }
                else
                {
                    Console.WriteLine("Вторая строка стоит по алфавиту выше первой");
                }
            }
        }
        //Найти в строке индекс первого вхождения буквы "о"
        //- Хорошо в лесу...
        //- Эх, дороги, пыль да туман
        //- Семнадцать вариантов решения

        public static void Task4()
        {
            string str1 = "- Хорошо в лесу...";
            string str2 = "- Эх, дороги, пыль да туман";
            string str3 = "-Семнадцать вариантов решения";
            Console.WriteLine(str1.IndexOf("о"));
            Console.WriteLine(str2.IndexOf('о'));
            Console.WriteLine(str3.IndexOf('о'));
        }
        //Найти в строке индекс последнего вхождения буквы "у"
        //- Где такое интересное место?
        //- У меня дома есть ноутбук.
        //- Винтажный стул

        public static void Task5()
        {
            string str1 = "- Где такое интересное место?";
            string str2 = "- У меня дома есть ноутбук.";
            string str3 = "- Винтажный стул";
            Console.WriteLine(str1.LastIndexOf("у"));
            Console.WriteLine(str2.LastIndexOf("у"));
            Console.WriteLine(str3.LastIndexOf("у"));
        }
        //Вставить в строку другую строку
        //- Какой ... день
        //- замечательный

        public static void Task6()
        {
            string str1 = "Какой день";
            string str2 = "замечательный";
            int i = str1.IndexOf(' ');
            str1 = str1.Insert(i,' '+str2);
            Console.WriteLine(str1);
        }
        // Заменить в строке слово "магазин" на "парк" 
        //- Привет, я иду в магазин

        public static void Task7()
        {
            string str1 = "- Привет, я иду в магазин";
            string str2 = "парк";
            str1 = str1.Replace("магазин", str2);
            Console.WriteLine(str1);
        }
        //Удалить из строки слово "большого"
        //- Сегодня в зоопарке я видел большого жирафа

        public static void Task8()
        {
            string str1 = "- Сегодня в зоопарке я видел большого жирафа";
            str1 = str1.Replace("большого ", "");
            Console.WriteLine(str1);
        }
        //Привести предложение "ПрыгаЮщие БуквЫ" к нижнему, а затем к верхнему регистру
        public static void Task9()
        {
            string str1 = "ПрыгаЮщие БуквЫ";
            Console.WriteLine(str1);
            Console.WriteLine(str1.ToLower());
            Console.WriteLine(str1.ToUpper());
        }
        // Разделить строку на элементы массива
        //- Первый рабочий день прошел на ура

        public static void Task10()
        {
            string str1 = "Первый рабочий день прошел на ура";
            string[] words = str1.Split(new char[] { ' '}, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < words.Length; i++)
            {
                Console.WriteLine(words[i]);
            }
            InputCheck();
        }
        public static void InputCheck()
        {
            bool check;
            do
            {
                try
                {
                    int n = Convert.ToInt32(Console.ReadLine());
                    check = true;
                }
                catch
                {
                    Console.WriteLine("aboba");
                    check = false;
                }
            } while (!check);
        }
    }
}
