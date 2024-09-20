using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3.models
{
    internal class Matriz
    {
        private int[,] values; 
        public Matriz(int [,] values)
        {
            this.values = values;
        }
   
    public int GetValue (int row, int col)
        {
            return values[row, col];
        }
        public static Matriz Add(Matriz matriz_1, Matriz matriz_2)
        {
            int[,] resultValues = new int[4,4];

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    resultValues[i, j] = matriz_1.GetValue(i, j) + matriz_2.GetValue(i, j);
                }
            }
            return new Matriz(resultValues);
        }
          
    }
}
