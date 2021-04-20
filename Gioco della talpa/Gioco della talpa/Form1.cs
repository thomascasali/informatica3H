using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gioco_della_talpa
{
    public partial class frmTalpa : Form
    {
        Random rnd = new Random();
        int dimensione;

        public frmTalpa()
        {
            InitializeComponent();
        }

        private void CostruisciCampo(int dim)
        {
            dimensione = dim; //valorizzo la variabile globase della dimensione campo
            PulisciForm();
            //in dim c'è la dimensione del campo di gioco da costruire
            int dimensioneBuca = 100;
            int margineTop = 0;
            int margineLeft = 0;

            for(int i = 0; i < dim; i++)
            {
                //setta la posizione dall'alto delle picture
                margineTop = dimensioneBuca * i;
                for(int j=0; j < dim; j++)
                {
                    PictureBox p = new PictureBox();
                    p.Width = dimensioneBuca; //larghezza
                    p.Height = dimensioneBuca; //altezza
                    p.Top = margineTop; //posizionata in base al ciclo esterno
                    margineLeft = dimensioneBuca * j; //calcola posizione da sinistra
                    p.Left = margineLeft; //posizionata in base al ciclo interno
                    p.Tag = i + "," + j; //assegno la proprietà che mi servirà per identificare la picture nella form
                    p.Click += new EventHandler(Martellata); //aggiungo la gestione dell'evento click sulla picture che richiama il metodo Martellata
                    p.BackColor = Color.White;
                    p.SizeMode = PictureBoxSizeMode.StretchImage;
                    p.BorderStyle = BorderStyle.Fixed3D;
                    this.Controls.Add(p); //inserisce la picture nella form
                }
            }
            this.Width = (dimensioneBuca+8) * dim;
            this.Height = (dimensioneBuca+12) * dim + 100;
            lblPunti.Top = 350;//this.Bottom - 10;
            lblPunti.Left = 0;// this.Width / 2 - 50;
            lblPunti.Text = "0";
            lblPunti.Visible = true;
            tmrTalpa.Enabled = true;
        }

        private void PulisciForm()
        {
            foreach(Control c in Controls)
            {
                c.Visible = false;
            }
        }
        private void Martellata(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            if (pb.Image != null)
            {
                lblPunti.Text = (float.Parse(lblPunti.Text) + 1).ToString();
            }
            else
            {
                lblPunti.Text = (float.Parse(lblPunti.Text) - 0.5).ToString();
            }

        }
        private void btnFacile_Click(object sender, EventArgs e)
        {
            CostruisciCampo(2);
        }

        private void btnMedio_Click(object sender, EventArgs e)
        {
            CostruisciCampo(3);
        }

        private void btnDifficile_Click(object sender, EventArgs e)
        {
            CostruisciCampo(4);
        }

        private void tmrTalpa_Tick(object sender, EventArgs e)
        {
            //tolgo la talpa da tutte le buche
            foreach (Control c in Controls)
            {
                if (c.Tag != null) { 
                    PictureBox pb = (PictureBox)c;
                    pb.Image = null;
                }
            }
            int x = rnd.Next(dimensione);
            int y = rnd.Next(dimensione);
            foreach(Control c in Controls)
            {
                if(c.Tag!=null)
                {
                    if (c.Tag.ToString() == x + "," + y)
                    {
                        //faccio il cast delle controllo c per farlo diventare 
                        PictureBox pb = (PictureBox)c;
                        pb.Image = Properties.Resources.talpa;
                    }
                }

            }
        }
    }
}
