using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraviLinkTest
{
    class task5
    {
        // Алгоритмическая сложность : O(n^2)
        static List<T> NoEvenObj<T>(List<T> objects)
        {
            int counter;
            List<T> answer = new List<T>();
            List<T> incorrect = new List<T>();
            for (int i = 0; i <= objects.Count - 1; i++)
            {
                counter = 1;
                if (incorrect.Contains(objects[i])) continue;
                for (int j = i + 1; j < objects.Count; j++)
                {
                    if (objects[i].Equals(objects[j]) && objects[j] != null)
                    {
                        counter++;
                    }
                }
                if (counter % 2 != 0)
                    answer.Add(objects[i]);
                else
                    incorrect.Add(objects[i]);
            }

            return answer;
        }
    }
}
