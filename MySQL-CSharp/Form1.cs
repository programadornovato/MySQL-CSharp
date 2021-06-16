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
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            try
            {
                string server = "localhost";
                string database = "empleados";
                string user = "root";
                string pwd = "123456";
                string cadenaConexion = "server=" + server + ";database=" + database + ";" + "Uid=" + user + ";pwd=" + pwd + ";";
                MySqlConnection myCon = new MySqlConnection(cadenaConexion);
                myCon.Open();
                lblResultado.Text = "Conexion exitosa";
            }
            catch (Exception error) {
                lblResultado.Text = "Error de conexion "+ error;
            }
        }
    }
}
