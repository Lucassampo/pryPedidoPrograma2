using pryInicioSesionLogs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryPedidoPrograma2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        clsUsuario Usuarios = new clsUsuario();
        string Usuario;
        string Contraseña;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCrearUsuario_Click(object sender, EventArgs e)
        {
             Usuario = txtUsuarios.Text;
             Contraseña = txtContraseñas.Text;
             

            Usuarios.RegistroLogInicioSesion();

        }

        private void btnInciar_Click(object sender, EventArgs e)
        {

        }
    }
}
