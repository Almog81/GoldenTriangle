using System;
using MyApp.Utilities;
using NUnit.Framework;
namespace MyApp_Tests.UnitTests
{
    [TestFixture]
    internal class TestFilesIO
    {
        private string path;
        private FilesIO filesIO; //צריך לעמוד עם העכבר על השם FilesIO ולבחור להשתמש אחרת הוא לא יכול לקרא את שם הקובץ

        [OneTimeSetUp] //מטודה שמאתחלת את הבדיקות שלנו זה אומר שזה רץ לפני כל הבדיקות
        public void Init()
        {
            path = @"C:\Automation\Golden Triangle\MyApp Tests\TestsData\";
            filesIO = new FilesIO(path);
        }

        [Test]
        public void Test01_ReadTextPositive() //TC-01
        {
            string actual = filesIO.ReadText("test-text-input.txt");
            string expected = "hello im inigomontoia you kiil my father preper tol die";
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void Test02_ReadTextNegative() //TC-02
        {
            string actual = filesIO.ReadText("test-text-input.txt");
            string expected = "KUKU";
            Assert.AreNotEqual(expected, actual);
        }

        [Test]
        public void Test03_WritTextPositive() //TC-03
        {
            string file = "test-text-input.txt";
            string text = "hello im inigomontoia you kiil my father preper tol die";
            try
            {
                filesIO.WriteText(file, text);
                string actual = filesIO.ReadText(file);
                Assert.AreEqual(text, actual, "Faild to comper filetxt to expected");
                Console.WriteLine("Test past");
            }
            catch (Exception e)
            {
                Console.WriteLine("Test Faild, see Details: " + e);
                Assert.Fail("Test Faild, see Details: " + e);
            }

        }

    }
}
