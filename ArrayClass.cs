using System;

namespace Arrays
{
    public class ArrayClass
    {
       static public int[] arrayA = { 4, 6, 3, 7, 1 };

       static public int[] Sorted(int[] input)
        {
           int temp = 0;
           //int[] temp = new int[input.Length];
           for (int i = 0; i < input.Length - 1; i++)
           {
               for (int j = i + 1; j < input.Length; j++)
               {
                   if (input[i] > input[j])
                   {
                       temp = input[i];
                       input[i] = input[j];
                       input[j] = temp;
                   }
           
               }
           }
            return input;

           // int[] sorted = new int[input.Length];
           //
           // int bigInt = int.MaxValue;
           // for (int i = 0; i < input.Length; i++)
           // {
           //     //smallest int
           //     int min = findMin(input);
           //     sorted[i] = input[min];
           //     input[min] = bigInt;
           //
           //     //add smallest to the array
           //     //change smallest into to bigInt
           // }
           // return sorted;

        }
        static public  int findMin(int[] input)
        {
            int index = 0;
            int smallest = input[index];

            for (int i = 1; i < input.Length; i++)
            {
                if (input[i] < smallest)
                {
                    smallest = input[i];
                    index = 1;
                }
            }
            return index;
        }
    }
}
