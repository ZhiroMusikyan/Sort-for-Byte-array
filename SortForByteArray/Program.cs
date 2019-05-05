using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortForByteArray
{
    class Program
    {
        static void Main(string[] args)
        {
            byte[] array = CreateRandomArray(100);
            int[] arr = GetCountOfElement(array);
            int sum = GetSum(arr);

           //var stopwatch = new Stopwatch();
            //stopwatch.Start();
            SortMeth(array);

           // Console.WriteLine(stopwatch.Elapsed);
            //Print(array);

            Console.ReadLine();
        }

        static int GetSum(int[] arr)
        {
            int sum = 0;
            foreach (int item in arr)
            {
                sum += item;
            }
            return sum;
        }

        static void Print(byte[] b)
        {
            byte[] arr = b;
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]} ");
            }
        }

        static int[] GetCountOfElement(byte[] source)
        {
            int[] countArr = new int[256];
            for (int i = 0; i < source.Length; i++)
            {
                byte a = source[i];
                countArr[a]++;
            }
            return countArr;
        }

        static void SortMeth(byte[] source)
        {
            int[] countArr = GetCountOfElement(source);
            //System.Diagnostics.Debug.WriteLine($"countArr Sum = {GetSum(countArr)}");

            int i = 0;
            for (int el = 0; el < countArr.Length; el++)
            {
                for (int j = 0; j < countArr[el]; j++)
                {
                    source[i] = (byte)el;
                    i++;
                }

            }
        }

        static byte[] CreateRandomArray(int arg)
        {
            Random rnd = new Random();
            byte[] array = new byte[arg];
            rnd.NextBytes(array);
            return array;
        }
    }
}
