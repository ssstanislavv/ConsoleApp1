﻿using System;

namespace ConsoleApp1
{
    class Program
    {
        //Этот метод должен возвращать случайное значение
        static int GetRandom()
        {
            //Создание объекта для генерации чисел (с указанием начального значения)
            Random rnd = new Random(245);

            //Получить случайное число 
            int value = rnd.Next();

            //Вернуть полученное значение
            return value;
        }

        static void Main(string[] args)
        {
            //Вывод сгенерированных чисел в консоль
            Console.WriteLine(GetRandom());
            Console.WriteLine(GetRandom());
            Console.WriteLine(GetRandom());
        }
    }
}
