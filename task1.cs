using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraviLinkTest
{
    class task1
    {
        static void Main(string[] args)
        {
        }


        // Задача функции: возвращает максимальное количество одиннаковых символов подряд в массиве
        // алгоритмическая  сложность предложенного варианта: O(n^2)
        // Логические дефекты: в случае, если последовательность повторяющихся чисел завершает массив, а также если последовательность состоит только из повторяющихся чисел, то функция работает некорректно
        // алгоритмическая  сложность моей функции: O(n^2)
        static int findMax(int[] a)
        {
            int x, b = 0, lnth = 0;
            for (int i = 0; i < a.Length - 1; i++)
            {
                x = 0;
                for (int j = i + 1; j < a.Length; j++)
                {
                    lnth = j;
                    if (a[i] == a[j])
                    {
                        x++;
                    }
                    else
                    {
                        break;
                    }
                }
                if (x > b)
                {
                    b = x + 1;
                }
                i = lnth - 1;
            }
            return b;
        }
    }
}
