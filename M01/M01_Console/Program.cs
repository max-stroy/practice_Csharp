using System;
using System.Globalization;

namespace M01_Console
{
    class Program
    {
        static void PrintArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + ", ");
            }
        }

        static void PrintMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + ", ");
                }
                Console.WriteLine();
            }

        }


        static void Main(string[] args)
        {
            //int[] array = new int[] { 5, 1, 3, 20, 2, 7, 22 };
            //PrintArray(array);

            //Console.WriteLine();
            //ArrayHelper.BubbleSort.Sort(array, ArrayHelper.BubbleSort.SortDirection.Asc);
            //PrintArray(array);

            //Console.WriteLine();
            //ArrayHelper.BubbleSort.Sort(array, ArrayHelper.BubbleSort.SortDirection.Desc);
            //PrintArray(array);

            //Console.WriteLine();

            //int[] array2 = null;
            //try
            //{
            //    ArrayHelper.BubbleSort.Sort(array2, ArrayHelper.BubbleSort.SortDirection.Desc);
            //}
            //catch (Exception err)
            //{
            //    Console.WriteLine(err.Message);
            //}

            //int[] array3 = new int[] { };
            //try
            //{
            //    ArrayHelper.BubbleSort.Sort(array3, ArrayHelper.BubbleSort.SortDirection.Desc);
            //}
            //catch (Exception err)
            //{
            //    Console.WriteLine(err.Message);
            //}

            //int[,] matrix1 = new int[,] { { 1, 1, 1 }, { 1, 1, -8 }, { 1, 1, -1 }, { 1, 1, 1 } };
            //PrintMatrix(matrix1);
            //Console.WriteLine("Sum of all positive elements in matrix is " + ArrayHelper.Calculations.Sum(matrix1));



            //int[,] matrix2 = null;
            //try
            //{
            //    Console.WriteLine("Sum of all positive elements in matrix is " + ArrayHelper.Calculations.Sum(matrix2));
            //}
            //catch (Exception err)
            //{
            //    Console.WriteLine(err.Message);
            //}

            //int[,] matrix3 = new int[,] { { 4 } };
            //PrintMatrix(matrix3);
            //try
            //{
            //    Console.WriteLine("Sum of all positive elements in matrix is " + ArrayHelper.Calculations.Sum(matrix3));
            //}
            //catch (Exception err)
            //{
            //    Console.WriteLine(err.Message);
            //}

            //Console.WriteLine("Perimeter of rectangle " + 5 + "*" + 8 + " is " + RectangleHelper.Calculations.Perimeter(5.0, 8.0));
            //Console.WriteLine("Square of rectangle " + 5 + "*" + 8 + " is " + RectangleHelper.Calculations.Square(5.0, 8.0));
            //Console.WriteLine("Square of rectangle " + 5 + "*" + 8 + " is " + RectangleHelper.Calculations.Square(-5.0, 8.0));
            //Console.WriteLine("Square of rectangle " + 5 + "*" + 8 + " is " + RectangleHelper.Calculations.Square(0, 8.0));
            Console.WriteLine("CULTURE ISO ISO WIN DISPLAYNAME                              ENGLISHNAME");
            foreach (CultureInfo ci in CultureInfo.GetCultures(CultureTypes.NeutralCultures))
            {
                Console.Write("{0,-7}", ci.Name);
                Console.Write(" {0,-3}", ci.TwoLetterISOLanguageName);
                Console.Write(" {0,-3}", ci.ThreeLetterISOLanguageName);
                Console.Write(" {0,-3}", ci.ThreeLetterWindowsLanguageName);
                Console.Write(" {0,-40}", ci.DisplayName);
                Console.WriteLine(" {0,-40}", ci.EnglishName);
            }

            while (true)
            {
                var input = Console.ReadLine();
                if (input.Equals("exit", StringComparison.OrdinalIgnoreCase))
                {
                    break;
                }
                var n = input.Split(';');
                double a, b;
                if (!string.IsNullOrWhiteSpace(input) && n != null && n.Length == 2
                    && double.TryParse(n[0], NumberStyles.Any, CultureInfo.GetCultureInfo("ru"), out a)
                    && double.TryParse(n[1], NumberStyles.Any, CultureInfo.InvariantCulture, out b))
                {
                    try
                    {
                        var result = RectangleHelper.Calculations.Perimeter(a, b);
                        Console.WriteLine("Perimeter {0}x{1}={2:e}", a, b, result);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }

            }

        }
    }
}
