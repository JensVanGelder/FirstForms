
namespace FormsExercise1
{
    partial class Exercise3
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Exercise3));
            this.lblPlus = new System.Windows.Forms.Label();
            this.lblMinus = new System.Windows.Forms.Label();
            this.lblDivide = new System.Windows.Forms.Label();
            this.lblMult = new System.Windows.Forms.Label();
            this.numPlus = new System.Windows.Forms.NumericUpDown();
            this.numMinus = new System.Windows.Forms.NumericUpDown();
            this.numMult = new System.Windows.Forms.NumericUpDown();
            this.numDivide = new System.Windows.Forms.NumericUpDown();
            this.btnAnswer = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblTimer = new System.Windows.Forms.Label();
            this.numMod = new System.Windows.Forms.NumericUpDown();
            this.lblMod = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numPlus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDivide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMod)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPlus
            // 
            this.lblPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlus.Location = new System.Drawing.Point(58, 85);
            this.lblPlus.Name = "lblPlus";
            this.lblPlus.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblPlus.Size = new System.Drawing.Size(100, 23);
            this.lblPlus.TabIndex = 0;
            this.lblPlus.Text = "?   +   ?   =";
            this.lblPlus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblPlus.Click += new System.EventHandler(this.lblPlus_Click);
            // 
            // lblMinus
            // 
            this.lblMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinus.Location = new System.Drawing.Point(58, 108);
            this.lblMinus.Name = "lblMinus";
            this.lblMinus.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblMinus.Size = new System.Drawing.Size(100, 32);
            this.lblMinus.TabIndex = 1;
            this.lblMinus.Text = "?   -   ?   =";
            this.lblMinus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDivide
            // 
            this.lblDivide.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDivide.Location = new System.Drawing.Point(58, 173);
            this.lblDivide.Name = "lblDivide";
            this.lblDivide.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblDivide.Size = new System.Drawing.Size(100, 27);
            this.lblDivide.TabIndex = 2;
            this.lblDivide.Text = "?   /   ?   =";
            this.lblDivide.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblMult
            // 
            this.lblMult.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMult.Location = new System.Drawing.Point(58, 140);
            this.lblMult.Name = "lblMult";
            this.lblMult.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblMult.Size = new System.Drawing.Size(100, 31);
            this.lblMult.TabIndex = 3;
            this.lblMult.Text = "?   *   ?   =";
            this.lblMult.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // numPlus
            // 
            this.numPlus.Location = new System.Drawing.Point(164, 85);
            this.numPlus.Name = "numPlus";
            this.numPlus.Size = new System.Drawing.Size(120, 20);
            this.numPlus.TabIndex = 4;
            // 
            // numMinus
            // 
            this.numMinus.Location = new System.Drawing.Point(164, 116);
            this.numMinus.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numMinus.Name = "numMinus";
            this.numMinus.Size = new System.Drawing.Size(120, 20);
            this.numMinus.TabIndex = 5;
            // 
            // numMult
            // 
            this.numMult.Location = new System.Drawing.Point(164, 147);
            this.numMult.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numMult.Name = "numMult";
            this.numMult.Size = new System.Drawing.Size(120, 20);
            this.numMult.TabIndex = 6;
            // 
            // numDivide
            // 
            this.numDivide.Location = new System.Drawing.Point(164, 178);
            this.numDivide.Name = "numDivide";
            this.numDivide.Size = new System.Drawing.Size(120, 20);
            this.numDivide.TabIndex = 7;
            // 
            // btnAnswer
            // 
            this.btnAnswer.Enabled = false;
            this.btnAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnswer.Location = new System.Drawing.Point(164, 250);
            this.btnAnswer.Name = "btnAnswer";
            this.btnAnswer.Size = new System.Drawing.Size(120, 32);
            this.btnAnswer.TabIndex = 8;
            this.btnAnswer.Text = "Enter Answers";
            this.btnAnswer.UseVisualStyleBackColor = true;
            this.btnAnswer.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(164, 32);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(120, 32);
            this.btnStart.TabIndex = 9;
            this.btnStart.Text = "Start Quiz!";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblTimer
            // 
            this.lblTimer.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblTimer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.lblTimer.Location = new System.Drawing.Point(304, 85);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(239, 144);
            this.lblTimer.TabIndex = 10;
            this.lblTimer.Text = "00:00";
            this.lblTimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numMod
            // 
            this.numMod.Location = new System.Drawing.Point(164, 209);
            this.numMod.Name = "numMod";
            this.numMod.Size = new System.Drawing.Size(120, 20);
            this.numMod.TabIndex = 12;
            // 
            // lblMod
            // 
            this.lblMod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMod.Location = new System.Drawing.Point(58, 204);
            this.lblMod.Name = "lblMod";
            this.lblMod.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblMod.Size = new System.Drawing.Size(100, 27);
            this.lblMod.TabIndex = 11;
            this.lblMod.Text = "?   %   ?   =";
            this.lblMod.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Exercise3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(606, 317);
            this.Controls.Add(this.numMod);
            this.Controls.Add(this.lblMod);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnAnswer);
            this.Controls.Add(this.numDivide);
            this.Controls.Add(this.numMult);
            this.Controls.Add(this.numMinus);
            this.Controls.Add(this.numPlus);
            this.Controls.Add(this.lblMult);
            this.Controls.Add(this.lblDivide);
            this.Controls.Add(this.lblMinus);
            this.Controls.Add(this.lblPlus);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Exercise3";
            this.Text = "Exercise 3: Math Quiz";
            ((System.ComponentModel.ISupportInitialize)(this.numPlus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDivide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMod)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblPlus;
        private System.Windows.Forms.Label lblMinus;
        private System.Windows.Forms.Label lblDivide;
        private System.Windows.Forms.Label lblMult;
        private System.Windows.Forms.NumericUpDown numPlus;
        private System.Windows.Forms.NumericUpDown numMinus;
        private System.Windows.Forms.NumericUpDown numMult;
        private System.Windows.Forms.NumericUpDown numDivide;
        private System.Windows.Forms.Button btnAnswer;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.NumericUpDown numMod;
        private System.Windows.Forms.Label lblMod;
    }
}