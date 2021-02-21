using System;

namespace NewWhiteBoard
{
    class Program
    {
        static public int[] arrayA = { 4, 6, 3, 7, 1 };

        static public void Sort(int[] input)
        {
            int temp = 0;
            //int[] temp = new int[input.Length];
            for (int i = 0; i < input.Length - 1; i++)
            {
                for (int j = i + 1; j < input.Length; j++)
                {
                    if (input[i] > input[j])
                    {
                        temp = input[i] ;
                        input[i] = input[j];
                        input[j] = temp;
                    }
                   
                }
            }
            foreach (var t in input)
            {
                Console.WriteLine(t);
            }

            int[] sorted = new int[input.Length];

            int bigInt = int.MaxValue;
            for (int i = 0; i < input.Length; i++)
            {
                //smallest int
                
                //add smallest to the array
                //change smallest into to bigInt
            }
        }
        static void Main(string[] args)
        {
            Sort(arrayA);
            //Console.WriteLine("Hello World!");
            //Testing Changed
        }
   
    
    }
}

//{4, 6, 3, 7, 1 }