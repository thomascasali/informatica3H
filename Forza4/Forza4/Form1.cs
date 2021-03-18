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
        static int dimPicture;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //inizializzo matrice
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    forza4[i, j] = 0;
                }
            }
         
            //creo il campo di gioco
            int top;
            dimPicture = 90;
            for (int i = 0; i < 6; i++) {
                top = 0 + dimPicture * i;
                for (int j = 0; j < 7; j++)
                {
                    PictureBox pic = new PictureBox();
                    this.Controls.Add(pic);
                    pic.Top = top;
                    pic.Left = j* dimPicture;
                    pic.Height = dimPicture;
                    pic.Width = dimPicture;
                    pic.SizeMode = PictureBoxSizeMode.StretchImage;
                    pic.Tag = i + "," + j;
                    pic.Click += new EventHandler(Cliccato);
                    pic.Image = Properties.Resources.campo;
                }
            }

            //ridimensiona la form
            this.Height = dimPicture * 6+36;
            this.Width = dimPicture * 7+16;
        }

        public void Cliccato(object sender, EventArgs e)
        {
            turno++;
            PictureBox p = (PictureBox)sender;
            string[] coord = p.Tag.ToString().Split(',');
            
            //in base alle coordinate dalla picture cliccata risalgo a riga e colonna nella quale inserire il gettore
            int riga = Riga(int.Parse(coord[1]));
            int colonna = int.Parse(coord[1]);
            //valorizzo il contenuto della matrice perché utilizzo la matrice per la ricerca della vittoria
            forza4[riga, colonna] = (turno % 2) + 1;
            //mi costruisco il tag della picture da colorare
            string picDaColorare = riga.ToString() + "," + colonna.ToString();
            //chiamo il metodo che mi consente di colorare la picture corretta
            Colora(picDaColorare);

            switch (Vittoria()) 
            {
                case 0:
                    break;
                case 1:
                    MessageBox.Show("Vittoria GIOCATORE 2");
                    //eventualmente far ripartire il gioco...
                    break;
                case 2:
                    MessageBox.Show("Vittoria GIOCATORE 1");
                    //eventualmente far ripartire il gioco...
                    break;
            }
        }

        private void Colora(string picDaColorare)
        {
            //scorre tutti gli elementi della form
            foreach (Control c in Controls)
            {
                if (c.Tag != null)
                {
                    if (c.Tag.ToString() == picDaColorare)
                    {
                        //quando trova la picture corretta da colorare la colora in base al turno
                        PictureBox pic = (PictureBox)c;
                        //mi sono creato oggetto di tipo PictureBox per poterlo gestire come tale
                        if (turno % 2 == 0)
                        {
                            pic.Image = Properties.Resources.CampoGiallo;
                        }
                        else
                        {
                            pic.Image = Properties.Resources.CampoRosso;
                        }
                    }
                }
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

        static int Vittoria()
        {
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    //controllo se ci sono 4 gettoni dello stesso colore vicini nelle 4 situazioni
                    try
                    { 
                        if (forza4[i, j] != 0 && forza4[i, j] == forza4[i + 1, j] && forza4[i + 1, j] == forza4[i + 2, j] && forza4[i + 2, j] == forza4[i + 3, j]) return forza4[i, j];
                    }
                    catch {/*indice fuori dalla matrice per cui non fa niente*/}
                    try
                    {
                        if (forza4[i, j] != 0 && forza4[i, j] == forza4[i, j + 1] && forza4[i, j + 1] == forza4[i, j + 2] && forza4[i, j + 2] == forza4[i, j + 3]) return forza4[i, j];
                    }
                    catch {/*indice fuori dalla matrice per cui non fa niente*/}
                    try
                    {
                        if (forza4[i, j] != 0 && forza4[i, j] == forza4[i + 1, j + 1] && forza4[i + 1, j + 1] == forza4[i + 2, j + 2] && forza4[i + 2, j + 2] == forza4[i + 3, j + 3]) return forza4[i, j];
                    }
                    catch {/*indice fuori dalla matrice per cui non fa niente*/}
                    try
                    {
                        if (forza4[i, j] != 0 && forza4[i, j] == forza4[i + 1, j - 1] && forza4[i + 1, j - 1] == forza4[i + 2, j - 2] && forza4[i + 2, j - 2] == forza4[i + 3, j - 3]) return forza4[i, j];
                    }
                    catch {/*indice fuori dalla matrice per cui non fa niente*/}
                }
            }
            return 0;
        }
    }
}
