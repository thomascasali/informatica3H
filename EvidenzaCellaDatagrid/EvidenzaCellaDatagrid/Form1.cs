using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EvidenzaCellaDatagrid
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dtgrid.Width = 300;
            dtgrid.Height = 300;
            dtgrid.RowCount = 10;
            dtgrid.ColumnCount = 10;
            dtgrid.ColumnHeadersVisible = false;
            dtgrid.RowHeadersVisible = false;
            foreach (DataGridViewColumn cs in dtgrid.Columns)
            {
                cs.Width = (dtgrid.Width-1) / 10;
            }
            foreach (DataGridViewRow cs in dtgrid.Rows)
            {
                cs.Height = (dtgrid.Height-1) / 10;
            }

        }

        private void dtgrid_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            dtgrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.Blue;
            try
            {
                dtgrid.Rows[e.RowIndex].Cells[e.ColumnIndex + 1].Style.BackColor = Color.Blue;
            }
            catch { }
        }

        private void dtgrid_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            dtgrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.White;
            try
            {
                dtgrid.Rows[e.RowIndex].Cells[e.ColumnIndex + 1].Style.BackColor = Color.White;
            }
            catch { }
        }
    }
}
