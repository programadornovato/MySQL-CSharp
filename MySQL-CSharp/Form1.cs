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
        private void btnConectar_Click(object sender, EventArgs e)
        {
            conectar();
            string query = "select id,nombre,puesto,edad from trabajadores;";
            MySqlCommand comandoDB = new MySqlCommand(query, myCon);
            comandoDB.CommandTimeout = 60;
            MySqlDataReader reader;
            try {
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
                else {
                    Console.WriteLine("No hay trabajadores");
                }
            }
            catch (Exception ex) {
                Console.WriteLine(ex);
            }
        }
    }
}
