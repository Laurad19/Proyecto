using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemadeTaller
{
    public partial class Ingresar : Form
    {
        public Ingresar()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Entrar_Click(object sender, EventArgs e)
        {
            if (this.Usuario.Text == "Laura Duran" || this.Contraseña.Text == "Lauu")
            {
               
                Sistema_interior.Form2 llamar = new Sistema_interior.Form2();
                llamar.Show();
            }
            else
            {
                MessageBox.Show("La contraseña es incorrecta");
            }
        }
    }
}
