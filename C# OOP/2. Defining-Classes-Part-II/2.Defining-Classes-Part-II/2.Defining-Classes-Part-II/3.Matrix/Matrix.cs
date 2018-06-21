namespace _3.Matrix
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;


    class Matrix<T> where T : struct
    {
        private T[,] arr;
        public int Cols { get; private set; }
        public int Rows { get; private set; }

        public Matrix(int col, int row)
        {
            this.Cols = col;
            this.Rows = row;
            this.arr = new T[Cols, Rows];
        }

        public T this[int Rows, int Cols]
        {
            get
            {
                if (Rows < 0 || Cols < 0)
                {
                    throw new IndexOutOfRangeException("Trying to access not existing element!");
                }
                return arr[Rows, Cols];
            }
            set { arr[Rows, Cols] = value; }
        }

        // Operator overloading
        public static Matrix<T> operator +(Matrix<T> f, Matrix<T> s)
        {

            if ((f.Cols == s.Cols) && (f.Rows == s.Rows))
            {
                Matrix<T> tt = new Matrix<T>(f.Rows, f.Cols);

                for (int row = 0; row < f.Rows; row++)
                {
                    for (int col = 0; col < f.Cols; col++)
                    {
                        tt[row, col] = (dynamic)f[row, col] + (dynamic)s[row, col];
                    }
                }
                return tt;
            }

            else throw new ArgumentException("This two matrix have diffrent dimensions.");

        }

        public static Matrix<T> operator *(Matrix<T> f, Matrix<T> s)
        {
            if ((f.Rows == s.Rows) && (f.Cols == s.Cols))
            {
                Matrix<T> tt = new Matrix<T>(f.Rows, f.Cols);

                for (int col = 0; col < f.Rows; col++)
                {
                    for (int row = 0; row < f.Cols; row++)
                    {
                        tt[col, row] = (dynamic)f[col, row] * (dynamic)s[col, row];
                    }
                }
                return tt;
            }

            else throw new ArgumentException("This two matrix have diffrent dimensions.");
        }

        public static Matrix<T> operator -(Matrix<T> f, Matrix<T> s)
        {
            if ((f.Rows == s.Rows) && (f.Cols == s.Cols))
            {
                Matrix<T> tt = new Matrix<T>(f.Rows, f.Cols);

                for (int col = 0; col < f.Rows; col++)
                {
                    for (int row = 0; row < f.Cols; row++)
                    {
                        tt[col, row] = (dynamic)f[col, row] - (dynamic)s[col, row];
                    }
                }
                return tt;
            }

            else throw new ArgumentException("This two matrix have diffrent dimensions.");
        }
    }
}