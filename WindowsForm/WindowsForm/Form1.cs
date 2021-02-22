using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Messaggio()
        {
            MessageBox.Show("Ciao");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //MessageBox.Show(sender.ToString());
        }

        private void btnBottone_Click(object sender, EventArgs e)
        {
            MessageBox.Show(sender.ToString()+"\n"+e.GetType());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblDisplay.Text = "Hai cliccato";
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            //MessageBox.Show("Puntatore entrato!");
            lblDisplay.Text = "Puntatore entrato";
        }

        private void btnUno_Click(object sender, EventArgs e)
        {
            lblDisplay.Text = "1";
        }
    }
}
