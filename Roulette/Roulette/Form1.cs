using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Roulette
{
    public partial class Form1 : Form
    {
        static Random rnd = new Random();
        static int numEstratto;
        static bool pari;
        static int[] nero = new int[] {2,4,6,8,10};
        static int[] rosso = new int[] {1,3,5,7,9};
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblScommessa.Text = "Pari";
            pari = true;
        }

        private void txtPuntata_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnPunta_Click(object sender, EventArgs e)
        {
            lblSoldiPuntati.Text = txtPuntata.Text;
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            /*
            int x, y;
            int r = 500;
            for (int q = 0;q< 360;q++) {
               // x = r * sin(alfa);
               // y = r * cos(alfa);
            }
            */
            //estrazione di un numero casuale da 0 a 36
            numEstratto = rnd.Next(37);
            lblNumEstratto.Text = numEstratto.ToString();
            if (numEstratto % 2 == 0)
            {
                lblPariDispari.Text = "PARI";
            }
            else {
                lblPariDispari.Text = "DISPARI";
            }
            if (ControllaVittoria()==true)
            {
                MessageBox.Show("Hai Vinto");
            }
        }

        static bool ControllaVittoria()
        {
            if (numEstratto % 2 == 0 && pari == true || numEstratto % 2 == 1 && pari == false)
            {
                return true;
            }
            return false;
        }

        private void btnNumero_Click(object sender, EventArgs e)
        {
            lblScommessa.Text = "hai scommesso sul numero " + txtNumero.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lblScommessa.Text = "hai scommesso sul numero 1";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            lblScommessa.Text = "hai scommesso sul Dispari";
            pari = false;
        }
    }
}
