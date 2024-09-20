using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rango__x_y_.clases

//Cree un programa en C# que solicite un rango de números al usuario (x, y)
//y los muestre en pantalla. Si x es mayor que y. mostrar los numeros en orden inverso.
{
   internal class Mayorque
   {
      public List<int> ObtenerNumeros(int x, int y)
      {
         List<int> numeros = new List<int>();

         if (x < y)
         {
            for (int i = x; i <= y; i++)
            {
               numeros.Add(i);
            }
         }
         else
         {
            for (int i = x; i >= y; i--)
            {
               numeros.Add(i);
            }
         }

         return numeros;
      }
   }
}