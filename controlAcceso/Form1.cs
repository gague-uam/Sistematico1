using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace controlAcceso
{
    public partial class Form1 : Form
    {
        private int attempts = 0;
        private const int maxAttempts = 3;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int user;
            int password;

            // Verificar si el usuario ha introducido valores numéricos
            bool isUserValid = int.TryParse(tbUser.Text, out user);
            bool isPasswordValid = int.TryParse(tbPassword.Text, out password);

            // Verificar si el nombre de usuario y la contraseña son números enteros
            if (!isUserValid || !isPasswordValid)
            {
                MessageBox.Show("El nombre de usuario y la contraseña deben ser números enteros.", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Verificar las credenciales
            if (user == 12 && password == 1234)
            {
                MessageBox.Show("Inicio de sesión exitoso.", "Acceso concedido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Aquí puedes redirigir al usuario a otra parte de la aplicación si es necesario
                return;
            }
            else
            {
                attempts++;
                if (attempts >= maxAttempts)
                {
                    MessageBox.Show("Has excedido el número máximo de intentos. El acceso ha sido bloqueado.", "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    // Deshabilitar el botón de inicio de sesión después de 3 intentos fallidos
                    btnAdd.Enabled = false;
                }
                else
                {
                    MessageBox.Show($"Credenciales incorrectas. Te quedan {maxAttempts - attempts} intentos.", "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void tbUser_TextChanged(object sender, EventArgs e)
        {
            // Opcional: Lógica adicional si se desea.
        }

        private void tbPassword_TextChanged(object sender, EventArgs e)
        {
            // Opcional: Lógica adicional si se desea.
        }
    }
}
