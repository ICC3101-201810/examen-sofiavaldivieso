using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
namespace WindowsFormsApp1
{
    [Serializable]
    public class info
    {
        
        List<Usuario> us;

        
        public Usuario GetUsuario(string name)
        {

            foreach (Usuario usu in us)
            {

                if (usu.nombre == name)
                {
                    Console.WriteLine(usu.nombre);
                    return usu;
                }
            }
            return null;

            //me falto poner el puntaje, pero basta con recorrer la lista de usuarios que me entrega 
            //la deserializacion, y encontrar el puntaje correspondiente, y ponerlo en el lABEL DE PUNTAJE
            //Tambien me falto poner los cherrys y uvas que suban su valor, pero se hace con un if que vea cuantas veces ha recogido uvas y cherry
            // con un contador y serializarlo para que cuando vuelva a jugar tenga los ultimos valores
        }
        
            public void ListaUsuario(Usuario usuario)
        {
            us.Add(usuario);
            SerializableUsuario(us);

        }
        public void SerializableUsuario(List<Usuario> usuarios)
        {
            try
            {
                using (Stream st = File.Open("../../usuarios.bin", FileMode.Create))
                {
                    BinaryFormatter bf = new BinaryFormatter();
                    bf.Serialize(st, usuarios);
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error" + ex.Message);
            }
        }
        public List<Usuario> DeserealizarUsuario()
        {
            List<Usuario> usuarios;
            try
            {
                using (Stream st = File.Open("../../usuarios.bin", FileMode.Open))
                {
                    BinaryFormatter bf = new BinaryFormatter();
                    usuarios = (List<Usuario>)bf.Deserialize(st);
                }
                return usuarios;

            }
            

            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error" + ex.Message);

                return null;
            }
        }
    }
   
    
    
}
