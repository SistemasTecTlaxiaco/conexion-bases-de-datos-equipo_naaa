using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;

namespace Conexion_MySQL_PRACTICA1
{
    public partial class Conexion_BaseDatos : Form
    {
        public Conexion_BaseDatos()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.FlatStyle = FlatStyle.Flat;
            button1.FlatAppearance.BorderSize = 8;
            button1.FlatAppearance.BorderColor = Color.Black;

            // Definimos los datos necesarios para conectarnos al servidor de base de datos
            string server = "localhost"; // Dirección del servidor, en este caso la misma máquina
            string port = "3307"; // Puerto donde se ejecuta MariaDB
            string database = "empleados"; // Nombre de la base de datos a la que se quiere conectar
            string user = "root"; // Usuario con permisos para acceder
            string password = "Nallely09"; // Contraseña del usuario

            // Se construye la cadena de conexión con todos los datos necesarios
            string cadenaConexion = $"server={server};port={port};database={database};user={user};password={password};";

            // Se crea una instancia de la conexión utilizando la cadena generada
            MySqlConnection myConection = new MySqlConnection(cadenaConexion);

            // Se intenta abrir la conexión con la base de datos
            myConection.Open();

        }
    }
}
