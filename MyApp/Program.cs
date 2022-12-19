using MyApp.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp
{
    public class Program
    {
        private static string path = @"C:\Automation\Golden Triangle\MyApp\AppData\";
        //private static string path = @"G:\מחשבים אחרים\ה-מחשב נייד שלי - LEGION\Golden Triangle\Golden Triangle\MyApp\AppData\";
        private static FilesIO filesIO = new FilesIO(path);
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, for all!");
            //Console.WriteLine(filesIO.ReadText("app-menu.txt"));
            //string texst = Console.ReadLine();
            //int choice = Int32.Parse(texst);
            int choice = filesIO.ReadText("app-menu.txt").ElementAt(20) - '0'; //זאת דרך בעייתית שהרי הוא בוחר את התיו ה20 ומסתכל מה כתוב בו, איזה אפשרות כתוב בו
            selectFromMenu(choice);
        }

        public static void selectFromMenu(int choice)
        {
            switch(choice)
            {
                case 1:
                    CallReversNumbers();
                    break;
                case 2:
                    CallCalculateFactorial();
                    break;
                case 3:
                    CallLongestWord();
                    break;
                case 4:
                    CallSortNumbers();
                    break ;
                default:
                    throw new ArgumentException("Worng Choice Number");
            }
        }
        public static void CallReversNumbers()
        {
            int content = Int32.Parse(filesIO.ReadText("app-num-input.txt"));
            string txt = Implementations.ReverseNumbers(content).ToString();
            filesIO.WriteText("app-results.txt", txt);
            //Console.WriteLine("The result is: " + txt);
            //Console.ReadLine();
        }

        public static void CallCalculateFactorial()//ניסיו שלי
        {
            int content = Int32.Parse(filesIO.ReadText("app-num-input.txt"));
            string txt = Implementations.CalculateFactorial(content).ToString();
            filesIO.WriteText("app-results.txt", txt);
            //Console.WriteLine("The result is: " + txt);
            //Console.ReadLine();
        }

        public static void CallLongestWord()//חסר כאן לבודד למילים
        {
            string content = (filesIO.ReadText("app-text-input.txt"));
            string[] ContentArry = content.Split(' ');
            string txt = Implementations.LongestWord(ContentArry).ToString();
            filesIO.WriteText("app-results.txt", txt);
            //Console.WriteLine("The Longest Word is: " + txt);
            //Console.ReadLine();
        }

        public static void CallSortNumbers() //קריאה לאפונקציה הישנה
        {
            int num = int.Parse(filesIO.ReadText("app-num-input.txt"));
            string txt = SortNumbers.SN(num).ToString();
            filesIO.WriteText("app-results.txt", txt);
            //Console.WriteLine("The result is: " + txt);
            //Console.ReadLine();
        }
    }
}
