using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    namespace Lab6_OOP
    {
        class Program
        {
            static void shellSort(int[] arr, int n)
            {
                int i, j, pos, temp;
                pos = 3;
                while (pos > 0)
                {
                    for (i = 0; i < n; i++)
                    {
                        j = i;
                        temp = arr[i];
                        while ((j >= pos) && (arr[j - pos] > temp))
                        {
                            arr[j] = arr[j - pos];
                            j = j - pos;
                        }
                        arr[j] = temp;
                    }
                    if (pos / 2 != 0)
                        pos = pos / 2;
                    else if (pos == 1)
                        pos = 0;
                    else
                        pos = 1;
                }
            }
            static void Main(string[] args)
            {
                int[] myArray = new int[7];
                Random rand = new Random();

                for (int x = 0; x < myArray.Length; x++)
                {
                    myArray[x] = rand.Next(20);
                    Console.WriteLine("Array element value: " + x + " = " + myArray[x]);
                }
                int n = myArray.Length;
                int i;
                Console.WriteLine("Shell Sort");
                Console.Write("Initial array is: ");
                for (i = 0; i < n; i++)
                {
                    Console.Write(myArray[i] + " ");
                }
                shellSort(myArray, n);
                Console.Write("\nSorted Array is: ");
                for (i = 0; i < n; i++)
                {
                    Console.Write(myArray[i] + " ");
                }

                Console.ReadKey();
            }
        }
    }
}
