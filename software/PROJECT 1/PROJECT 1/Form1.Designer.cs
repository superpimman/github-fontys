namespace PROJECT_1
{
    partial class Form1
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
            this.BtnEuroToDollar1 = new System.Windows.Forms.Button();
            this.BtnEuroToDollar2 = new System.Windows.Forms.Button();
            this.TBEuro1 = new System.Windows.Forms.TextBox();
            this.TBDollar1 = new System.Windows.Forms.TextBox();
            this.NUMKoers = new System.Windows.Forms.NumericUpDown();
            this.TBEuroKoers = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.NUMKoers)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnEuroToDollar1
            // 
            this.BtnEuroToDollar1.Location = new System.Drawing.Point(284, 186);
            this.BtnEuroToDollar1.Name = "BtnEuroToDollar1";
            this.BtnEuroToDollar1.Size = new System.Drawing.Size(46, 25);
            this.BtnEuroToDollar1.TabIndex = 0;
            this.BtnEuroToDollar1.Text = ">";
            this.BtnEuroToDollar1.UseVisualStyleBackColor = true;
            this.BtnEuroToDollar1.Click += new System.EventHandler(this.BtnEuroToDollar1_Click);
            // 
            // BtnEuroToDollar2
            // 
            this.BtnEuroToDollar2.Location = new System.Drawing.Point(205, 186);
            this.BtnEuroToDollar2.Name = "BtnEuroToDollar2";
            this.BtnEuroToDollar2.Size = new System.Drawing.Size(45, 25);
            this.BtnEuroToDollar2.TabIndex = 1;
            this.BtnEuroToDollar2.Text = "<";
            this.BtnEuroToDollar2.UseVisualStyleBackColor = true;
            // 
            // TBEuro1
            // 
            this.TBEuro1.Location = new System.Drawing.Point(26, 189);
            this.TBEuro1.Name = "TBEuro1";
            this.TBEuro1.Size = new System.Drawing.Size(100, 20);
            this.TBEuro1.TabIndex = 2;
            this.TBEuro1.Text = "10";
            // 
            // TBDollar1
            // 
            this.TBDollar1.Location = new System.Drawing.Point(401, 189);
            this.TBDollar1.Name = "TBDollar1";
            this.TBDollar1.Size = new System.Drawing.Size(100, 20);
            this.TBDollar1.TabIndex = 3;
            // 
            // NUMKoers
            // 
            this.NUMKoers.DecimalPlaces = 2;
            this.NUMKoers.Location = new System.Drawing.Point(284, 309);
            this.NUMKoers.Name = "NUMKoers";
            this.NUMKoers.Size = new System.Drawing.Size(46, 20);
            this.NUMKoers.TabIndex = 4;
            this.NUMKoers.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // TBEuroKoers
            // 
            this.TBEuroKoers.Location = new System.Drawing.Point(178, 309);
            this.TBEuroKoers.Name = "TBEuroKoers";
            this.TBEuroKoers.Size = new System.Drawing.Size(100, 20);
            this.TBEuroKoers.TabIndex = 5;
            this.TBEuroKoers.Text = "Koers: 1 euro = $";
            this.TBEuroKoers.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TBEuroKoers);
            this.Controls.Add(this.NUMKoers);
            this.Controls.Add(this.TBDollar1);
            this.Controls.Add(this.TBEuro1);
            this.Controls.Add(this.BtnEuroToDollar2);
            this.Controls.Add(this.BtnEuroToDollar1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.NUMKoers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnEuroToDollar1;
        private System.Windows.Forms.Button BtnEuroToDollar2;
        private System.Windows.Forms.TextBox TBEuro1;
        private System.Windows.Forms.TextBox TBDollar1;
        private System.Windows.Forms.NumericUpDown NUMKoers;
        private System.Windows.Forms.TextBox TBEuroKoers;
    }
}

