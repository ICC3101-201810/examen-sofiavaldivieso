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
    public partial class juego : Form

    {
        bool arriba;
        bool abajo;
        bool izquierda;
        bool derecha;
        int speed = 5;
        int fantasma1 = 8;
        int fantasma2 = 8;
        int fantasmarojox = 8;
        int fantasmarojoy = 8;
        int puntaje = 0;
        public juego()
        {
            InitializeComponent();
            label2.Visible = false;
        }

        private void keyisdown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Left)
            {
                izquierda = true;
                pac.Image = Properties.Resources.pacman_left;
                
            }
            if (e.KeyCode == Keys.Right)
            {
                derecha = true;
                pac.Image = Properties.Resources.pacman_right;

            }
            if (e.KeyCode == Keys.Up)
            {
                arriba = true;
                pac.Image = Properties.Resources.pacman_up;

            }
            if (e.KeyCode == Keys.Down)
            {
                abajo = true;
                pac.Image = Properties.Resources.pacman_down;

            }


        }

        private void keyisup(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Left)
            {
                izquierda = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                derecha = false;
            }
            if (e.KeyCode == Keys.Up)
            {
                arriba = false;
            }
            if (e.KeyCode == Keys.Down)
            {
                abajo = false;
            }


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = "puntaje" + puntaje;
            if (izquierda)
            {
                pac.Left -= speed;

            }
            if (derecha)
            {
                pac.Left += speed;

            }
            if (arriba)
            {
                pac.Top -= speed;

            }
            if (abajo)
            {
                pac.Top += speed;

            }
            fantasmarojo.Left += fantasma1;
            fantasmarosado.Left += fantasma2;
            if (fantasmarojo.Bounds.IntersectsWith(this.Bounds))
            {
                fantasma1 = -fantasma1;
            }
            if (fantasmarosado.Bounds.IntersectsWith(this.Bounds))
            {
                fantasma2 = -fantasma2;
            }
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && x.Tag == "ghost")
                {
                    if (((PictureBox)x).Bounds.IntersectsWith(pac.Bounds))
                    {
                        pac.Left = 0;
                        pac.Top = 25;
                        label2.Text = "GAME OVER";
                        label2.Visible = true;
                        timer1.Stop();
                    }

                }
                if (x is PictureBox && x.Tag == "verde")
                {
                    if (((PictureBox)x).Bounds.IntersectsWith(pac.Bounds))
                    {
                        this.Controls.Remove(x); 
                        puntaje+=15; 
                    }
                }
                if (x is PictureBox && x.Tag == "cherry")
                {
                    if (((PictureBox)x).Bounds.IntersectsWith(pac.Bounds))
                    {
                        this.Controls.Remove(x);
                        puntaje+=10;
                    }
                }
            }

        }



        private void juego_Load(object sender, EventArgs e)
        {

        }

        private void pac_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();


        }
    }
}
