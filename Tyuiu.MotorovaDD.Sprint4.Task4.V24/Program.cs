﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.MotorovaDD.Sprint4.Task4.V24.Lib;

namespace Tyuiu.MotorovaDD.Sprint4.Task4.V24
{
    class Program
    {
        private static object ds;

        static void Main(string[] args)
        {
            Console.Title = "Спринт #4| Выполнила :  Моторова Д.Д. | СМАРТб-23-1";
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* Спринт #4                                                                  *");
            Console.WriteLine("* Тема:    Двумерные массивы. (ввод с клавиатуры)                            *");
            Console.WriteLine("* Задание #5                                                                 *");
            Console.WriteLine("* Вариант #8                                                                 *");
            Console.WriteLine("* Выполнил :  Моторова Дана Дмитриевна | СМАРТб-23-1                         *");        
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                   *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный случайными*");
            Console.WriteLine("* значениями в диапазоне от -3 до 4. Заменить отрицательные элементы на 0.   *");
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                           *");
            Console.WriteLine("******************************************************************************");

            Console.Write("Введите количество строк в массиве: ");
            int rows = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите количество столбцов в массиве: ");
            int columns = Convert.ToInt32(Console.ReadLine());

            int[,] mtrx = new int[rows, columns];

            Console.WriteLine("******************************************************************************");

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    mtrx[i, j] = rnd(-3, 5);
                }
            }

            Console.WriteLine("\nМассив: ");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{mtrx[i, j]} \t");
                }

                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* Массив в котором значения <0 заменены на 0:                                *");
            Console.WriteLine("******************************************************************************");

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{mtrx[i, j]} \t");
                }

                Console.WriteLine();
            }

            Console.ReadKey();
        }

        private static int rnd(int v1, int v2)
        {
            throw new NotImplementedException();
        }
    }
}
        
                  