using System;

namespace NewCamelCase
{
    public class Casing
    {
        //static string alphaChar = "AaBbCcDdEeFfGgHhIiJjKkLlMmNnOoPpQqRrSsTtUuVvWwXxYyZz";
        //static string digets = "0123456789";
        //write a method to retunr camelCase string from an input string
        //"The Cat In The Hat" should return "theCatInTheHat"
        static public string CamelCase(string input)
        {
            // string output = "";
            //
            // for (int i = 1 ; i < input.Length; i++)
            // {
            //     if(input[i] == ' ')
            //     {
            //         continue;
            //     }
            //     output += input[i];
            // }
            // return output;

            string result = "";

            bool newWord = false;

            foreach (char c in input)
            {
                if (char.IsWhiteSpace(c) || c == '-') newWord = true;
                if (char.IsLetterOrDigit(c) || c == '_')
                {
                    result += newWord ? char.ToUpper(c) : char.ToLower(c);
                    newWord = false;
                }
            }

            return result;
        }

        // static public bool checkFirstChar(string input)
        // {
        //     bool output = false; 
        //
        //     if (input[0] == '_') output = true;
        //     for (int i = 0; i < alphaChar.Length ; i++)
        //     {
        //         if (input[0] == alphaChar[i]) output = true;
        //     }
        //     return output;
        // }

        static public string PascalCase(string input)
        {
            //string output = "";
            //output += char.ToUpper(input[0]);
            //
            //for (int i = 1; i < input.Length; i++)
            //{
            //    if (input[i] == ' ')
            //    {
            //        continue;
            //    }
            //    output += input[i];
            //}
            //return output;
            string camelCase = CamelCase(input);

            string result = "";

            result += char.ToUpper(camelCase[0]);

            for (int i = 1; i < camelCase.Length; i++)
            {
                result += camelCase[i];
            }


            return result;

        }
    }
}
