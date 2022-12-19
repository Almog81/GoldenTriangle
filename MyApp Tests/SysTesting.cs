using NUnit.Framework;
using System;
using MyApp;
using MyApp.Utilities;

namespace MyApp_Tests
{
    [TestFixture]
    public class SysTesting
    {
        private string path;
        private FilesIO filesIO; //צריך לעמוד עם העכבר על השם FilesIO ולבחור להשתמש אחרת הוא לא יכול לקרא את שם הקובץ

        [OneTimeSetUp] //מטודה שמאתחלת את הבדיקות שלנו זה אומר שזה רץ לפני כל הבדיקות
        public void Init()
        {
            //path = @"C:\Users\אלמוג\source\repos\Golden Triangle\Golden Triangle\MyApp Tests\TestsData\";
            path = @"C:\Automation\Golden Triangle\MyApp\AppData\";
            filesIO = new FilesIO(path);
        }
        public static void Main(string[] args)
        {

            for (int i = 1; i > 0; i++)
            {
                int choice = i;
                MyApp.Program.selectFromMenu(choice);

            }
        }
    }
}
