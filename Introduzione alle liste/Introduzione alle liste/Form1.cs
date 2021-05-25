using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Introduzione_alle_liste
{
    public partial class Form1 : Form
    {
        //dichiarazione della lista
        List<int> listaInteri;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //istanziazione della lista 
            listaInteri = new List<int>();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int numero;
            bool isNumber = int.TryParse(txtNum.Text, out numero);
            if (isNumber == true) {
                AddToList(numero);
            }
            else
                MessageBox.Show("Il valore inserito nel textbox non è un numero valido");
            
        }

        private void txtNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r') {
                int numero;
                bool isNumber = int.TryParse(txtNum.Text, out numero);
                if (isNumber == true)
                {
                    AddToList(numero);
                }
                else
                    MessageBox.Show("Il valore inserito nel textbox non è un numero valido");
            }
        }

        private void AddToList(int num)
        {
            listaInteri.Add(num);
            txtNum.Text = "";
            lbNumeri.Text = listaInteri.Count.ToString();
            StampaLista();
            lstElementi.DataSource = null;
            lstElementi.DataSource = listaInteri;
        }

        private void RemoveFromList(int num)
        {
            listaInteri.Remove(num);
            txtElimina.Text = "";
            lbNumeri.Text = listaInteri.Count.ToString();
            StampaLista();
            lstElementi.DataSource = null;
            lstElementi.DataSource = listaInteri;
        }

        private void StampaLista()
        {
            string s = "";
            /*
            //scorro tutti gli elementi della lista con un ciclo for
            for (int i = 0; i < listaInteri.Count; i++)
            {
                s = s + listaInteri[i] + ", ";
            }
            lbElementi.Text = s;
            */

            s = "";
            //scorro tutti gli elementi della lista con un ciclo foreach
            foreach (int n in listaInteri)
            {
                s = s + n + ", ";
            }
            lbElementi.Text = s;

        }

        private void btnElimina_Click(object sender, EventArgs e)
        {
            int numero;
            bool isNumber = int.TryParse(txtElimina.Text, out numero);
            if (isNumber == true)
            {
                RemoveFromList(numero);
            }
            else
                MessageBox.Show("Il valore inserito nel textbox non è un numero valido");

        }

        private void txtElimina_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                int numero;
                bool isNumber = int.TryParse(txtElimina.Text, out numero);
                if (isNumber == true)
                {
                    RemoveFromList(numero);
                }
                else
                    MessageBox.Show("Il valore inserito nel textbox non è un numero valido");
            }
        }
    }
}
