using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace practice5
{
    internal class Task2
    {
        public class Matrix
        {
            private int row {  get; set; }
            private int col { get; set; }

            private int[,] _arr;

            public Matrix (int row,int col)
            {
                this.row = row;
                this.col = col;

                _arr = new int[row, col];
                
                Random rnd = new Random();

                for (int i = 0; i < row; i++)
                {
                    for (int j = 0; j < col; j++)
                    {
                        _arr[i, j] = rnd.Next(100); 
                    }
                }
            }

            public static Matrix operator +(Matrix a, Matrix b)
            {
                if(a.row == b.row && a.col==b.col)
                {
                    Matrix result = new Matrix(a.row,a.col);

                    for (int i = 0; i < a.row; i++)
                    {
                        for (int j = 0; j < a.col; j++)
                        {
                            result._arr[i, j] = a._arr[i, j] + b._arr[i, j];
                        }
                    }
                    return result;
                }
                else
                {
                    throw new ArgumentException("Matrices must have the same dimensions for addition.");
                }
            }

            public static Matrix operator -(Matrix a, Matrix b)
            {
                if (a.row == b.row && a.col == b.col)
                {
                    Matrix result = new Matrix(a.row, a.col);

                    for (int i = 0; i < a.row; i++)
                    {
                        for (int j = 0; j < a.col; j++)
                        {
                            result._arr[i, j] = a._arr[i, j] - b._arr[i, j];
                        }
                    }
                    return result;
                }
                else
                {
                    throw new ArgumentException("Matrices must have the same dimensions for addition.");
                }
            }

            public static Matrix operator +(Matrix matrix ,int num)
            {
                    Matrix result = new Matrix(matrix.row, matrix.col);

                    for (int i = 0; i < matrix.row; i++)
                    {
                        for (int j = 0; j < matrix.col; j++)
                        {
                            result._arr[i, j] = matrix._arr[i, j] + num;
                        }
                    }
                    return result;
            }

            public override bool Equals(object matrix)
            {
                if(matrix==null || GetType() != matrix.GetType())
                {
                    return false;
                }

                Matrix otherMatrix = (Matrix)matrix;
                if (row != otherMatrix.row || col != otherMatrix.col)
                {
                    return false;
                }

                for (int i = 0; i < row; i++)
                {
                    for (int j = 0; j < col; j++)
                    {
                        if (_arr[i, j] != otherMatrix._arr[i, j])
                        {
                            return false;
                        }
                    }
                }

                return true;
            }
            

                public static void ShowMatrix(Matrix matrix)
            {
                for (int i = 0; i < matrix.row; i++)
                {
                    for (int j = 0; j < matrix.col; j++)
                    {
                        Console.Write(matrix._arr[i, j] + " ");
                    }
                    Console.WriteLine();
                }

            }

        }
    }

}
