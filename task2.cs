using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraviLinkTest
{
    class task2
    {
        // Для решения задания мной была реализована структура вектора, которая имеет три параметра X,Y,Z соотвтетственно
        // Булевая функиция AreVectorsPerp проверяет векторы на перпендикулярность: если сумма произведений соответствуюших координат равна 0, то векторы перпендикулярны

        struct vector
        {
            public int x;
            public int y;
            public int z;
            public vector(int x, int y, int z)
            {
                this.x = x;
                this.y = y;
                this.z = z;
            }
        }
        static bool AreVectorsPerp(vector vector1, vector vector2)
        {
            int result = vector1.x * vector2.x + vector1.y * vector2.y + vector1.z * vector2.z;
            if (result == 0) return true;
            else return false;
        }
    }
}
