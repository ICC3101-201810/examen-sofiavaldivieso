using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace WindowsFormsApp1
{
    static class Program
    {
        public static void Main(string[] args)
        {
            StreamWriter sw = File.AppendText("../../Logging.txt");
            info i = new info();
            List<Usuario> Usuarios = i.DeserealizarUsuario();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

        }
        

        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        //[STAThread]
        //static void Main()
        //{
          //  Application.EnableVisualStyles();
          //  Application.SetCompatibleTextRenderingDefault(false);
          //  Application.Run(new Form1());
        //}
    }
}
