using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    
    public partial class Form1 : Form
    {
        public info i;

        
        public Form1(info inf)
        {
            i = inf;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void buttonc_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Debe completar la informacion");
                return;
            }
            else
            {
                string nombre = textBox1.Text;
                Usuario usuario = new Usuario(nombre);
                if (usuario.IngresarUsuario(i))
                {
                    usuario.IngresarUsuario(i);
                    System.Windows.Forms.MessageBox.Show("Usuario Ingresado correctamente, su Nº de credencial " + usuario.name);


                    juego w2 = new juego();
                    this.Hide();
                    w2.Show();
                }
                else { return; }
                
            }
            
        }
    }
}
