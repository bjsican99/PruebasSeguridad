using CapaVistaSeguridad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejecucion
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //inicio:
            //    bool bolAutorizacion;
            //    frmLogin frm = new frmLogin();
            //    if (frm.ShowDialog() == DialogResult.OK)
            //    {
            //        bolAutorizacion = frm.Verificacion;

            //        if (bolAutorizacion == false)
            //        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MDI());
            //        frmInicio ini = new frmInicio();
            //        ini.Show();
            //    }
            //    else
            //    {
            //        MessageBox.Show("Usuario o Contraseña incorrecta" + bolAutorizacion);
            //        goto inicio;
            //    }
            //}
        }
    }
}
