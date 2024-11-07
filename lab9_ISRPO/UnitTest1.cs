namespace lab9_ISRPO
{
    public class UnitTest1
    {
        public class MatrixTests
        {
            private Matrix matTesting;

            // ���� �������� ���������� ����� � ������� - ������ ������
            [Fact]
            public void RowsTest1()
            {
                int[,] rowTest1 = new int[,] { { 8, 9, 3, 5 }, { 6, 3, 2, 1 } }; //���������� �������
                matTesting = new Matrix(rowTest1); //������������� ���������� ����� ����������� Matrix � ��������� �������
                Assert.Equal(2, matTesting.Rows);
            }

            // ���� �������� ���������� ����� � ������� - ������ ������
            [Fact]
            public void RowsTest2()
            {
                int[,] rowTest2 = new int[,] { { 5 } };
                matTesting = new Matrix(rowTest2);
                Assert.Equal(1, matTesting.Rows);
            }

            // ���� �������� ���������� �������� � ������� - ������ ������
            [Fact]
            public void ColsTest1()
            {
                int[,] colTest1 = new int[,] { { 8, 9, 3, 5 }, { 6, 3, 2, 1 } };
                matTesting = new Matrix(colTest1);
                Assert.Equal(4, matTesting.Cols);
            }

            // ���� �������� ���������� �������� � ������� - ������ ������
            [Fact]
            public void ColsTest2()
            {
                int[,] colTest2 = new int[,] { { 5 } };
                matTesting = new Matrix(colTest2);
                Assert.Equal(1, matTesting.Cols);
            }

            // ���� ������ ������������ �������� � ������� - ������ ������
            [Fact]
            public void FindMinTest1()
            {
                int[,] findMinTest1 = new int[,] { { 8, 9, 3, 5 }, { 6, 3, 2, 1 } };
                matTesting = new Matrix(findMinTest1);
                Assert.Equal(1, matTesting.FindMin());
            }

            // ���� ������ ������������ �������� � ������� - ������ ������
            [Fact]
            public void FindMinTest2()
            {
                int[,] findMinTest2 = new int[,] { { 5 } };
                matTesting = new Matrix(findMinTest2);
                Assert.Equal(5, matTesting.FindMin());
            }

            // ���� ������ ������������ �������� � ������ ��� �������� ������� ������� - ������ ������
            [Fact]
            public void FindMinInEvenOrOddRowsMinTest1()
            {
                int[,] findMinInEvenOrOddRowsMinTest1 = new int[,] { { 8, 9, 3, 5 }, { 6, 3, 2, 1 } };
                matTesting = new Matrix(findMinInEvenOrOddRowsMinTest1);
                Assert.Equal(1, matTesting.FindMinInEvenOrOddRows(1));
            }

            // ���� ������ ������������ �������� � ������ ��� �������� ������� ������� - ������ ������
            [Fact]
            public void FindMinInEvenOrOddRowsMinTest2()
            {
                int[,] findMinInEvenOrOddRowsMinTest2 = new int[,] { { 8, 9, 3, 5 }, { 6, 3, 2, 1 } };
                matTesting = new Matrix(findMinInEvenOrOddRowsMinTest2);
                Assert.Equal(3, matTesting.FindMinInEvenOrOddRows(2));
            }

            // ���� ������ ������������ �������� � �������, ������� ������ ��������� �������� - ������ ������
            [Fact]
            public void FindMinLessThanTest1()
            {
                int[,] findMinLessThanTest1 = new int[,] { { 8, 9, 3, 5 }, { 6, 3, 2, 1 } };
                matTesting = new Matrix(findMinLessThanTest1);
                Assert.Equal(1, matTesting.FindMinLessThan(2));
            }

            // ���� ������ ������������ �������� � �������, ������� ������ ��������� �������� - ������ ������
            [Fact]
            public void FindMinLessThanTest2()
            {
                int[,] findMinLessThanTest2 = new int[,] { { 8, 9, 3, 5 }, { 6, 3, 2, 1 } };
                matTesting = new Matrix(findMinLessThanTest2);
                Assert.Equal(1, matTesting.FindMinLessThan(9));
            }
        }
    }
}
