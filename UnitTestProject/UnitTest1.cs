using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        Matrix matTesting;
 
        // Конструктор программы
        public UnitTest1()
        {
            run();
        }
        // Метод запуска программы
        public void run()
        {
            RowsTest1();
            RowsTest2();
            ColsTest1();
            ColsTest2();
            FindMinTest1();
            FindMinTest2();
            FindMinInEvenOrOddRowsMinTest1();
            FindMinInEvenOrOddRowsMinTest2();
            FindMinLessThanTest1();
            FindMinLessThanTest2();
        }
        // Тест проверки количества строк в матрице - первый случай
        [TestMethod]
        public void RowsTest1()
        {
            int[,] rowTest1 = new int[,] { { 8, 9, 3, 5 }, { 6, 3, 2, 1 } }; //объявление матрицы
            int rezult = 0;
            matTesting = new Matrix(rowTest1); //инициализация переменной новым экземпляром Matrix с передачей матрицы
            rezult = matTesting.Rows;

            Assert.AreEqual(2, rezult);
        }
        // Тест проверки количества строк в матрице - второй случай
        [TestMethod]
        public void RowsTest2()
        {
            int[,] rowTest2 = new int[,] { { 5 } };
            int rezult = 0;
            matTesting = new Matrix(rowTest2);
            rezult = matTesting.Rows;

            Assert.AreEqual(1, rezult);
        }
        // Тест проверки количества столбцов в матрице - первый случай
        [TestMethod]
        public void ColsTest1()
        {
            int[,] colTest1 = new int[,] { { 8, 9, 3, 5 }, { 6, 3, 2, 1 } };
            int rezult = 0;
            matTesting = new Matrix(colTest1);
            rezult = matTesting.Cols;

            Assert.AreEqual(4, rezult);
        }
        // Тест проверки количества столбцов в матрице - второй случай
        [TestMethod]
        public void ColsTest2()
        {
            int[,] colTest2 = new int[,] { { 5 } };
            int rezult = 0;
            matTesting = new Matrix(colTest2);
            rezult = matTesting.Cols;

            Assert.AreEqual(1, rezult);
        }
        // Тест  поиска минимального элемента в матрице - первый случай
        [TestMethod]
        public void FindMinTest1()
        {
            int[,] findMinTest1 = new int[,] { { 8, 9, 3, 5 }, { 6, 3, 2, 1 } };
            int rezult = 0;
            matTesting = new Matrix(findMinTest1);
            rezult = matTesting.FindMin();

            Assert.AreEqual(1, rezult);
        }
        // Тест поиска минимального элемента в матрице - второй случай
        [TestMethod]
        public void FindMinTest2()
        {
            int[,] findMinTest2 = new int[,] { { 5 } };
            int rezult = 0;
            matTesting = new Matrix(findMinTest2);
            rezult = matTesting.FindMin();

            Assert.AreEqual(5, rezult);
        }
        // Тест поиска минимального элемента в четных или нечетных строках матрицы - первый случай
        [TestMethod]
        public void FindMinInEvenOrOddRowsMinTest1()
        {
            int[,] findMinInEvenOrOddRowsMinTest1 = new int[,] { { 8, 9, 3, 5 }, { 6, 3, 2, 1 } };
            int rezult = 0;
            matTesting = new Matrix(findMinInEvenOrOddRowsMinTest1);
            rezult = matTesting.FindMinInEvenOrOddRows(1);

            Assert.AreEqual(1, rezult);
        }
        // Тест поиска минимального элемента в четных или нечетных строках матрицы - второй случай
        [TestMethod]
        public void FindMinInEvenOrOddRowsMinTest2()
        {
            int[,] findMinInEvenOrOddRowsMinTest2 = new int[,] { { 8, 9, 3, 5 }, { 6, 3, 2, 1 } };
            int rezult = 0;
            matTesting = new Matrix(findMinInEvenOrOddRowsMinTest2);
            rezult = matTesting.FindMinInEvenOrOddRows(2);

            Assert.AreEqual(3, rezult);
        }
        // Тест поиска минимального элемента в матрице, который меньше заданного значения - первый случай
        [TestMethod]
        public void FindMinLessThanTest1()
        {
            int[,] findMinLessThanTest1 = new int[,] { { 8, 9, 3, 5 }, { 6, 3, 2, 1 } };
            int rezult = 0;
            matTesting = new Matrix(findMinLessThanTest1);
            rezult = matTesting.FindMinLessThan(2);

            Assert.AreEqual(1, rezult);
        }
        // Тест поиска минимального элемента в матрице, который меньше заданного значения - второй случай
        [TestMethod]
        public void FindMinLessThanTest2()
        {
            int[,] findMinLessThanTest2 = new int[,] { { 8, 9, 3, 5 }, { 6, 3, 2, 1 } };
            int rezult = 0;
            matTesting = new Matrix(findMinLessThanTest2);
            rezult = matTesting.FindMinLessThan(9);

            Assert.AreEqual(1, rezult);
        }
        // Главный метод программы
        public static void Main()
        {
            UnitTest1 test = new UnitTest1();
        }
    }

}

