using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayHelper
{
    public class Calculations
    {
        static void Validate(int[,] matrix)
        {
            if (matrix == null)
            {
                throw new Exception(" ArrayHelper. Validate. Matrix cannot be null.");
            }

        }

        public static int Sum(int[,] matrix)
        {
            Validate(matrix);
            int tempSum = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] > 0)
                    {
                        tempSum += matrix[i, j];
                    }
                }
            }
            return tempSum;

        }
    }
}
