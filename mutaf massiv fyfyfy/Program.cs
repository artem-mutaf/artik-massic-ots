﻿using System;

namespace mutaf_massiv_fyfyfy
{
    class Program
    {
        static void Main(string[] args)
        {
            //Первый способ 
            //int[] array = { -8, 6, 0, 11, 4, -4, 5 };
            //for(int i = 0;i<array.Length-1;i++)
            //{
            //    for(int j=i +1;j<array.Length;j++)
            //    {
            //        if (array[i] > array[j])
            //        {
            //            int p = array[i];
            //            array[i] = array[j];
            //            array[j] = p;
            //        }
            //    }
            //}
            //for(int i = 0; i < array.Length - 1; i++)
            //{
            //    Console.WriteLine($"array[{i}]={array[i]}");
            //}
            int[] array = { -8, 6, 0, 11, 4, -4, 5 };

            Array.Sort(array);
            foreach(int elem in array)
            {
                Console.WriteLine($"{elem\t}");
            }
            Array.Reverse(array);
            Console.ReadKey();
        }
    }
}
