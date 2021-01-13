
namespace FormsExercise1
{
    partial class Exercise2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Exercise2));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cboGender = new System.Windows.Forms.ComboBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblBirthday = new System.Windows.Forms.Label();
            this.progbarComplete = new System.Windows.Forms.ProgressBar();
            this.button1 = new System.Windows.Forms.Button();
            this.picGender = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picGender)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(103, 39);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(137, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // cboGender
            // 
            this.cboGender.Enabled = false;
            this.cboGender.FormattingEnabled = true;
            this.cboGender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "X"});
            this.cboGender.Location = new System.Drawing.Point(103, 65);
            this.cboGender.Name = "cboGender";
            this.cboGender.Size = new System.Drawing.Size(137, 21);
            this.cboGender.TabIndex = 1;
            this.cboGender.SelectedIndexChanged += new System.EventHandler(this.cboGender_SelectedIndexChanged);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(34, 40);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(61, 15);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Name   :";
            this.lblName.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.BackColor = System.Drawing.Color.Transparent;
            this.lblGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.Location = new System.Drawing.Point(34, 66);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(62, 15);
            this.lblGender.TabIndex = 3;
            this.lblGender.Text = "Gender :";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Location = new System.Drawing.Point(103, 92);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 4;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // lblBirthday
            // 
            this.lblBirthday.AutoSize = true;
            this.lblBirthday.BackColor = System.Drawing.Color.Transparent;
            this.lblBirthday.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBirthday.Location = new System.Drawing.Point(26, 93);
            this.lblBirthday.Name = "lblBirthday";
            this.lblBirthday.Size = new System.Drawing.Size(69, 15);
            this.lblBirthday.TabIndex = 5;
            this.lblBirthday.Text = "Birthdate:";
            // 
            // progbarComplete
            // 
            this.progbarComplete.Location = new System.Drawing.Point(37, 193);
            this.progbarComplete.Name = "progbarComplete";
            this.progbarComplete.Size = new System.Drawing.Size(266, 23);
            this.progbarComplete.TabIndex = 7;
            this.progbarComplete.Click += new System.EventHandler(this.progbarComplete_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(103, 129);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 37);
            this.button1.TabIndex = 8;
            this.button1.Text = "Show Age";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // picGender
            // 
            this.picGender.BackColor = System.Drawing.Color.Transparent;
            this.picGender.Image = global::FormsExercise1.Properties.Resources.Other;
            this.picGender.InitialImage = null;
            this.picGender.Location = new System.Drawing.Point(363, 24);
            this.picGender.Name = "picGender";
            this.picGender.Size = new System.Drawing.Size(128, 100);
            this.picGender.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picGender.TabIndex = 6;
            this.picGender.TabStop = false;
            this.picGender.Click += new System.EventHandler(this.picGender_Click);
            // 
            // Exercise2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(531, 243);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.progbarComplete);
            this.Controls.Add(this.picGender);
            this.Controls.Add(this.lblBirthday);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.cboGender);
            this.Controls.Add(this.textBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Exercise2";
            this.Text = "Exercise 2: Gender";
            this.Load += new System.EventHandler(this.Exercise2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picGender)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox cboGender;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblBirthday;
        private System.Windows.Forms.PictureBox picGender;
        private System.Windows.Forms.ProgressBar progbarComplete;
        private System.Windows.Forms.Button button1;
    }
}