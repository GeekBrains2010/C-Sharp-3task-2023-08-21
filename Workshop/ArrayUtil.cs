using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop
{
    public static class ArrayUtil
    {
        public static int SecondMax(int[] array)
        {
            /* Здесь надо написать алгоритм поиска второго максимума, пример: 
             * массив: [2, 4, 5, 3], результат: 4
             * массив: [2, 6, 5, 3], результат: 5
             */
            int firstMax = array[0];
            int secondMax = int.MinValue;
            for (int i = 1; i < array.Length; i++)
            {
                if (firstMax < array[i])
                {
                    firstMax = array[i];
                    secondMax = array[i - 1];
                }
                else if (array[i] != firstMax && array[i] > secondMax) secondMax = array[i];
            }
            return secondMax;
        }
    }
}
