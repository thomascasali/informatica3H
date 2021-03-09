using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forza4
{
    public partial class Form1 : Form
    {
        static int[,] forza4 = new int[6, 7];
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    forza4[i, j] = 0;
                }
            }
            //inserimento di 3 gettoni per test del metodo
            /*
            forza4[5, 0] = 1; //gettone del giocatore 1
            forza4[4, 0] = 2; //gettone del giocatore 2
            forza4[5, 1] = 2; //gettone del giocatore 2
            MessageBox.Show("La prima riga libera del campo nella colonna 0 è: " + Riga(0).ToString());
            MessageBox.Show("La prima riga libera del campo nella colonna 1 è: " + Riga(1).ToString());
            MessageBox.Show("La prima riga libera del campo nella colonna 2 è: " + Riga(2).ToString());
            */
            //fine test

            //test creazione bottone
            Button b = new Button();
            this.Controls.Add(b);
            b.Text = "Il mio bottone";
            b.Top = 10;
            b.Left = 10;
            b.Height = 20;
            b.Width = 100;

            //test creazione PictureBox
            PictureBox p = new PictureBox();
            this.Controls.Add(p);
            p.Top = 40;
            p.Left = 10;
            p.Height = 40;
            p.Width = 40;
            //p.BackColor = Color.Red;
            p.Image = Properties.Resources.Gettonerosso;
            p.SizeMode = PictureBoxSizeMode.StretchImage;
            p.Click += new EventHandler(Cliccato);

            for(int i = 0; i < 10; i++)
            {
                PictureBox pic = new PictureBox();
                this.Controls.Add(pic);
                pic.Top = 100;
                pic.Left = 10+i*20;
                pic.Height = 20;
                pic.Width = 20;
                if (i % 2 == 0) {
                    pic.BackColor = Color.Red;
                }
                else
                {
                    pic.BackColor = Color.Yellow;
                }

            }


        }

        public void Cliccato(object sender, EventArgs e)
        {
            MessageBox.Show("Ciao");
        }

        static int Riga(int colonna)
        {
            int rigalibera = 5;
            while (forza4[rigalibera, colonna] != 0) 
            {
                rigalibera--;
                if (rigalibera < 0) return -1;
            }
            return rigalibera;
        }

        private void btnCrea_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                PictureBox pic = new PictureBox();
                this.Controls.Add(pic);
                pic.Top = 200;
                pic.Left = 10 + i * 20;
                pic.Height = 20;
                pic.Width = 20;
                if (i % 2 == 0)
                {
                    pic.BackColor = Color.Black;
                }
                else
                {
                    pic.BackColor = Color.White;
                }

            }
        }
    }
}
