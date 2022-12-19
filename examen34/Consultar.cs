﻿using System;
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
    public partial class Consultar : Form
    {
        public Consultar()
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
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(txtID.Text);
                MySqlDataReader lector = null;
                string sql = "SELECT ID, MARCA, MODELO, CANTIDAD, PRECIO FROM COMPUTADORA  WHERE id = '" + id + "'";
                MySqlConnection conexionbd = conexion();
                conexionbd.Open();
                MySqlCommand comando = new MySqlCommand(sql, conexionbd);
                lector = comando.ExecuteReader();
                if (lector.HasRows)
                {
                    while (lector.Read())
                    {
                        txtID.Text = lector.GetString(0);
                        txtMarca.Text = lector.GetString(1);
                        txtModelo.Text = lector.GetString(2);
                        txtCantidad.Text = lector.GetString(3);
                        txtPrecio.Text = lector.GetString(4); 
                    }
                }
                else
                {
                    MessageBox.Show("NO SE ENCONTRARON REGISTROS");
                }
                conexionbd.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR" + ex.Message);
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void limpiar()
        {
            txtID.Text = "";
            txtMarca.Text = "";
            txtModelo.Text = "";
            txtCantidad.Text = "";
            txtPrecio.Text = "";
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }
    }
    }

