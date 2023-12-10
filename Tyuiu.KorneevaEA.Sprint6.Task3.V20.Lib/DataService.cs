using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.KorneevaEA.Sprint6.Task3.V20.Lib
{
    public class DataService : ISprint6Task3V20
    {
        public int[,] Calculate(int[,] matrix)
        {
            int rows = matrix.GetUpperBound(0) + 1;
            int columns = matrix.Length / rows;

            for (int j = 0; j < columns; j++)
            {
                if (matrix[4, j] % 2 == 0)
                {
                    matrix[4, j] = 0;
                }
            }

            return matrix;
        }
    }
}
