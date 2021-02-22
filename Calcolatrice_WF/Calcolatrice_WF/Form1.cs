using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calcolatrice_WF
{
    public partial class frmCalcolatrice : Form
    {
        bool calcola = false;
        public frmCalcolatrice()
        {
            InitializeComponent();
        }

        private void Aggiungi(string txt)
        {
            //se il display è vuoto non posso inserire un simbolo di operatore
            if (lblDisplay.Text == "0" && (txt == "*" || txt == "-" || txt == "+" || txt == "/")) return;
            //se nel display c'è lo 0 iniziale allora lo tolgo e aggiungo il numero
            if (lblDisplay.Text == "0") lblDisplay.Text = "";
            if (lblDisplay.Text.Length>0) 
                //controllo se l'ultimo carattere visualizzato nel display è un operatore
                if(lblDisplay.Text[lblDisplay.Text.Length-1] == '*'|| lblDisplay.Text[lblDisplay.Text.Length - 1] == '/' || lblDisplay.Text[lblDisplay.Text.Length-1] == '+' || lblDisplay.Text[lblDisplay.Text.Length - 1] == '-') {  
                    //se il testo passato è un operatore allora non lo devo aggiungere al display
                    if (txt=="*"|| txt == "-" || txt == "+" || txt == "/") return;
            }
            lblDisplay.Text = lblDisplay.Text + txt;
            if (txt == "*" || txt == "-" || txt == "+" || txt == "/") calcola = true;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            Aggiungi("7");
        }

        private void btnPiu_Click(object sender, EventArgs e)
        {
            Aggiungi("+");
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            Aggiungi("8");
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            Aggiungi("9");
        }

        private void btnDiviso_Click(object sender, EventArgs e)
        {
            Aggiungi("/");
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            Aggiungi("4");
        }

        private void btn_Click(object sender, EventArgs e)
        {
            Aggiungi("5");
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            Aggiungi("6");
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            Aggiungi("1");
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            Aggiungi("2");
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            Aggiungi("3");
        }

        private void btnMeno_Click(object sender, EventArgs e)
        {
            Aggiungi("-");
        }

        private void btnVirgola_Click(object sender, EventArgs e)
        {
            Aggiungi(",");
        }

        private void btnPulisci_Click(object sender, EventArgs e)
        {
            lblDisplay.Text = "0";
        }

        private void tnPer_Click(object sender, EventArgs e)
        {
            Aggiungi("*");
        }

        private void frmCalcolatrice_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("Sto caricando la calcolatrice");
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (calcola == true)
            {
                MessageBox.Show("possiamo fare il calcolo");
            }
            else
            {
                MessageBox.Show("Non possiamo ancora fare il calcolo");
            }
        }
    }
}
