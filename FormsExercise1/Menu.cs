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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Exercise1 ex1 = new Exercise1();
            ex1.Show();
        }

        private void btnExercise2_Click(object sender, EventArgs e)
        {
            Exercise2 ex2 = new Exercise2();
            ex2.Show();
        }

        private void btnExercise3_Click(object sender, EventArgs e)
        {
            Exercise3 ex3 = new Exercise3();
            ex3.Show();
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }
    }
}
