using clsShape;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shapes
{
    public partial class frmShape : Form
    {
        public frmShape()
        {
            InitializeComponent();
            groupBox4.Visible = false;
            groupBox3.Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void rdbRectangle_CheckedChanged(object sender, EventArgs e)
        {
            if(rdbRectangle.Checked)
            {
                groupBox4.Visible = true;
            }
            else
            {
                groupBox4.Visible = false;
            }
        }

        private void rdbSquare_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbSquare.Checked)
            {
                groupBox3.Visible = true;
            }
            else
            {
                groupBox3.Visible = false;
            }
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
           
            
        
            if(rdbRectangle.Checked)
            {
                clnRectangle rt = new clnRectangle(txtName.Text, int.Parse(txtSides.Text), double.Parse(txtLength.Text), double.Parse(txtWidth.Text));
                MessageBox.Show(rt.ToString());
            }
            else if(rdbSquare.Checked)
            {
                clnSquare sq = new clnSquare(txtName.Text, int.Parse(txtSides.Text), double.Parse(txtSquareSide.Text));
                MessageBox.Show(sq.ToString());
            }
        }
    }
}
