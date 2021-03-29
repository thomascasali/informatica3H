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

        private void Form1_Load(object sender, EventArgs e)
        {
            pic00.Image = Properties.Resources.gattino;
            pic00.SizeMode = PictureBoxSizeMode.StretchImage;
            pic01.Image = Properties.Resources.ben10;
            pic01.SizeMode = PictureBoxSizeMode.StretchImage;

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
        }
    }
}
