namespace Extra_opgaven_herhalingsstructuren
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.invoer = new System.Windows.Forms.TextBox();
            this.Uitkomst = new System.Windows.Forms.TextBox();
            this.Bereken = new System.Windows.Forms.Button();
            this.Reset = new System.Windows.Forms.Button();
            this.Lijst = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // invoer
            // 
            this.invoer.Location = new System.Drawing.Point(151, 56);
            this.invoer.Name = "invoer";
            this.invoer.Size = new System.Drawing.Size(100, 23);
            this.invoer.TabIndex = 0;
            // 
            // Uitkomst
            // 
            this.Uitkomst.Location = new System.Drawing.Point(151, 304);
            this.Uitkomst.Name = "Uitkomst";
            this.Uitkomst.Size = new System.Drawing.Size(145, 23);
            this.Uitkomst.TabIndex = 1;
            // 
            // Bereken
            // 
            this.Bereken.Location = new System.Drawing.Point(396, 251);
            this.Bereken.Name = "Bereken";
            this.Bereken.Size = new System.Drawing.Size(75, 23);
            this.Bereken.TabIndex = 2;
            this.Bereken.Text = "bereken";
            this.Bereken.UseVisualStyleBackColor = true;
            this.Bereken.Click += new System.EventHandler(this.Bereken_Click);
            // 
            // Reset
            // 
            this.Reset.Location = new System.Drawing.Point(396, 330);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(75, 23);
            this.Reset.TabIndex = 3;
            this.Reset.Text = "reset";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // Lijst
            // 
            this.Lijst.FormattingEnabled = true;
            this.Lijst.ItemHeight = 15;
            this.Lijst.Location = new System.Drawing.Point(151, 101);
            this.Lijst.Name = "Lijst";
            this.Lijst.Size = new System.Drawing.Size(145, 184);
            this.Lijst.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(107, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "input";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 307);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "deelbaar door drie";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Lijst);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.Bereken);
            this.Controls.Add(this.Uitkomst);
            this.Controls.Add(this.invoer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox invoer;
        private System.Windows.Forms.TextBox Uitkomst;
        private System.Windows.Forms.Button Bereken;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.ListBox Lijst;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

