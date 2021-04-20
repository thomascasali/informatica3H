using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Memory
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static int tempo = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            pic00.Image = Properties.Resources.gattino;
            pic00.SizeMode = PictureBoxSizeMode.StretchImage;
            pic01.Image = Properties.Resources.ben10;
            pic01.SizeMode = PictureBoxSizeMode.StretchImage;
            pic03.Image = Properties.Resources.gattino;
            pic03.SizeMode = PictureBoxSizeMode.StretchImage;
            radioButton1.Checked = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            pic00.Visible = false;
        }

        private void pic01_Click(object sender, EventArgs e)
        {
            pic01.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pic00.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pan.Visible = false;
            if (radioButton1.Checked == true) MessageBox.Show("Hai scelto la modalità facile");
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnScambia_Click(object sender, EventArgs e)
        {
            int x = pic01.Left;
            int y = pic01.Top;
            pic01.Left = pic00.Left;
            pic01.Top = pic00.Top;
            pic00.Left = x;
            pic00.Top = y;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (Compare((Bitmap)pic00.Image, (Bitmap)pic03.Image)) MessageBox.Show("Sono uguali");
        }

        private bool Compare(Bitmap bmp1, Bitmap bmp2)
        {
            bool equals = true;
            bool flag = true;  //Inner loop isn't broken

            //Test to see if we have the same size of image
            if (bmp1.Size == bmp2.Size)
            {
                for (int x = 0; x < bmp1.Width; ++x)
                {
                    for (int y = 0; y < bmp1.Height; ++y)
                    {
                        if (bmp1.GetPixel(x, y) != bmp2.GetPixel(x, y))
                        {
                            equals = false;
                            flag = false;
                            break;
                        }
                    }
                    if (!flag)
                    {
                        break;
                    }
                }
            }
            else
            {
                equals = false;
            }
            return equals;
        }

        private void tmr_Tick(object sender, EventArgs e)
        {
            pic03.Visible = false;
        }

        private void pic03_Click(object sender, EventArgs e)
        {
            tmr.Enabled = true;
        }

        private void tmrTempo_Tick(object sender, EventArgs e)
        {
            tempo++;
            lblTempo.Text = tempo.ToString();
        }
    }
}
