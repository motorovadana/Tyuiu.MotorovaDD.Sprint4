﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.MotorovaDD.Sprint4.Task1.V27.Lib;

namespace Tyuiu.MotorovaDD.Sprint4.Task1.V27
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #4 | Выполнила: Моторова Д. Д. | СМАРТб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Обработка структурных типов                                       *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #27                                                             *");
            Console.WriteLine("* Выполнила: Моторова Дана Дмитриевна | СМАРТб-23-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("*Дан одномерный целочисленный массив на 10 элементов заполненный          *");
            Console.WriteLine("*значениями с клавиатуры в диапазоне от 1 до 9 подсчитать                 *");
            Console.WriteLine(" произведение четных  элементов массива.                                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int len;
            Console.Write("Введите количество элемента массива: ");
            len = Convert.ToInt32(Console.ReadLine());

            int[] numsArray = new int[len];
            for (int i = 0; i <= len - 1; i++)
{
                Console.Write("Введите значение " + i + "элемента массива: ");
                numsArray[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine();
            Console.WriteLine("Массив: ");
            for (int i = 0; i <= len - 1; i++)
{
                Console.Write(numsArray[i] + "\t");
            }
            Console.WriteLine();
            Console.WriteLine();



            Console.WriteLine("**************************************************************************");
            Console.WriteLine(" РЕЗУЛЬТАТ:                                                               ");
            Console.WriteLine("**************************************************************************");

            Console.WriteLine("Cумма четных чисел" + ds.Calculate(numsArray));
            

            Console.ReadKey();
        }
    }
}
