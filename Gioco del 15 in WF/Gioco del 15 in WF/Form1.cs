using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gioco_del_15_in_WF
{
    public partial class Form1 : Form
    {
        static int[,] gioco15 = new int[4, 4]; //definisco la matrice di gioco
        static Random rnd = new Random();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int x, y;
            for (int i = 1; i < 16; i++)
            {
                do
                {
                    x = rnd.Next(4); //estrae un numero casuale da 0 a 3 che rappresenta la riga estratta
                    y = rnd.Next(4); //estrae un numero casuale da 0 a 3 che rappresenta la colonna estratta
                } while (gioco15[x, y] != 0);
                gioco15[x, y] = i;
            }
            StampaCampo();
        }

        private void StampaCampo() {
            if (gioco15[0, 0] != 0) btn00.Text = gioco15[0, 0].ToString(); else btn00.Text = "";
            if (gioco15[0, 1] != 0) btn01.Text = gioco15[0, 1].ToString(); else btn01.Text = "";
            if (gioco15[0, 2] != 0) btn02.Text = gioco15[0, 2].ToString(); else btn02.Text = "";
            if (gioco15[0, 3] != 0) btn03.Text = gioco15[0, 3].ToString(); else btn03.Text = "";
            if (gioco15[1, 0] != 0) btn10.Text = gioco15[1, 0].ToString(); else btn10.Text = "";
            if (gioco15[1, 1] != 0) btn11.Text = gioco15[1, 1].ToString(); else btn11.Text = "";
            if (gioco15[1, 2] != 0) btn12.Text = gioco15[1, 2].ToString(); else btn12.Text = "";
            if (gioco15[1, 3] != 0) btn13.Text = gioco15[1, 3].ToString(); else btn13.Text = "";
            if (gioco15[2, 0] != 0) btn20.Text = gioco15[2, 0].ToString(); else btn20.Text = "";
            if (gioco15[2, 1] != 0) btn21.Text = gioco15[2, 1].ToString(); else btn21.Text = "";
            if (gioco15[2, 2] != 0) btn22.Text = gioco15[2, 2].ToString(); else btn22.Text = "";
            if (gioco15[2, 3] != 0) btn23.Text = gioco15[2, 3].ToString(); else btn23.Text = "";
            if (gioco15[3, 0] != 0) btn30.Text = gioco15[3, 0].ToString(); else btn30.Text = "";
            if (gioco15[3, 1] != 0) btn31.Text = gioco15[3, 1].ToString(); else btn31.Text = "";
            if (gioco15[3, 2] != 0) btn32.Text = gioco15[3, 2].ToString(); else btn32.Text = "";
            if (gioco15[3, 3] != 0) btn33.Text = gioco15[3, 3].ToString(); else btn33.Text = "";
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            //recupero la posizione della matrice cliccata dal nome del bottone
            int x = int.Parse(b.Name[3].ToString()); 
            int y= int.Parse(b.Name[4].ToString());
            //oppure si ottiene la stessa cosa utilizzando il codice ASCII del carattere
            x = b.Name[3] - 48;
            y = b.Name[4] - 48;
            //MessageBox.Show(gioco15[x, y].ToString());

            //adesso cerco lo 0 da scambiare nei dintorni della posizione x,y
            for (int i = x - 1; i < x + 2; i++) { 
                for (int j = y - 1; j < y + 2; j++)
                {
                    //controllo che gli indici i e j siano "buoni" per la matrice
                    if(i >= 0 && i <= 3 && j >= 0 && j <= 3)
                    {
                        //verifico se c'è lo 0 e sono nella stessa riga o nella stessa colonna
                        if (gioco15[i, j] == 0 && (i==x||j==y))
                        {
                            //ho trovato lo 0 e scambio i,j con x,y
                            gioco15[i, j] = gioco15[x, y];
                            gioco15[x, y] = 0;
                            break;
                        }
                    }
                }
            }
            //ristampo il campo
            StampaCampo();
        }

    }
}
