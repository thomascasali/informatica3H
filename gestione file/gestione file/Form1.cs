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

namespace gestione_file
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCrea_Click(object sender, EventArgs e)
        {
            //creazione di un file di esempio con direttiva using
            string path = @"d:\filediesempio.txt";
            if (!File.Exists(path))
            {
                // Create a file to write to.
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine("Ciao");
                    sw.WriteLine("Thomas Casali");
                    sw.WriteLine("Benvenuto");
                }
            }

        }

        private void btnLeggi_Click(object sender, EventArgs e)
        {
            //lettura file di testo con direttiva using e controllo della fine del testo con NULL
            string path = @"d:\filediesempio.txt";
            using (StreamReader sr = File.OpenText(path))
            {
                string s;
                string testo = "";
                while ((s = sr.ReadLine()) != null)
                {
                    testo=testo+ " - " +s;
                }
                MessageBox.Show(testo);
            }
        }

        private void btnLeggiA_Click(object sender, EventArgs e)
        {
            string file = @"d:\A.txt";
            StreamReader sr = new StreamReader(file);
            string riga="";

            while (!sr.EndOfStream)
            {
                riga = sr.ReadLine();
                MessageBox.Show(riga);

            }
            sr.Close();
            lblContenuto.Text = riga;
        }

        private void btnSalva_Click(object sender, EventArgs e)
        {
            string file = @"d:\A.txt";
            StreamWriter sw = new StreamWriter(file,true);
            sw.WriteLine(txtTesto.Text);
            sw.Close();

        }

        private void btnLeggiFile_Click(object sender, EventArgs e)
        {
            StreamReader sr;
            string file = txtFile.Text;
            try
            {
                sr = new StreamReader(file);
                while (!sr.EndOfStream)
                {
                    lstTesto.Items.Add(sr.ReadLine());
                }
                sr.Close();
            }
            catch
            {
                MessageBox.Show("Il nome file inserito è inesistente");
            }

            
        }

        private void btnNascondi_Click(object sender, EventArgs e)
        {
            int[] vett = { 1,2,3,4,5,6,7};
            foreach (int num in vett)
            {
                lblContenuto.Text += ","+ num;
            }
            foreach( Control c in Controls)
            {
                c.Visible = false;
            }
        }
    }
}
