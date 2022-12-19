using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Utilities
{
    public class Implementations
    {
        public static int ReverseNumbers (int num)
        {
            //אופציה 1
            string output = "";
            char[] charArray = num.ToString().ToCharArray();
            for (int i = charArray.Length - 1; i >= 0; i--)
            {
                output += charArray[i]; //output = output + charArray
            }
            return Int32.Parse(output);

            ////אופציה21
            //char[] charArray = num.ToString().ToCharArray();
            //Array.Reverse (charArray);
            //return Int32.Parse(new string(charArray));
        }

        public int reverseNumbers(int v)
        {
            throw new NotImplementedException();
        }

        public static int CalculateFactorial(int num) //פונקציה שמחשבת עצרת
        {
            //אופציה 1
            //היא רצה על המספר בסדר יורד
            int result = 1;
            if (num > 0)
            {
                while (num > 1)
                {
                    result *= num--;
                }
            }
            return result;

            ////אופציה ב
            ////היא רצה על כל המספרים בסדר עולה
            //int result = 1;
            //for (int i = 1; i <= num; i++)
            //{
            //    result *= i;
            //}
            //return result;

        }
        public static string LongestWord(string[] words) //הפונקציה מקבלת מערך של מילים
        {
            string longest = "";
            for(int i = 0; i < words.Length; i++) // אני רוצה לרוץ על כל האיברים על כל המילים בתוך המערך ולמצא את המילה הארוכה ביותר
            {
                if(words[i].Length > longest.Length)
                {
                    longest = words[i];
                }
            }
            return longest;
        }
    }
}
