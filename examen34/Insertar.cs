using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient; 

namespace examen34
{
    public partial class Insertar : Form
    {
        public Insertar()
        {
            InitializeComponent();
        }

        public static MySqlConnection conexion()
        {
            string conexion = "SERVER=localhost; PORT=3306; UID=root; PASSWORDS=;database=examen34";
            try
            {
                MySqlConnection conexionbd = new MySqlConnection(conexion);
                return conexionbd;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("IMPOSIBLE CONECTARSE" + ex.Message);
                return null;
            }
        }
        private void btnInsertar_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(txtID.Text);
                string marca = txtMarca.Text;
                string modelo = (txtModelo.Text);
                int cantidad = int.Parse(txtCantidad.Text);
                double precio = double.Parse(txtPrecio.Text);
                string sql = "INSERT INTO COMPUTADORA (id,marca,modelo,cantidad,precio) VALUES('" + id + "','" + marca + "','" + modelo + "','" + cantidad + "','" + precio + "')";
                MySqlConnection conexionbd = conexion();
                conexionbd.Open();

                MySqlCommand comando = new MySqlCommand(sql, conexionbd);
                comando.ExecuteNonQuery();
                MessageBox.Show("GUARDADO");

                conexionbd.Close();
                limpiar();

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR" + ex.Message);
            }


        }
        private void limpiar()
        {
            txtID.Text = "";
            txtMarca.Text = "";
            txtModelo.Text = "";
            txtCantidad.Text = "";
            txtPrecio.Text = "";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }
    }
}
