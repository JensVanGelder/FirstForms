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
    public partial class Exercise2 : Form
    {
        public Exercise2()
        {
            InitializeComponent();
        }

        private void cboGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboGender.SelectedIndex == 0)
            {
                picGender.Image = Properties.Resources.Male;
                this.BackgroundImage = null;
                this.BackColor = Color.PowderBlue;
            }
            else if (cboGender.SelectedIndex == 1)
            {
                picGender.Image = Properties.Resources.Female;
                this.BackgroundImage = null;
                this.BackColor = Color.Pink;
            }
            else
            {
                picGender.Image = Properties.Resources.Other;
                this.BackColor = Color.Empty;
                this.BackgroundImage = Properties.Resources.rainbow_background_vector;
            }
            if (progbarComplete.Value < 66)
            {
                progbarComplete.Value = 66;
            }
            dateTimePicker1.Enabled = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void picGender_Click(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (progbarComplete.Value<33)
            {
                progbarComplete.Value = 33;
            }

            cboGender.Enabled = true;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (progbarComplete.Value < 100)
            {
                progbarComplete.Value = 100;
            }
        }

        private void progbarComplete_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            DateTime bDate = dateTimePicker1.Value;
            int age = now.Year - bDate.Year;
            if (now.Month < bDate.Month || (now.Month == bDate.Month && now.Day< bDate.Day))
            {
                age -= 1;
            }
            MessageBox.Show($"{age}","Your Age Is:");
        }

        private void Exercise2_Load(object sender, EventArgs e)
        {

        }
    }
}
