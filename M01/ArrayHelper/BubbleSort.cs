using System;

namespace ArrayHelper
{
    static public class BubbleSort
    {
        public enum SortDirection
        {
            Asc,
            Desc
        }

        static void Validate(int[] array)
        {
            if (array==null)
            {
                throw new Exception("Array cannot be null.");
            }

            if (array.Length == 0)
            {
                throw new Exception("Array length must be a finite positive integer.");
            }

            
        }
        static public void Sort(int[] array, SortDirection direction)
        {
            Validate(array);
            if (array.Length == 1)
            {
                return;
            }
            int length = array.Length;
            int temp;

            for (int i = 0; i < length; i++)
            {
                for (int j = i + 1; j < length; j++)
                {
                    if ((array[i] > array[j] && direction == SortDirection.Asc)
                        || (array[i] < array[j] && direction == SortDirection.Desc))
                    {
                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }

        }
    }
}
