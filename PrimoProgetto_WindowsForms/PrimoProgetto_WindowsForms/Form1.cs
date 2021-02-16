using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimoProgetto_WindowsForms
{
    public partial class PrimaForm : Form
    {
        int turno = 0;
        public PrimaForm()
        {
            InitializeComponent();
        }

        private void PrimaForm_Load(object sender, EventArgs e)
        {
            //MessageBox.Show(sender.ToString());
        }

        private void btnPrimoBottone_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(sender.ToString());
            btn00.Text = "";
            btn00.BackColor = Color.White;
            btn01.Text = "";
            btn01.BackColor = Color.White;
            btn02.Text = "";
            btn02.BackColor = Color.White;
            btn10.Text = "";
            btn10.BackColor = Color.White;
            btn11.Text = "";
            btn11.BackColor = Color.White;
            btn12.Text = "";
            btn12.BackColor = Color.White;
            btn20.Text = "";
            btn20.BackColor = Color.White;
            btn21.Text = "";
            btn21.BackColor = Color.White;
            btn22.Text = "";
            btn22.BackColor = Color.White;
        }

        private void btn00_Click(object sender, EventArgs e)
        {
            turno++;
            if (turno % 2 == 0) {
                btn00.Text = "X";
                btn00.BackColor = Color.Yellow;
            }
            else
            {
                btn00.Text = "O";
                btn00.BackColor = Color.Red;
            }
        }

        private void btn01_Click(object sender, EventArgs e)
        {
            turno++;
            if (turno % 2 == 0)
            {
                btn01.Text = "X";
                btn01.BackColor = Color.Yellow;
            }
            else
            {
                btn01.Text = "O";
                btn01.BackColor = Color.Red;
            }
        }

        private void btn02_Click(object sender, EventArgs e)
        {
            turno++;
            if (turno % 2 == 0)
            {
                btn02.Text = "X";
                btn02.BackColor = Color.Yellow;
            }
            else
            {
                btn02.Text = "O";
                btn02.BackColor = Color.Red;
            }
        }

        private void btn10_Click(object sender, EventArgs e)
        {
            turno++;
            if (turno % 2 == 0)
            {
                btn10.Text = "X";
                btn10.BackColor = Color.Yellow;
            }
            else
            {
                btn10.Text = "O";
                btn10.BackColor = Color.Red;
            }
        }

        private void btn11_Click(object sender, EventArgs e)
        {
            turno++;
            if (turno % 2 == 0)
            {
                btn11.Text = "X";
                btn11.BackColor = Color.Yellow;
            }
            else
            {
                btn11.Text = "O";
                btn11.BackColor = Color.Red;
            }
        }

        private void btn12_Click(object sender, EventArgs e)
        {
            turno++;
            if (turno % 2 == 0)
            {
                btn12.Text = "X";
                btn12.BackColor = Color.Yellow;
            }
            else
            {
                btn12.Text = "O";
                btn12.BackColor = Color.Red;
            }
        }

        private void btn20_Click(object sender, EventArgs e)
        {
            turno++;
            if (turno % 2 == 0)
            {
                btn20.Text = "X";
                btn20.BackColor = Color.Yellow;
            }
            else
            {
                btn20.Text = "O";
                btn20.BackColor = Color.Red;
            }
        }

        private void btn21_Click(object sender, EventArgs e)
        {
            turno++;
            if (turno % 2 == 0)
            {
                btn21.Text = "X";
                btn21.BackColor = Color.Yellow;
            }
            else
            {
                btn21.Text = "O";
                btn21.BackColor = Color.Red;
            }
        }

        private void btn22_Click(object sender, EventArgs e)
        {
            turno++;
            if (turno % 2 == 0)
            {
                btn22.Text = "X";
                btn22.BackColor = Color.Yellow;
            }
            else
            {
                btn22.Text = "O";
                btn22.BackColor = Color.Red;
            }
        }
    }
}
