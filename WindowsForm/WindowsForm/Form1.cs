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
            Button b = new Button();
            b.Top = 50;
            b.Left = 100;
            b.Width = 100;
            b.Height = 100;
            b.BackColor = Color.Aqua;
            b.Text = "Nuovo!";
            this.Controls.Add(b);

            PictureBox p = new PictureBox();
            p.Top = 100;
            p.Left = 350;
            p.Width = 50;
            p.Height = 50;
            p.BackColor = Color.Yellow;
            this.Controls.Add(p);
            //p.Image=

            PictureBox p1 = new PictureBox();
            this.Controls.Add(p1);

            p1.Size = new Size(210, 110);
            this.Controls.Add(p1);
            p1.Top = 150;
            p1.Left = 300;
            Bitmap flag = new Bitmap(210, 110);
            Graphics flagGraphics = Graphics.FromImage(flag);
            flagGraphics.FillRectangle(Brushes.Green, 0, 0, 70, 110);
            flagGraphics.FillRectangle(Brushes.White, 70, 0, 70, 110);
            flagGraphics.FillRectangle(Brushes.Red, 140, 0, 70, 110);
            p1.Image = flag;
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
