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
        static int turno=0;
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

            int top;
            for (int i = 0; i < 6; i++) {
                top = 100 + 55 * i;
                for (int j = 0; j < 7; j++)
                {
                    PictureBox pic = new PictureBox();
                    this.Controls.Add(pic);
                    pic.Top = top;
                    pic.Left = 10+j*55;
                    pic.Height = 55;
                    pic.Width = 55;
                    pic.Tag = i + "," + j;
                    pic.Click += new EventHandler(Cliccato);
                    //pic.BorderStyle = BorderStyle.FixedSingle;
                    //if (i % 2 == 0) {
                    //    pic.BackColor = Color.Red;
                    //}
                    //else
                    //{
                    //    pic.BackColor = Color.Yellow;
                    //}
                    pic.Image = Properties.Resources.campo;

                }
            }


        }

        public void Cliccato(object sender, EventArgs e)
        {
            //MessageBox.Show("Ciao");
            PictureBox p = (PictureBox)sender;
            if (turno % 2 == 0)
            {
                p.Image = Properties.Resources.CampoGiallo;
            }
            else
            {
                p.Image = Properties.Resources.CampoRosso;
            }
            turno++;
            //MessageBox.Show(p.Tag.ToString());
            string[] coord = p.Tag.ToString().Split(',');
            MessageBox.Show("la colonna cliccata è " + coord[1]);
            MessageBox.Show("la prima riga libera dal basso è " + Riga(int.Parse(coord[1])));

            try
            {
                MessageBox.Show("valore della matrice in posizione 7,7 " + forza4[7,7]);
                int a = 1;
            }
            catch
            {
                MessageBox.Show("indice fuori dalla matrice");
            }
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
            //foreach(Control c in Controls)
            //{
            //    if(c.Tag != null) { 
            //        if (c.Tag.ToString() == "1,1") {
            //            MessageBox.Show("Bingo!");
            //        }
            //    }
            //}

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

        private void btnCerca_Click(object sender, EventArgs e)
        {
            foreach(Control c in Controls)
            {
                if (c.Tag != null)
                {
                    if (c.Tag.ToString() == "5,4")
                    {
                        MessageBox.Show("Bingo!!!!");
                        PictureBox p = (PictureBox)c;
                        p.SizeMode= PictureBoxSizeMode.StretchImage;
                        p.Image = Properties.Resources.Gettonerosso;
                    }
                }
            }
        }
    }
}
