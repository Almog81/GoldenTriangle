using System;
using NUnit.Framework;
using MyApp.Utilities;


namespace MyApp_Tests.E2ETests
{
    [TestFixture]
    public class TestAll
    {
        private string path;
        private FilesIO filesIO;


        [OneTimeSetUp]
        public void Init()
        {
            path = @"C:\Automation\Golden Triangle\MyApp Tests\TestsData\";
            filesIO = new FilesIO(path);
        }
        //        שלבים בבדיקת רברס נמבר
        // 0. כתיבה לתוך הקובץ 12345
        //1. לקרוא מהקובץ מספרים
        //2. להפעיל את הפונקציה של הפיחת המספרים עם הנתון של 1
        //3. לכתוב לקובץ התוצאה לקובץ 
        //4. לקרא את קובץ הבדיקה 
        //5. לוודא שזה אכן מספר הפוך
        [Test]
        public void Test01_E2E_ReversNumbers_P() //TC-07
        {
            string num = "12345"; //0
            int expected = 54321;
            filesIO.WriteText("test-num-input.txt", num); //0

            int content = Int32.Parse(filesIO.ReadText("test-num-input.txt")); //1
            string txt = Implementations.ReverseNumbers(content).ToString(); //2
            filesIO.WriteText("test-results.txt", txt); //3

            int resolt = Int32.Parse(filesIO.ReadText("test-results.txt")); //4
            Assert.AreEqual(expected, resolt,"Canot Revers the numbers"); //5
        }

        [Test]
        public void Test02_E2E_ReversNumbers_N() //TC-08
        {
            string num = "12345"; //0
            int expected = 12345;
            filesIO.WriteText("test-num-input.txt", num); //0

            int content = Int32.Parse(filesIO.ReadText("test-num-input.txt")); //1
            string txt = Implementations.ReverseNumbers(content).ToString(); //2
            filesIO.WriteText("test-results.txt", txt); //3

            int resolt = Int32.Parse(filesIO.ReadText("test-results.txt")); //4
            Assert.AreNotEqual(expected, resolt, "Canot Revers the numbers"); //5
        }
        
        [Test]
        public void Test03_E2E_Fctorial_P() //TC-09
        {
            string num = "5"; //0
            int expected = 120;
            filesIO.WriteText("test-num-input.txt", num); //0

            int content = Int32.Parse(filesIO.ReadText("test-num-input.txt")); //1
            string actual = Implementations.CalculateFactorial(content).ToString(); //2
            filesIO.WriteText("test-results.txt", actual); //3

            int resolt = Int32.Parse(filesIO.ReadText("test-results.txt")); //4
            Assert.AreEqual(expected, resolt, "Actual and Expected do not match"); //5
        }
        [Test]
        public void Test04_E2E_Fctorial_N() //TC-10
        {
            string num = "5"; //0
            int expected = 5;
            filesIO.WriteText("test-num-input.txt", num); //0

            int content = Int32.Parse(filesIO.ReadText("test-num-input.txt")); //1
            string actual = Implementations.CalculateFactorial(content).ToString(); //2
            filesIO.WriteText("test-results.txt", actual); //3

            int resolt = Int32.Parse(filesIO.ReadText("test-results.txt")); //4
            Assert.AreNotEqual(expected, resolt, "Actual and Expected do not match"); //5
        }
        [Test]
        public void Test05_E2E_Longestword_P() //TC-11
        {
            string text = "hello im inigomontoia you kiil my father preper tol die";
            string expected = "inigomontoia";
            filesIO.WriteText("test-text-input.txt", text); //0

            string content = filesIO.ReadText("test-text-input.txt"); //1
            string actual = Implementations.LongestWord(content.Split(' '));//2
            filesIO.WriteText("test-results.txt", actual); //3

            string resolt = filesIO.ReadText("test-results.txt");//4
            Assert.AreEqual(expected, resolt, "Actual and Expected do not match");
        }
        [Test]
        public void Test06_E2E_Longestword_N() //TC-12
        {
            string text = "hello im inigomontoia you kiil my father preper tol die";
            string expected = "hello";
            filesIO.WriteText("test-num-input.txt", text); //0

            string content = filesIO.ReadText("test-text-input.txt"); //1
            string actual = Implementations.LongestWord(content.Split(' '));//2
            filesIO.WriteText("test-results.txt", actual); //3

            string resolt = filesIO.ReadText("test-results.txt");//4
            Assert.AreNotEqual(expected, resolt, "Actual and Expected do not match");
        }
        [Test]
        public void Test07_E2E_SortNumbers_P() //TC-13
        {
            string num = "615649"; //0
            int expected = 145669;
            filesIO.WriteText("test-num-input.txt", num); //0

            int content = Int32.Parse(filesIO.ReadText("test-num-input.txt")); //1
            string actual = SortNumbers.SN(content).ToString(); //2
            filesIO.WriteText("test-results.txt", actual); //3

            int resolt = Int32.Parse(filesIO.ReadText("test-results.txt")); //4
            Assert.AreEqual(expected, resolt, "Actual and Expected do not match");
        }
        [Test]
        public void Test08_E2E_SortNumbers_N() //TC-14
        {
            string num = "615649"; //0
            int expected = 615649;
            filesIO.WriteText("test-num-input.txt", num); //0

            int content = Int32.Parse(filesIO.ReadText("test-num-input.txt")); //1
            string actual = SortNumbers.SN(content).ToString(); //2
            filesIO.WriteText("test-results.txt", actual); //3

            int resolt = Int32.Parse(filesIO.ReadText("test-results.txt")); //4
            Assert.AreNotEqual(expected, resolt, "Actual and Expected do not match");
        }

    }
}
