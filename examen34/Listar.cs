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
    public partial class Listar : Form
    {
        public Listar()
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
        private void btnRegistros_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter();
                MySqlCommand comm = new MySqlCommand("SELECT * FROM COMPUTADORA", conexion());
                sda.SelectCommand = comm;
                DataTable table = new DataTable();
                sda.Fill(table);
                dataGridViewCOMPUTADORA.DataSource = table;
                MessageBox.Show("MOSTRADO CON ÉXITO");
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR\n"+ ex.Message); 
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
