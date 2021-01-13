using System;
using System.Drawing;
using System.Windows.Forms;

namespace FormsExercise1
{
    public partial class Exercise3 : Form
    {
        private Random rng = new Random();
        private int plus1, plus2, plusAnswer, minus1, minus2, minusAnswer, mult1, mult2, multAnswer, div1, div2, mod1, mod2, modAnswer, divAnswer, time;

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (time > 10)
            {
                time = time - 1;
                lblTimer.ForeColor = Color.Empty;
                lblTimer.Font = new Font(lblTimer.Font.FontFamily, 36);
                lblTimer.Text = "00:" + time;
            }
            else if (time > 6)
            {
                time = time - 1;
                lblTimer.Text = "00:0" + time;
            }
            else if (time > 0)
            {
                time = time - 1;
                lblTimer.ForeColor = Color.Crimson;
                lblTimer.Font = new Font(lblTimer.Font.FontFamily, 48);
                lblTimer.Text = "00:0" + time + "!";
            }
            else
            {
                timer1.Stop();
                MessageBox.Show("You ran out of time!", "Time's Up!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnStart.Enabled = true;
                btnAnswer.Enabled = false;
            }
        }

        public Exercise3()
        {
            InitializeComponent();
        }

        private void lblPlus_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int userPlus = Convert.ToInt32(numPlus.Value);
            int userMinus = Convert.ToInt32(numMinus.Value);
            int userMult = Convert.ToInt32(numMult.Value);
            int userDivide = Convert.ToInt32(numDivide.Value);
            int userMod = Convert.ToInt32(numMod.Value);

            if (userPlus == plusAnswer && userMinus == minusAnswer && userMult == multAnswer && userDivide == divAnswer && modAnswer == userMod)
            {
                timer1.Stop();
                MessageBox.Show("Good job!", "Answers");
                btnStart.Enabled = true;
                btnAnswer.Enabled = false;
            }
            else
            {
                MessageBox.Show("Wrong!", "Answers",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            ChangeBackColourQuiz(userPlus, plusAnswer, numPlus);
            ChangeBackColourQuiz(userMinus, minusAnswer, numMinus);
            ChangeBackColourQuiz(userMult, multAnswer, numMult);
            ChangeBackColourQuiz(userDivide, divAnswer, numDivide);
            ChangeBackColourQuiz(userMod, modAnswer, numMod);
        }

        public void ChangeBackColourQuiz(int input, int answer, NumericUpDown math)
        {
            if (input == answer)
            {
                math.BackColor = Color.LightGreen;
            }
            else
            {
                math.BackColor = Color.LightSalmon;
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            ResetInputBoxes();

            GenerateQuizNumbers("+");
            GenerateQuizNumbers("-");
            GenerateQuizNumbers("*");
            GenerateQuizNumbers("/");
            GenerateQuizNumbers("%");

            btnStart.Enabled = false;
            btnAnswer.Enabled = true;

            time = 15;
            lblTimer.Text = "00:15";
            timer1.Start();
        }

        public void ResetInputBoxes()
        {
            numPlus.BackColor = Color.Empty;
            numPlus.Value = 0;
            numMinus.BackColor = Color.Empty;
            numMinus.Value = 0;
            numMult.BackColor = Color.Empty;
            numMult.Value = 0;
            numDivide.BackColor = Color.Empty;
            numDivide.Value = 0;
            numMod.BackColor = Color.Empty;
            numMod.Value = 0;
        }

        public void GenerateQuizNumbers(string calc)
        {
            switch (calc)
            {
                case "/":
                    div2 = rng.Next(1, 10);
                    div1 = div2 * rng.Next(1, 10);
                    divAnswer = div1 / div2;
                    lblDivide.Text = $"{div1}   /   {div2}   =";
                    break;

                case "+":
                    plus1 = rng.Next(1, 10);
                    plus2 = rng.Next(1, 10);
                    plusAnswer = plus1 + plus2;
                    lblPlus.Text = $"{plus1}   +   {plus2}   =";
                    break;

                case "-":
                    minus1 = rng.Next(1, 10);
                    minus2 = rng.Next(1, 10);
                    if (minus1 > minus2)
                    {
                        minusAnswer = minus1 - minus2;
                        lblMinus.Text = $"{minus1}   -   {minus2}   =";
                    }
                    else
                    {
                        minusAnswer = minus2 - minus1;
                        lblMinus.Text = $"{minus2}   -   {minus1}   =";
                    }
                    break;

                case "*":
                    mult1 = rng.Next(1, 10);
                    mult2 = rng.Next(1, 10);
                    multAnswer = mult1 * mult2;
                    lblMult.Text = $"{mult1}   *   {mult2}   =";
                    break;

                case "%":
                    mod1 = rng.Next(1, 10);
                    mod2 = rng.Next(1, 10);
                    if (mod1 > mod2)
                    {
                        modAnswer = mod1 % mod2;
                        lblMod.Text = $"{mod1}   %   {mod2}   =";
                    }
                    else
                    {
                        modAnswer = mod2 % mod1;
                        lblMod.Text = $"{mod2}   %   {mod1}   =";
                    }
                    break;
            }
        }
    }
}