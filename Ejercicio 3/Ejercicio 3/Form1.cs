using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[,] matrizValues = new int[4, 4];
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    int TextBoxIndex = i * 4 + j + 1; //Formula que calcula el indice de la caja
                    string TextBoxName = "tbText" + TextBoxIndex.ToString();
                    TextBox textBox = (TextBox)this.Controls[TextBoxName];
                    matrizValues[i, j] = int.Parse(textBox.Text);
                }
            }
            {
                Matriz matriz = new Matriz(matrizValues);

                int[,] sumMatriz = matriz.CalculateSum();

                for (int i = 0; i < 4; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        int TextBoxIndex = i * 4 + j + 1;
                        string TextBoxName = "tbText" + TextBoxIndex.ToString();
                        TextBox textBox = (TextBox)this.Controls[TextBoxName];
                        textBox.Text = sumMatriz[i, j].ToString();
                    }
                }
            }
        }
    }
}
