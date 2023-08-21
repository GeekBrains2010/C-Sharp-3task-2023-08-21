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
            int firstMax = 0;
            int secondMax = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (firstMax < array[i]) firstMax = array[i];
                if (secondMax > array[i] && secondMax < firstMax) secondMax = array[i];

            }
            return firstMax;
        }
        public static void Main(String[] arggs)
        {
            int[] array = { 2, 4, 5, 11, 7 };
            Console.WriteLine(SecondMax(array));
        }
    }
}
