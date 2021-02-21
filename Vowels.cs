using System;

namespace CheckVowels
{
    public class Vowels
    {
        //count how many vowles are within a string

        //Brenden should return 2

        public static int HowManyVowels(string input)
        {
            int count = 0; //this is what we will return
            input = input.ToLower(); //make sure we are only evaluating lowercase letters
            string vowels = "aeiou"; //the vowels that we will be checking
            if(String.IsNullOrEmpty(input))
            {
                return count; //break out of the method if the result is null or empty
            }
            for(int i=0; i<vowels.Length; i++)
            {
                for (int j = 0; j < input.Length; j++)
                {
                    if (vowels[i] == input[j]) count++;
                }
            }
            return count;

        }
    }
}
