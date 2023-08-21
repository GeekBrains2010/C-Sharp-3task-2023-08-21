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
            int max = array[0];
            int max1 = array[0];

            for (int i = 0; i < array.Length; i++)
            {
                if (max < array[i])
                {
                    max = array[i];
                }
            }
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] != max & max1 < array[i])
                {
                    max1 = array[i];
                }
            }

            return max1;

        }
    }
}
