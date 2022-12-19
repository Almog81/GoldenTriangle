using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Utilities
{
    public class SortNumbers
    {
        public static int SN(int num)
        {
            int Number = num;
            return SortNum(Number);
        }
        static int SortNum(int Number) //פונקציה אשר מסדרת את הספרות של המספר לפי הסדר
        {
            Char[] NumberStrs = convertNumToCharArray(Number);
            int[] ArryNums = convertCharArrayToIntArray(NumberStrs);
            SortIntArray(ArryNums);// פונקציה אשר מסדרת את המערך
            return convertIntArrayToInt(ArryNums);
        }

        static Char[] convertNumToCharArray(int Number)  //פונקציה אשר לוקחת את המספר והופכת אותו למערך של צ'אר
        {
            return Number.ToString().ToCharArray();
        }

        static int[] convertCharArrayToIntArray(Char[] NumberStrs) // פונקציה אשר הופכת את המערך לאינט
        {
            int[] Numbers = new int[NumberStrs.Length];
            for (int i = 0; i < NumberStrs.Length; i++) //עבור כל אחד מהתאים של המערך תבצע את הפעולה של להפוך אותו לאינט
            {
                //to convert char into int, first convert it to sring
                Numbers[i] = Int32.Parse(NumberStrs[i].ToString());
            }
            return Numbers;
        }

        static void SortIntArray(int[] ArryNums)
        {
            Array.Sort(ArryNums);
        }

        static int convertIntArrayToInt(int[] Numbers)
        {
            StringBuilder str = new StringBuilder();
            foreach (int i in Numbers)
            {
                str.Append(i); //משרר את כל המספרים לאיבר אחד למספר אחד
            }
            //עכשיו צריך לשלוח בחזרה את התוצאה
            return Int32.Parse(str.ToString());
        }

    }
}
