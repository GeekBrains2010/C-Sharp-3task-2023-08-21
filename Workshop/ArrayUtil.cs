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
            foreach(int item in array)
            {
                if (max < item)
                {
                    max = item;
                }
            }
            int secondMax = int.MinValue;
            for(int i = 0; i < array.Length; i++)
            {
                if (array[i] == max)
                {
                    continue;
                }
                if (array[i] > secondMax)
                {
                    secondMax = array[i];
                }
            }
            return secondMax;
        }
    }
}
