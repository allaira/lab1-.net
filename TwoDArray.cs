using System;

namespace lab1
{
    public class TwoDArray
    {
        private double[,] arr;
        public int rows;
        public int cols;

        public int Rows => rows;
        public int Cols => cols;


        public TwoDArray()
        {
            rows = 5;
            cols = 3;
            arr = new double[5, 3]
            {
                {  2.5, -4.1,  6.0 },
                { -1.8,  0.5, -9.2 },
                {  7.3, -3.4,  1.1 },
                {  0.0, -8.7,  4.4 },
                { -6.3,  9.8, -2.9 }
            };
        }


        public TwoDArray(int r, int c)
        {
            rows = r > 0 ? r : 5;
            cols = c > 0 ? c : 3;
            arr = new double[rows, cols];
        }


        public double this[int i, int j]
        {
            get
            {
                if (i >= 0 && i < rows && j >= 0 && j < cols)
                {
                    return arr[i, j];
                }
                
                throw new IndexOutOfRangeException("Індекс вийшов за межі матриці!");
            }
            set
            {
                if (i >= 0 && i < rows && j >= 0 && j < cols)
                {
                    arr[i, j] = value;
                }
                else
                {
                    throw new IndexOutOfRangeException("Індекс вийшов за межі матриці!");
                }
            }
        }

        public string GetNegativeIndices()
        {
            string result = "";
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (arr[i, j] < 0)
                    {
                        result += $"A[{i + 1}, {j + 1}] = {arr[i, j]}\r\n";
                    }
                }
            }
            return string.IsNullOrEmpty(result) ? "Від'ємних елементів немає" : result;
        }
    }
}