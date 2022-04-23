using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayManager
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Classes
            Console.WriteLine("Width of your array");
            int Width = int.Parse(Console.ReadLine());
            Console.WriteLine("Length of your array");
            int Length = int.Parse(Console.ReadLine());
            Console.WriteLine("Min value of random");
            int MinValue = int.Parse(Console.ReadLine());
            Console.WriteLine("Max value of random");
            int MaxValue = int.Parse(Console.ReadLine());
            ArrayManager arrayManager = new ArrayManager();
            int[,] arr = arrayManager.Create(Width, Length, MinValue, MaxValue);
            Console.WriteLine("Array");
            int[,] PrintArr = arrayManager.PrintArr(arr);
            int max = arrayManager.GetMax(arr);
            int min = arrayManager.GetMin(arr);
            int MaxIndex1 = arrayManager.GetMaxIndex1(arr);
            int MaxIndex2 = arrayManager.GetMaxIndex2(arr);
            int MinIndex1 = arrayManager.GetMinIndex1(arr);
            int MinIndex2 = arrayManager.GetMinIndex2(arr);
            int[,] SwapIndex = arrayManager.SwapIndex(arr, min, max, MaxIndex1,
                MaxIndex2, MinIndex1, MinIndex2);
            Console.WriteLine("Swapped array");
            arrayManager.PrintArr(SwapIndex);
            #endregion
            #region print

            Console.WriteLine("Max value");
            Console.WriteLine(max);
            Console.WriteLine("Min value");
            Console.WriteLine(min);
            Console.WriteLine("Max index");
            Console.WriteLine(MaxIndex1);
            Console.WriteLine(MaxIndex2);
            Console.WriteLine("Min index");
            Console.WriteLine(MinIndex1);
            Console.WriteLine(MinIndex2);

            #endregion
        }
    }
    public class ArrayManager
    {
        public int[,] Create(int width, int length, int min, int max)
        {
            int[,] arr = new int[width, length];
            Random rnd = new Random();
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = rnd.Next(min, max);
                }

            }
            return arr;
        }
        public int[,] PrintArr(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();

            }
            return arr;
        }
        public int GetMax(int[,] arr)
        {
            int max = arr[0, 0];
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i, j] > max)
                        max = arr[i, j];
                }
            }
            return max;
        }
        public int GetMin(int[,] arr)
        {
            int min = arr[0, 0];
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i, j] < min)
                    {
                        min = arr[i, j];
                    }
                }
            }
            return min;
        }
        public int GetMaxIndex1(int[,] arr)
        {
            int MaxIndex1 = 0;
            int MaxIndex2 = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i, j] > arr[MaxIndex1, MaxIndex2])
                    {
                        MaxIndex1 = i;
                        MaxIndex2 = j;
                    }
                }
            }
            return MaxIndex1;
        }
        public int GetMaxIndex2(int[,] arr)
        {
            int MaxIndex1 = 0;
            int MaxIndex2 = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i, j] > arr[MaxIndex1, MaxIndex2])
                    {
                        MaxIndex1 = i;
                        MaxIndex2 = j;
                    }

                }
            }
            return MaxIndex2;
        }
        public int GetMinIndex1(int[,] arr)
        {
            int MinIndex1 = 0;
            int MinIndex2 = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i, j] < arr[MinIndex1, MinIndex2])
                    {
                        MinIndex1 = i;
                        MinIndex2 = j;
                    }

                }
            }
            return MinIndex1;

        }
        public int GetMinIndex2(int[,] arr)
        {
            int MinIndex1 = 0;
            int MinIndex2 = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i, j] < arr[MinIndex1, MinIndex2])
                    {
                        MinIndex1 = i;
                        MinIndex2 = j;
                    }

                }
            }
            return MinIndex2;

        }
        public int[,] SwapIndex(int[,] arr, int min, int max, int MaxIndex1, int MaxIndex2, int MinIndex1, int MinIndex2)
        {
            arr[MinIndex1, MinIndex2] = max;
            arr[MaxIndex1, MaxIndex2] = min;
            return arr;
        }
    }
}

