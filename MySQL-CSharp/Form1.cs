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
namespace MySQL_CSharp
{
    public partial class Form1 : Form
    {
        MySqlConnection myCon;
        public Form1()
        {
            InitializeComponent();
            conectar();
            llenarTabla();
        }
        private void conectar() {
            try
            {
                string server = "localhost";
                string database = "empleados";
                string user = "root";
                string pwd = "123456";
                string cadenaConexion = "server=" + server + ";database=" + database + ";" + "Uid=" + user + ";pwd=" + pwd + ";";
                myCon = new MySqlConnection(cadenaConexion);
                myCon.Open();
                lblResultado.Text = "Conexion exitosa";
            }
            catch (Exception error)
            {
                lblResultado.Text = "Error de conexion " + error;
            }
        }
        private void llenarTabla() {
            string query = "select id,nombre,puesto,edad from trabajadores;";
            MySqlCommand comandoDB = new MySqlCommand(query, myCon);
            comandoDB.CommandTimeout = 60;
            MySqlDataReader reader;
            try
            {
                reader = comandoDB.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        int n = dgTrabajadores.Rows.Add();
                        dgTrabajadores.Rows[n].Cells[0].Value = reader.GetString(0);
                        dgTrabajadores.Rows[n].Cells[1].Value = reader.GetString(1);
                        dgTrabajadores.Rows[n].Cells[2].Value = reader.GetString(2);
                        dgTrabajadores.Rows[n].Cells[3].Value = reader.GetString(3);
                        //MessageBox.Show(reader.GetString(0));
                    }
                }
                else
                {
                    Console.WriteLine("No hay trabajadores");
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string where = " where 1=1 ";
            //Si el nombre no esta vacio
            if (txtBusNombre.Text != "")
            {
                where = where + " and nombre like'%" + txtBusNombre.Text + "%' ";
            }
            //Si el puesto no esta vacio
            if (txtBusPuesto.Text != "")
            {
                where = where + " and puesto like'%" + txtBusPuesto.Text + "%' ";
            }
            //Si la edad no esta vacio
            if (txtBusEdad.Text != "")
            {
                where = where + " and edad like'%" + txtBusEdad.Text + "%' ";
            }
            string query = "select id,nombre,puesto,edad from trabajadores " + where + " ;";
            MySqlCommand comandoDB = new MySqlCommand(query, myCon);
            comandoDB.CommandTimeout = 60;
            MySqlDataReader reader;
            dgTrabajadores.Rows.Clear();
            dgTrabajadores.Refresh();
            try
            {
                reader = comandoDB.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        int n = dgTrabajadores.Rows.Add();
                        dgTrabajadores.Rows[n].Cells[0].Value = reader.GetString(0);
                        dgTrabajadores.Rows[n].Cells[1].Value = reader.GetString(1);
                        dgTrabajadores.Rows[n].Cells[2].Value = reader.GetString(2);
                        dgTrabajadores.Rows[n].Cells[3].Value = reader.GetString(3);
                        //MessageBox.Show(reader.GetString(0));
                    }
                }
                else
                {
                    Console.WriteLine("No hay trabajadores");
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
