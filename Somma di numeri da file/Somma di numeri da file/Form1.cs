using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Somma_di_numeri_da_file
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcola_Click(object sender, EventArgs e)
        {
            string file = txtFile.Text;
            try
            {
                string riga;
                int totale=0;
                StreamReader sr = new StreamReader(file);
                while (!sr.EndOfStream)
                {
                    riga = sr.ReadLine();
                    totale = totale + int.Parse(riga);
                }
                lblRisultato.Text = totale.ToString();
            }
            catch{
                MessageBox.Show("Errore");
            }

        }
    }
}
