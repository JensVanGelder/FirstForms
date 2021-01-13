using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsExercise1
{
    public partial class Exercise1 : Form
    {
        public Exercise1()
        {
            InitializeComponent();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            lblCorrectZin.Text = $"Hello {txtName.Text}, your favourite colour is {txtColour.Text}, your favourite movie is {txtMovie.Text} and you are {numAge.Value} year(s) old.";
            lblRommelZin.Text = $"Hello {txtColour.Text}, your favourite colour is {txtName.Text}, your favourite movie is {numAge.Value} and you are {txtMovie.Text} year(s) old.";
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            if (ActivateButton())
            {
                btnPrint.Enabled = true;
            }
        }

        private void txtMovie_TextChanged(object sender, EventArgs e)
        {
            if (ActivateButton())
            {
                btnPrint.Enabled = true;
            }
        }

        private void txtColour_TextChanged(object sender, EventArgs e)
        {
            if (ActivateButton())
            {
                btnPrint.Enabled = true;
            }
        }

        private void numAge_ValueChanged(object sender, EventArgs e)
        {
            if (ActivateButton())
            {
                btnPrint.Enabled = true;
            }
        }

        public bool ActivateButton()
        {
            if (txtName.Text.Length > 0 && txtMovie.Text.Length > 0 && txtColour.Text.Length > 0 && numAge.Value != 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
