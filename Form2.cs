using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_interior
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnclientes_Click(object sender, EventArgs e)
        {

            SistemadeTaller.Form3 llamar = new SistemadeTaller.Form3();
            llamar.Show();
        }

        private void btnautos_Click(object sender, EventArgs e)
        {
            SistemadeTaller.Administracion_de_Autos llamar = new SistemadeTaller.Administracion_de_Autos();
            llamar.Show();
        }
    }
}
