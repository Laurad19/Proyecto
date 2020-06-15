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
    public partial class Administracion_de_Autos : Form
    {
        public Administracion_de_Autos()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            string placa, marca, modelo, color;

            placa = txtplaca.Text;
            marca = txtmarca.Text;
            modelo = txtmodelo.Text;
            color = txtcolor.Text;
            


            string query = "Insert into Clientes(Placa, Marca, Modelo, Color) VALUES('" + placa + "','" + marca + "','" + modelo + "','" +color + "')";
            OleDbConnection con = new OleDbConnection("Provider=SQLNCLI11;Data Source=LAURA\\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=Administracion");
            OleDbCommand cmd = new OleDbCommand(query, con);
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                txtplaca.Text = "";
                txtmarca.Text = "";
                txtmodelo.Text = "";
                txtcolor.Text = "";
                
                oleDbDataAdapter1.Fill(dbAutos1);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Regresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            string Placa = txtplaca.Text;
            string query = "Delete from Autos where Placa =? ";
            OleDbConnection con = new OleDbConnection("Provider=SQLNCLI11;Data Source=LAURA\\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=Administracion");
            OleDbCommand cmd = new OleDbCommand(query, con);
            try
            {
                cmd.Parameters.AddWithValue("@Placa", Placa);
                con.Open();
                int res = Convert.ToInt32(cmd.ExecuteNonQuery());
                if (res > 0)
                {

                    txtplaca.Text = "  ";
                    txtmarca.Text = "  ";
                    txtmodelo.Text = "  ";
                    txtcolor.Text = "  ";
                    
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

        private void btnbuscarau_Click(object sender, EventArgs e)
        {
            string query = "Select Nombre, RFC, Domicilio, Teléfono, Correo from Clientes where nombre=?";
            string Placa = txtplaca.Text;
            OleDbConnection con = new OleDbConnection("Provider=SQLNCLI11;Data Source=LAURA\\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=Administracion");
            OleDbCommand cmd = new OleDbCommand(query, con);
            try
            {
                cmd.Parameters.AddWithValue("@Placa", Placa);
                con.Open();
                OleDbDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    txtplaca.Text = dr.GetString(0);
                    txtmarca.Text = dr.GetString(1);
                    txtmodelo.Text = dr.GetString(2);
                    txtcolor.Text = dr.GetString(3);
                    
                }
                else
                {
                    txtplaca.Text = "No se encontró";
                    txtmarca.Text = "  ";
                    txtmodelo.Text = "  ";
                    txtcolor.Text = "  ";
                    
                }
                dr.Close();

                con.Close();
            }
            catch (Exception exep)
            {
                MessageBox.Show(exep.Message, "Auto no encontrado");
            }
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection("Provider=SQLNCLI11;Data Source=LAURA\\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=Administracion");
            con.Open();
            string query = "UPDATE Clientes SET marca ='" + txtmarca.Text + "', modelo = '" + txtmodelo.Text + "', color ='" + txtcolor.Text + "' WHERE Placa = '" + txtplaca.Text + "'";
            OleDbCommand cmd = new OleDbCommand(query, con);
            cmd.ExecuteNonQuery();

            MessageBox.Show("Datos Actualizados");
            con.Close();
        }
    }
    }

