using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SistemadeTaller
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {

        }

        private void btnagregar_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnagregardatos_Click(object sender, EventArgs e)
        {
            string RFC, nom, domicilio, tel, email;

            RFC = txtRFC.Text;
            nom = txtnombre.Text;
            domicilio = txtdomicilio.Text;
            tel = txttelefono.Text;
            email = txtcorreo.Text;


            string query = "Insert into Clientes(RFC, Nombre, Domicilio, Teléfono, Correo) VALUES('" + RFC + "','" + nom + "','" + domicilio + "','" + tel + "','" + email + "')";
            OleDbConnection con = new OleDbConnection("Provider=SQLNCLI11;Data Source=LAURA\\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=Administracion");
            OleDbCommand cmd = new OleDbCommand(query, con);
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                txtRFC.Text = "";
                txtnombre.Text = "";
                txtdomicilio.Text = "";
                txttelefono.Text = "";
                txtcorreo.Text = "";
                oleDbDataAdapter1.Fill(dbClientes1);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            string nombre = txtnombre.Text;
            string query = "Delete from Clientes where Nombre =? ";
            OleDbConnection con = new OleDbConnection("Provider=SQLNCLI11;Data Source=LAURA\\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=Administracion");
            OleDbCommand cmd = new OleDbCommand(query, con);
            try
            {
                cmd.Parameters.AddWithValue("@Nombre", nombre);
                con.Open();
                int res = Convert.ToInt32(cmd.ExecuteNonQuery());
                if (res > 0)
                {

                    txtnombre.Text = "  ";
                    txtRFC.Text = "  ";
                    txtdomicilio.Text = "  ";
                    txttelefono.Text = "  ";
                    txtcorreo.Text = "  ";
                    MessageBox.Show("Cliente Eliminado");
                }
                else
                {
                    MessageBox.Show("No se encontro");
                }
                con.Close();
            }
            catch (Exception exep)
            {
                MessageBox.Show(exep.Message, "Error:(");
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            string query = "Select Nombre, RFC, Domicilio, Teléfono, Correo from Clientes where nombre=?";
            string nombre = txtnombre.Text;
            OleDbConnection con = new OleDbConnection("Provider=SQLNCLI11;Data Source=LAURA\\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=Administracion");
            OleDbCommand cmd = new OleDbCommand(query, con);
            try
            {
                cmd.Parameters.AddWithValue("@Nombre", nombre);
                con.Open();
                OleDbDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    txtnombre.Text = dr.GetString(0);
                    txtRFC.Text = dr.GetString(1);
                    txtdomicilio.Text = dr.GetString(2);
                    txttelefono.Text = dr.GetValue(3).ToString();
                    txtcorreo.Text = dr.GetString(4);
                }
                else
                {
                    txtnombre.Text = "No se encontró";
                    txtRFC.Text = "  ";
                    txtdomicilio.Text = "  ";
                    txttelefono.Text = "  ";
                    txtcorreo.Text = "  ";
                }
                dr.Close();

                con.Close();
            }
            catch (Exception exep)
            {
                MessageBox.Show(exep.Message, "Cliente no encontrado");
            }
        }

        private void Regresara_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnmodificar_Click_1(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection("Provider=SQLNCLI11;Data Source=LAURA\\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=Administracion");
            con.Open();
            string query = "UPDATE Clientes SET RFC = '" + txtRFC.Text + "', Domicilio = '" + txtdomicilio.Text + "', Teléfono = '" + txttelefono.Text + "', Correo='" + txtcorreo.Text + "' WHERE Nombre = '" + txtnombre.Text + "'";
            OleDbCommand cmd = new OleDbCommand(query, con);
            cmd.ExecuteNonQuery();
        
           
            MessageBox.Show("Datos Actualizados");
            con.Close();
        }
    }
}
