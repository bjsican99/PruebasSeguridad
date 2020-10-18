using CapaVistaSeguridad;
using CapaVistaSeguridad.Formularios;
using CapaVistaSeguridad.Formularios.Mantenimientos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pruebas
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            frmLogin frm = new frmLogin();
            frm.ShowDialog();
            txtusuario.Text = frm.usuario();
        }

        private void mantenimientosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void asignacionDeAplicacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsFuncionesSeguridad seguridad = new clsFuncionesSeguridad();
            if(seguridad.PermisosAcceso(txtAplicacion.Text, txtusuario.Text) == 1)
            {
                frmAsignacionDeAplicaciones asignacion = new frmAsignacionDeAplicaciones();
                asignacion.Show();
            }
            else
            {
                MessageBox.Show("No funciona :)");
            }         
        }

        private void pruebasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAsignacionDeAplicaciones asignacion = new frmAsignacionDeAplicaciones();
            asignacion.Show();
        }

        private void aplicacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_aplicacion aplicacion = new frm_aplicacion();
            aplicacion.Show();
        }

        private void perfilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMantenimientoPerfil mantenimientoPerfil = new frmMantenimientoPerfil();
            mantenimientoPerfil.Show();

        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_mantenimiento_usuario mantenimiento_Usuario = new frm_mantenimiento_usuario();
            mantenimiento_Usuario.Show();
        }

        private void asignacionDePerfilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAsignarAplicacionesAPerfil asignarAplicacionesAPerfil = new frmAsignarAplicacionesAPerfil();
            asignarAplicacionesAPerfil.Show();
        }
    }
}
