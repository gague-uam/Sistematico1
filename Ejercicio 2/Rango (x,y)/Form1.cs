using Rango__x_y_.clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rango__x_y_
{
   public partial class Form1 : Form
   {
      public Form1()
      {
         InitializeComponent();
      }

      private void btnMostrar_Click(object sender, EventArgs e)
      {
         int x, y;

         if (int.TryParse(txtX.Text, out x) && int.TryParse(txtY.Text, out y))
         {
            Mayorque rango = new Mayorque();
            var numeros = rango.ObtenerNumeros(x, y);

            listBoxResultados.Items.Clear();

            foreach (var numero in numeros)
            {
               listBoxResultados.Items.Add(numero);
            }
         }
         else
         {
            MessageBox.Show("Por favor, ingrese números válidos.");
         }
      }
   }
}