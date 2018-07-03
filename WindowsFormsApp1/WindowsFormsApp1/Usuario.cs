using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    [Serializable]
    public class Usuario
    {
        public string nombre;
        int Puntaje;

        public Usuario(string nombre, int puntaje)
        {
            this.nombre = nombre;
            this.Puntaje = puntaje;
        }
        public string Nombre()
        {
            return this.nombre;
        }
        public bool IngresarUsuario(info OLI)
        {
            if (OLI.GetUsuario(this.nombre) == null)
            {
                OLI.ListaUsuario(this);
                return true;
            }

            return false;


        }

    }
}
