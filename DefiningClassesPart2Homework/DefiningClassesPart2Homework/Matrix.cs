using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClassesPart2Homework
{
    class Matrix<T> where T : IConvertible
    {
        private T[,] matrix;

        public int Row { get; set; }
        public int Col { get; set; }

        public Matrix(int row, int col)
        {
            this.matrix = new T[row, col];
            this.Row = row;
            this.Col = col;
        }

        public T this[int row, int col]
        {
            get
            {
                return this.matrix[row, col];
            }
            set
            {
                this.matrix[row, col] = value;
            }
        }

        public static Matrix<T> operator +(Matrix<T> m1, Matrix<T> m2)
        {

            if (m1.Row == m2.Row && m1.Col == m2.Col)
            {
                Matrix<T> resultMatrix = new Matrix<T>(m1.Row, m1.Col);
                for (int i = 0; i < m1.Row; i++)
                {
                    for (int j = 0; j < m1.Col; j++)
                    {
                        resultMatrix[i, j] = (dynamic)m1[i, j] + (dynamic)m2[i, j];
                    }
                }

                return resultMatrix;
            }
            else
            {
                throw new InvalidOperationException();
            }
        }

        public static Matrix<T> operator -(Matrix<T> m1, Matrix<T> m2)
        {

            if (m1.Row == m2.Row && m1.Col == m2.Col)
            {
                Matrix<T> resultMatrix = new Matrix<T>(m1.Row, m1.Col);
                for (int i = 0; i < m1.Row; i++)
                {
                    for (int j = 0; j < m1.Col; j++)
                    {
                        resultMatrix[i, j] = (dynamic)m1[i, j] - (dynamic)m2[i, j];
                    }
                }

                return resultMatrix;
            }
            else
            {
                throw new InvalidOperationException();
            }
        }

        public static Matrix<T> operator *(Matrix<T> m1, Matrix<T>m2)
        {
            if (m1.Col == m2.Row)
            {
                Matrix<T> resultMatrix = new Matrix<T>(m1.Row, m2.Col);

                for (int i = 0; i < resultMatrix.Row; i++)
                {
                    for (int j = 0; j < resultMatrix.Col; j++)
                    {
                        resultMatrix[i, j] = (dynamic)0;
                        for (int k = 0; k < m1.Col; k++)
                        {
                            resultMatrix[i, j] = resultMatrix[i, j] + (dynamic)m1[i, k] * (dynamic)m2[k, j];
                        }
                    }
                }

                return resultMatrix;
            }
            else
            {
                throw new InvalidOperationException();
            }
        }

        public static bool operator true(Matrix<T> matrix)
        {
            for (int i = 0; i < matrix.Row; i++)
            {
                for (int j = 0; j < matrix.Col; j++)
                {
                    if (matrix[i,j] == (dynamic)0)
                    {
                        return false;
                    }
                    
                }
            }
            return true;
        }

        public static bool operator false(Matrix<T> matrix)
        {
            for (int i = 0; i < matrix.Row; i++)
            {
                for (int j = 0; j < matrix.Col; j++)
                {
                    if (matrix[i, j] == (dynamic)0)
                    {
                        return true;
                    }

                }
            }
            return false;
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < this.Row; i++)
            {
                for (int j = 0; j < this.Col; j++)
                {
                    builder.Append(this.matrix[i,j]);
                    builder.Append(" ");
                }
                builder.Append("\n");
            }
            return builder.ToString();
        }
    }
}
