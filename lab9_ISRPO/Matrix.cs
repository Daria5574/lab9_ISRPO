using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab9_ISRPO
{
    public class Matrix
    {
        private int[,] matrix;

        public int Rows { get; } //строки
        public int Cols { get; } //столбцы

        // Конструктор для создания пустой матрицы заданного размера
        public Matrix(int rows, int cols)
        {
            Rows = rows;
            Cols = cols;
            matrix = new int[Rows, Cols];
        }

        // Конструктор для создания матрицы на основе переданных значений
        public Matrix(int[,] values)
        {
            Rows = values.GetLength(0);
            Cols = values.GetLength(1);
            matrix = values;
        }

        // Индексатор для доступа к элементам матрицы
        public int this[int i, int j]
        {
            get { return matrix[i, j]; }
            set { matrix[i, j] = value; }
        }

        // Метод для поиска минимального элемента в матрице
        public int FindMin()
        {
            int min = matrix[0, 0];
            foreach (int num in matrix)
            {
                if (num < min)
                {
                    min = num;
                }
            }
            return min;
        }

        // Метод для поиска минимального элемента в четных или нечетных строках матрицы
        public int FindMinInEvenOrOddRows(int type)
        {
            int min = int.MaxValue;
            for (int i = 0; i < Rows; i++)
            {
                if ((i % 2 == 0 && type == 2) || (i % 2 != 0 && type == 1))
                {
                    for (int j = 0; j < Cols; j++)
                    {
                        if (matrix[i, j] < min)
                        {
                            min = matrix[i, j];
                        }
                    }
                }
            }
            return min;
        }

        // Метод для поиска минимального элемента в матрице, который меньше или равен заданному значению
        public int FindMinLessThan(int value)
        {
            int min = int.MaxValue;
            foreach (int num in matrix)
            {
                if (num < min && num <= value)
                {
                    min = num;
                }
            }
            return min;
        }
    }
}
