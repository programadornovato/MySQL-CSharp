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
        string idSel = "";
        int sel;
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

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            string query = "";
            string mensajeError = "";
            if (txtInNombre.Text == "") {
                mensajeError = mensajeError + "El nombre no puede estar vacio";
            }
            if (txtInPuesto.Text == "") {
                mensajeError = mensajeError + "El puesto no puede estar vacio";
            }
            if (txtInEdad.Text == "") {
                mensajeError = mensajeError + "La edad no puede estar vacio";
            }
            if (mensajeError == "")
            {
                query = "insert into trabajadores " +
                    "(nombre                ,puesto                ,edad) values " +
                    "('" + txtInNombre.Text + "','" + txtInPuesto.Text + "','" + txtInEdad.Text + "')";
                MySqlCommand comando = new MySqlCommand(query, myCon);
                comando.CommandTimeout = 60;
                MySqlDataReader reader;
                try
                {
                    reader = comando.ExecuteReader();
                    reader.Close();
                    dgTrabajadores.Rows.Clear();
                    dgTrabajadores.Refresh();
                    llenarTabla();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }
            else {
                MessageBox.Show(mensajeError);
            }

        }

        private void dgTrabajadores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            sel = e.RowIndex;
            txtInNombre.Text = dgTrabajadores.Rows[sel].Cells[1].Value.ToString();
            txtInPuesto.Text = dgTrabajadores.Rows[sel].Cells[2].Value.ToString();
            txtInEdad.Text = dgTrabajadores.Rows[sel].Cells[3].Value.ToString();
            idSel = dgTrabajadores.Rows[sel].Cells[0].Value.ToString();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            string query = "";
            string mensajeError = "";
            if (txtInNombre.Text == "")
            {
                mensajeError = mensajeError + "El nombre no puede estar vacio";
            }
            if (txtInPuesto.Text == "")
            {
                mensajeError = mensajeError + "El puesto no puede estar vacio";
            }
            if (txtInEdad.Text == "")
            {
                mensajeError = mensajeError + "La edad no puede estar vacio";
            }
            if (mensajeError == "")
            {
                query = "update trabajadores set " +
                    "nombre='"+txtInNombre.Text+"'," +
                    "puesto='"+txtInPuesto.Text + "',"+
                    "edad='"+txtInEdad.Text + "' " +
                    "where id='"+idSel+"'; ";
                MySqlCommand comando = new MySqlCommand(query, myCon);
                comando.CommandTimeout = 60;
                MySqlDataReader reader;
                try
                {
                    reader = comando.ExecuteReader();
                    reader.Close();
                    dgTrabajadores.Rows.Clear();
                    dgTrabajadores.Refresh();
                    llenarTabla();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }
            else
            {
                MessageBox.Show(mensajeError);
            }

        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            borrar(sel);
        }
        private void borrar(int selBorrar) {
            //sel
            idSel = dgTrabajadores.Rows[selBorrar].Cells[0].Value.ToString();
            string query = "delete from trabajadores where id='" + idSel + "';";
            MySqlCommand comando = new MySqlCommand(query, myCon);
            comando.CommandTimeout = 60;
            MySqlDataReader reader;
            try
            {
                reader = comando.ExecuteReader();
                reader.Close();
                dgTrabajadores.Rows.Clear();
                dgTrabajadores.Refresh();
                llenarTabla();
                txtInNombre.Text = "";
                txtInPuesto.Text = "";
                txtInEdad.Text = "";
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        private void dgTrabajadores_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right) {
                ContextMenuStrip menu =new System.Windows.Forms.ContextMenuStrip();
                int posicion = dgTrabajadores.HitTest(e.X, e.Y).RowIndex;
                if (posicion > -1) {
                    menu.Items.Add("Borrar").Name = "Borrar" + posicion;
                    menu.Items.Add("Mostrar").Name = "Mostrar" + posicion;
                }
                menu.Show(dgTrabajadores, e.X, e.Y);
                menu.ItemClicked += new ToolStripItemClickedEventHandler(munuClick);
            }
        }
        private void munuClick(object sender, ToolStripItemClickedEventArgs e) {
            string id = e.ClickedItem.Name.ToString();
            if (id.Contains("Borrar")) {
                id = id.Replace("Borrar", "");
                borrar(int.Parse(id));
            }
            if (id.Contains("Mostrar")) {
                id = id.Replace("Mostrar", "");
                mostrar(int.Parse(id));
            }
        }
        private void mostrar(int idMostrar) {
            string res = "ID="+dgTrabajadores.Rows[idMostrar].Cells[0].Value.ToString()+"\n";
            res = res + "NOMBRE=" + dgTrabajadores.Rows[idMostrar].Cells[1].Value.ToString() + "\n";
            res = res + "PUESTO=" + dgTrabajadores.Rows[idMostrar].Cells[2].Value.ToString() + "\n";
            res = res + "EDAD=" + dgTrabajadores.Rows[idMostrar].Cells[3].Value.ToString() + "\n";
            MessageBox.Show(res);
        }
    }
}
