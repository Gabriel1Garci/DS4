using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string connectionString =
        @"Server=localhost;Database=Northwind;TrustServerCertificate=true;Integrated Security=SSPI;";


        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                try
                {
                    conexion.Open();
                    string query = "SELECT ProductName FROM [dbo].[Products]";
                    SqlCommand command = new SqlCommand(query, conexion);
                    SqlDataReader reader = command.ExecuteReader();

                    // Limpiar el ListBox antes de agregar los nuevos elementos
                    listBox1.Items.Clear();

                    while (reader.Read())
                    {
                        // Agregar cada producto al ListBox
                        listBox1.Items.Add(reader["ProductName"].ToString());
                    }

                    reader.Close();
                    MessageBox.Show("Productos cargados exitosamente.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al conectar a la base de datos: " + ex.Message);
                }
            }

        }


        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
