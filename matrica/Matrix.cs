    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matrica
{
    class Matrix
    {
        public int[,] numbers;
        
        public Matrix(int i, int j)
        {
            numbers = new int[i, j];
        }

        public Matrix()
        {
            numbers = new int[5, 5];
        }

        public Matrix(int i, int j, int min, int max)
        {

            numbers = new int[i, j];
            Random random = new Random();
           for(int g = 0; g < numbers.GetLength(0); g++)
            {
                for(int b = 0; b < numbers.GetLength(1); b++)
                {
                    numbers[g, b] = random.Next(min, max + 1);
                }
            }
        }
        public Matrix(int[,] _numbers)
        {
            numbers = _numbers;
        }
    }
}
