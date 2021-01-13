
namespace FormsExercise1
{
    partial class Exercise1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Exercise1));
            this.lblName = new System.Windows.Forms.Label();
            this.lblFilm = new System.Windows.Forms.Label();
            this.lblColor = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtMovie = new System.Windows.Forms.TextBox();
            this.numAge = new System.Windows.Forms.NumericUpDown();
            this.lblCorrectZin = new System.Windows.Forms.Label();
            this.lblRommelZin = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.txtColour = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numAge)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(293, 91);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(53, 16);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name:";
            // 
            // lblFilm
            // 
            this.lblFilm.AutoSize = true;
            this.lblFilm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilm.Location = new System.Drawing.Point(223, 117);
            this.lblFilm.Name = "lblFilm";
            this.lblFilm.Size = new System.Drawing.Size(123, 16);
            this.lblFilm.TabIndex = 1;
            this.lblFilm.Text = "Favourite Movie:";
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColor.Location = new System.Drawing.Point(220, 143);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(126, 16);
            this.lblColor.TabIndex = 2;
            this.lblColor.Text = "Favourite Colour:";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAge.Location = new System.Drawing.Point(306, 169);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(40, 16);
            this.lblAge.TabIndex = 3;
            this.lblAge.Text = "Age:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(352, 89);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(153, 20);
            this.txtName.TabIndex = 4;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // txtMovie
            // 
            this.txtMovie.Location = new System.Drawing.Point(352, 115);
            this.txtMovie.Name = "txtMovie";
            this.txtMovie.Size = new System.Drawing.Size(153, 20);
            this.txtMovie.TabIndex = 5;
            this.txtMovie.TextChanged += new System.EventHandler(this.txtMovie_TextChanged);
            // 
            // numAge
            // 
            this.numAge.Location = new System.Drawing.Point(352, 167);
            this.numAge.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.numAge.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numAge.Name = "numAge";
            this.numAge.Size = new System.Drawing.Size(153, 20);
            this.numAge.TabIndex = 7;
            this.numAge.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numAge.ValueChanged += new System.EventHandler(this.numAge_ValueChanged);
            // 
            // lblCorrectZin
            // 
            this.lblCorrectZin.AutoSize = true;
            this.lblCorrectZin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorrectZin.Location = new System.Drawing.Point(27, 273);
            this.lblCorrectZin.Name = "lblCorrectZin";
            this.lblCorrectZin.Size = new System.Drawing.Size(0, 16);
            this.lblCorrectZin.TabIndex = 8;
            // 
            // lblRommelZin
            // 
            this.lblRommelZin.AutoSize = true;
            this.lblRommelZin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRommelZin.Location = new System.Drawing.Point(27, 300);
            this.lblRommelZin.Name = "lblRommelZin";
            this.lblRommelZin.Size = new System.Drawing.Size(0, 16);
            this.lblRommelZin.TabIndex = 9;
            // 
            // btnPrint
            // 
            this.btnPrint.Enabled = false;
            this.btnPrint.Location = new System.Drawing.Point(553, 165);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 10;
            this.btnPrint.Text = "Enter Info";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // txtColour
            // 
            this.txtColour.Location = new System.Drawing.Point(352, 141);
            this.txtColour.Name = "txtColour";
            this.txtColour.Size = new System.Drawing.Size(153, 20);
            this.txtColour.TabIndex = 11;
            this.txtColour.TextChanged += new System.EventHandler(this.txtColour_TextChanged);
            // 
            // Exercise1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtColour);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.lblRommelZin);
            this.Controls.Add(this.lblCorrectZin);
            this.Controls.Add(this.numAge);
            this.Controls.Add(this.txtMovie);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.lblFilm);
            this.Controls.Add(this.lblName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Exercise1";
            this.Text = "Exercise 1: Favourite Movie / Colour";
            ((System.ComponentModel.ISupportInitialize)(this.numAge)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblFilm;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtMovie;
        private System.Windows.Forms.NumericUpDown numAge;
        private System.Windows.Forms.Label lblCorrectZin;
        private System.Windows.Forms.Label lblRommelZin;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.TextBox txtColour;
    }
}

