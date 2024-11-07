using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcceptElementInArray
{
    internal class Program
    {
        //Accept the 5 elements from user & display
        static void Main(string[] args)
        {
            int[] arr1 = new int[5];
            Console.WriteLine("Enter % element in array");
            for (int i = 0; i < arr1.Length; i++)
            {
                arr1[i]=Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("--------Element in arr----------");
            for (int i = 0; i < arr1.Length; i++)
            {
                Console.WriteLine(arr1[i]);
            }
        }
    }
}
