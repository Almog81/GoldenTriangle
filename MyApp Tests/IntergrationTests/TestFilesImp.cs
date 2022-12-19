using System;
using MyApp.Utilities;
using NUnit.Framework;


namespace MyApp_Tests.IntergrationTests
{
    [TestFixture]
    internal class TestFilesImp
    {
        private string path;
        private FilesIO filesIO;

        [OneTimeSetUp]
        public void Init()
        {
            path = @"C:\Automation\Golden Triangle\MyApp Tests\TestsData\";
            filesIO = new FilesIO(path);
        }

        [Test]
        public void Test01_ReadAndVerifyReverseNumberP() //בודק הפיכת מספרים כולל קראית טקסט
        {
            string file = "test-num-input.txt";
            string text = "12345";
            filesIO.WriteText(file, text);

            int contect = Int32.Parse(filesIO.ReadText("test-num-input.txt"));
            int actual = Implementations.ReverseNumbers(contect);
            int expected = 54321;
            Assert.AreEqual(expected, actual, "Faild to compair text in file to expected");
        }
        [Test]
        public void Test02_ReadAndVerifyReverseNumberN() //שלילי
        {
            int contect = Int32.Parse(filesIO.ReadText("test-num-input.txt"));
            int actual = Implementations.ReverseNumbers(contect);
            int expected = 12345;
            Assert.AreNotEqual(expected, actual, "Faild to compair text in file to expected");
        }
        [Test]
        public void Test03_ReadAndVerifyLongestWordP() //בודק הפיכת מספרים כולל קראית טקסט
        {
            string contect = filesIO.ReadText("test-text-input.txt");
            string actual = Implementations.LongestWord(contect.Split(' '));
            string expected = "inigomontoia";
            Assert.AreEqual(expected, actual, "Faild to compair text in file to expected");
        }
        [Test]
        public void Test04_ReadAndVerifyLongestWordN() //שלילי
        {
            string contect = filesIO.ReadText("test-text-input.txt");
            string actual = Implementations.LongestWord(contect.Split(' '));
            string expected = "atid";
            Assert.AreNotEqual(expected, actual, "Faild to compair text in file to expected");
        }
    }
}
