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
using Microsoft.Reporting.WinForms;

namespace examen34
{
    public partial class Reporte : Form
    {
        public Reporte()
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
        private void Reporte_Load(object sender, EventArgs e)
        {

            this.rptComputadora.RefreshReport();
        }

        private void btnMostrarReporte_Click(object sender, EventArgs e)
        {
            try
            {
                string consulta = "SELECT * FROM computadora";
                MySqlDataAdapter da = new MySqlDataAdapter(consulta, conexion());
                DataSet ds = new DataSet();
                da.Fill(ds);
                ReportDataSource fuente = new ReportDataSource("computadora", ds.Tables[0]);
                rptComputadora.LocalReport.DataSources.Clear();
                rptComputadora.LocalReport.DataSources.Add(fuente);
                rptComputadora.LocalReport.ReportEmbeddedResource = "examen34.reportecomputadora.rdlc";
                rptComputadora.LocalReport.Refresh();
                rptComputadora.Refresh();
                rptComputadora.RefreshReport();

                MessageBox.Show("MOSTRADO CON ÉXITO");
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR\n"+ex.Message); 
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }
    }
}
