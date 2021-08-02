using System;

namespace RectangleHelper
{
    /// <summary>
    ///  This class allows to calculate perimeter and square of a rectangle.
    /// </summary>
    public class Calculations
    {
        // TODO проверить в гугле корректность перевода описания.
        /// <summary>
        /// This method calculate perimeter of a rectangle. 
        /// </summary>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <returns></returns>
        static public double Perimeter(double width, double height)
        {
            Validate(width, height);
            return 2 * (width + height);
        }

        static public double Square(double width, double height)
        {
            Validate(width, height);
            return width * height;
        }

        static private void Validate(double width, double height)
        {
            if (width <= 0 || height <= 0)
            {
                throw new Exception("Size must be > 0");
            }
        }
    }
}
