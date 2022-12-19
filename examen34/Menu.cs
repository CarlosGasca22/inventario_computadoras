using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace examen34
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        

        private void iNSERTARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Insertar ins = new Insertar();
            ins.Show();
        }

        private void cONSULTARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Consultar cons = new Consultar();
            cons.Show();
        }

        private void eLIMINARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Eliminar elim = new Eliminar();
            elim.Show();
        }

        private void mODIFICARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Modificar modif = new Modificar();
            modif.Show();
        }

        private void sALIRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lISTARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Listar list = new Listar();
            list.Show();
        }

        private void rEPORTEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reporte report = new Reporte();
            report.Show(); 
        }

    }
}
