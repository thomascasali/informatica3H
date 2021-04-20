using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoryWF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static int[,] memory = new int[5, 5];
        static int riga, colonna, c = 0;
        static int n = 0, m = 0;

        static PictureBox p1 = new PictureBox();
        static PictureBox p2 = new PictureBox();
        static bool trovata1 = false, trovata2 = false;

        private void Form1_Load(object sender, EventArgs e)
        {
            BackColor = Color.LightGray;
        }

        private void btnFacile_Click(object sender, EventArgs e)
        {
            panDifficoltà.Visible = false;
            RiempiMatriceF();
        }

        private void btnMedia_Click(object sender, EventArgs e)
        {
            panDifficoltà.Visible = false;
            RiempiMatriceM();
        }

        private void btnDifficile_Click(object sender, EventArgs e)
        {
            panDifficoltà.Visible = false;
            RiempiMatriceP();
        }

        private void RiempiMatriceF()
        {
            var rnd = new Random();
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    memory[i, j] = 0;
                }
            }
            int x = 1;
            for (int i = 0; i < 8; i++)
            {

                do
                {
                    riga = rnd.Next(4);
                    colonna = rnd.Next(4);

                } while (memory[riga, colonna] != 0);
                memory[riga, colonna] = x;
                do
                {
                    riga = rnd.Next(4);
                    colonna = rnd.Next(4);

                } while (memory[riga, colonna] != 0);
                memory[riga, colonna] = x;
                x++;
            }

            int altezza = 0, conta = 0; ;
            for (int i = 0; i < 4; i++)
            {
                if (conta != 0) altezza = altezza + 56;
                for (int j = 0; j < 4; j++)
                {
                    PictureBox pic = new PictureBox();
                    this.Controls.Add(pic);
                    pic.Top = altezza;
                    pic.Left = j * 56 + 150;
                    pic.Height = 56;
                    pic.Width = 56;
                    pic.Tag = i + "," + j;
                    pic.BackColor = Color.White;
                    pic.BorderStyle = BorderStyle.Fixed3D;
                    pic.Click += new EventHandler(Cliccato);
                    conta = conta + 1;
                }
            }
        }
        private void RiempiMatriceM()
        {
            var rnd = new Random();
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    memory[i, j] = 0;
                }
            }
            int x = 1;
            for (int i = 0; i < 10; i++)
            {

                do
                {
                    riga = rnd.Next(5);
                    colonna = rnd.Next(5);

                } while (memory[riga, colonna] != 0);
                memory[riga, colonna] = x;
                do
                {
                    riga = rnd.Next(5);
                    colonna = rnd.Next(5);

                } while (memory[riga, colonna] != 0);
                memory[riga, colonna] = x;
                x++;
            }

            int altezza = 0, conta = 0; ;
            for (int i = 0; i < 5; i++)
            {
                if (conta != 0) altezza = altezza + 56;
                for (int j = 0; j < 4; j++)
                {
                    conta = conta + 1;
                    PictureBox pic = new PictureBox();
                    this.Controls.Add(pic);
                    pic.Top = altezza;
                    pic.Left = j * 56 + 150;
                    pic.Height = 56;
                    pic.Width = 56;
                    pic.Tag = i + "," + j;
                    pic.BackColor = Color.White;
                    pic.BorderStyle = BorderStyle.Fixed3D;
                    pic.Click += new EventHandler(Cliccato);
                }
            }
        }
        private void RiempiMatriceP()
        {
            var rnd = new Random();
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    memory[i, j] = 0;
                }
            }
            int x = 1;
            for (int i = 0; i < 2; i++)
            {

                do
                {
                    riga = rnd.Next(2);
                    colonna = rnd.Next(2);

                } while (memory[riga, colonna] != 0);
                memory[riga, colonna] = x;
                do
                {
                    riga = rnd.Next(2);
                    colonna = rnd.Next(2);

                } while (memory[riga, colonna] != 0);
                memory[riga, colonna] = x;
                x++;
            }

            int altezza = 0, conta = 0; ;
            for (int i = 0; i < 2; i++)
            {
                if (conta != 0) altezza = altezza + 56;
                for (int j = 0; j < 2; j++)
                {
                    conta = conta + 1;
                    PictureBox pic = new PictureBox();
                    this.Controls.Add(pic);
                    pic.Top = altezza;
                    pic.Left = j * 56 + 150;
                    pic.Height = 56;
                    pic.Width = 56;
                    pic.Tag = i + "," + j;
                    pic.BackColor = Color.White;
                    pic.BorderStyle = BorderStyle.Fixed3D;
                    pic.Click += new EventHandler(Cliccato);
                }
            }
        }
        public void Cliccato(object sender, EventArgs e)
        {
            PictureBox p = (PictureBox)sender;
            string[] coord = p.Tag.ToString().Split(',');
            int righe = int.Parse(coord[0]);
            int colonne = int.Parse(coord[1]);

            if (c%2==0)
            {
                p1 = (PictureBox)sender;

                if (memory[righe, colonne] == 1)
                {
                    p1.BackColor = Color.Red;
                    p1.BorderStyle = BorderStyle.Fixed3D;
                    trovata1 = true;
                    n = 1;
                }
                if (memory[righe, colonne] == 2)
                {
                    p1.BackColor = Color.Orange;
                    p1.BorderStyle = BorderStyle.Fixed3D;
                    trovata1 = true;
                    n = 2;
                }
                if (memory[righe, colonne] == 3)
                {
                    p1.BackColor = Color.Blue;
                    p1.BorderStyle = BorderStyle.Fixed3D;
                    trovata1 = true;
                    n = 3;
                }
                if (memory[righe, colonne] == 4)
                {
                    p1.BackColor = Color.Green;
                    p1.BorderStyle = BorderStyle.Fixed3D;
                    trovata1 = true;
                    n = 4;
                }
                if (memory[righe, colonne] == 5)
                {
                    p1.BackColor = Color.Purple;
                    p1.BorderStyle = BorderStyle.Fixed3D;
                    trovata1 = true;
                    n = 5;
                }
                if (memory[righe, colonne] == 6)
                {
                    p1.BackColor = Color.Turquoise;
                    p1.BorderStyle = BorderStyle.Fixed3D;
                    trovata1 = true;
                    n = 6;
                }
                if (memory[righe, colonne] == 7)
                {
                    p1.BackColor = Color.Yellow;
                    p1.BorderStyle = BorderStyle.Fixed3D;
                    trovata1 = true;
                    n = 7;
                }
                if (memory[righe, colonne] == 8)
                {
                    p1.BackColor = Color.Fuchsia;
                    p1.BorderStyle = BorderStyle.Fixed3D;
                    trovata1 = true;
                    n = 8;
                }
                if (memory[righe, colonne] == 9)
                {
                    p1.BackColor = Color.Pink;
                    p1.BorderStyle = BorderStyle.Fixed3D;
                    trovata1 = true;
                    n = 9;
                }
                if (memory[righe, colonne] == 10)
                {
                    p1.BackColor = Color.Black;
                    p1.BorderStyle = BorderStyle.Fixed3D;
                    trovata1 = true;
                    n = 10;
                }
                c ++;
            }
            else
            {
                p2 = (PictureBox)sender;
                if (memory[righe, colonne] == 1)
                {
                    p2.BackColor = Color.Red;
                    p2.BorderStyle = BorderStyle.Fixed3D;
                    trovata2 = true;
                    m = 1;
                }
                if (memory[righe, colonne] == 2)
                {
                    p2.BackColor = Color.Orange;
                    p2.BorderStyle = BorderStyle.Fixed3D;
                    trovata2 = true;
                    m = 2;
                }
                if (memory[righe, colonne] == 3)
                {
                    p2.BackColor = Color.Blue;
                    p2.BorderStyle = BorderStyle.Fixed3D;
                    trovata2 = true;
                    m = 3;
                }
                if (memory[righe, colonne] == 4)
                {
                    p2.BackColor = Color.Green;
                    p2.BorderStyle = BorderStyle.Fixed3D;
                    trovata2 = true;
                    m = 4;
                }
                if (memory[righe, colonne] == 5)
                {
                    p2.BackColor = Color.Purple;
                    p2.BorderStyle = BorderStyle.Fixed3D;
                    trovata2 = true;
                    m = 5;
                }
                if (memory[righe, colonne] == 6)
                {
                    p2.BackColor = Color.Turquoise;
                    p2.BorderStyle = BorderStyle.Fixed3D;
                    trovata2 = true;
                    m = 6;
                }
                if (memory[righe, colonne] == 7)
                {
                    p2.BackColor = Color.Yellow;
                    p2.BorderStyle = BorderStyle.Fixed3D;
                    trovata2 = true;
                    m = 7;
                }
                if (memory[righe, colonne] == 8)
                {
                    p2.BackColor = Color.Fuchsia;
                    p2.BorderStyle = BorderStyle.Fixed3D;
                    trovata2 = true;
                    m = 8;
                }
                if (memory[righe, colonne] == 9)
                {
                    p2.BackColor = Color.Pink;
                    p2.BorderStyle = BorderStyle.Fixed3D;
                    trovata2 = true;
                    m = 9;
                }
                if (memory[righe, colonne] == 10)
                {
                    p2.BackColor = Color.Black;
                    p2.BorderStyle = BorderStyle.Fixed3D;
                    trovata2 = true;
                    m = 10;
                }
                c++;
            }

            if (trovata1==true && trovata2==true)
            {
                if (n != m)
                {
                    Pulisci(p1);
                    Pulisci(p2);
                }
            }
        }
            
        private void Pulisci(PictureBox p)
        {
            foreach ( Control c in Controls)
            {
                if (c.Tag==p.Tag)
                {
                    c.BackColor = Color.White;
                }
            }
        }
    }
}



