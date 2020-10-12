namespace latenight
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
            this.Geslacht = new System.Windows.Forms.GroupBox();
            this.BtnVrouw = new System.Windows.Forms.RadioButton();
            this.BtnMan = new System.Windows.Forms.RadioButton();
            this.Levenstijl = new System.Windows.Forms.GroupBox();
            this.LsNietActief = new System.Windows.Forms.RadioButton();
            this.LsActief = new System.Windows.Forms.RadioButton();
            this.Leeftijd = new System.Windows.Forms.Label();
            this.LeeftijdBox = new System.Windows.Forms.TextBox();
            this.Bereken = new System.Windows.Forms.Button();
            this.Uitkomst = new System.Windows.Forms.Label();
            this.TbUitkomst = new System.Windows.Forms.NumericUpDown();
            this.Geslacht.SuspendLayout();
            this.Levenstijl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TbUitkomst)).BeginInit();
            this.SuspendLayout();
            // 
            // Geslacht
            // 
            this.Geslacht.Controls.Add(this.BtnVrouw);
            this.Geslacht.Controls.Add(this.BtnMan);
            this.Geslacht.Location = new System.Drawing.Point(109, 104);
            this.Geslacht.Name = "Geslacht";
            this.Geslacht.Size = new System.Drawing.Size(200, 100);
            this.Geslacht.TabIndex = 0;
            this.Geslacht.TabStop = false;
            this.Geslacht.Text = "geslacht";
            // 
            // BtnVrouw
            // 
            this.BtnVrouw.AutoSize = true;
            this.BtnVrouw.Location = new System.Drawing.Point(34, 55);
            this.BtnVrouw.Name = "BtnVrouw";
            this.BtnVrouw.Size = new System.Drawing.Size(54, 17);
            this.BtnVrouw.TabIndex = 1;
            this.BtnVrouw.TabStop = true;
            this.BtnVrouw.Text = "vrouw";
            this.BtnVrouw.UseVisualStyleBackColor = true;
            // 
            // BtnMan
            // 
            this.BtnMan.AutoSize = true;
            this.BtnMan.Location = new System.Drawing.Point(34, 32);
            this.BtnMan.Name = "BtnMan";
            this.BtnMan.Size = new System.Drawing.Size(45, 17);
            this.BtnMan.TabIndex = 0;
            this.BtnMan.TabStop = true;
            this.BtnMan.Text = "man";
            this.BtnMan.UseVisualStyleBackColor = true;
            this.BtnMan.CheckedChanged += new System.EventHandler(this.BtnMan_CheckedChanged);
            // 
            // Levenstijl
            // 
            this.Levenstijl.Controls.Add(this.LsNietActief);
            this.Levenstijl.Controls.Add(this.LsActief);
            this.Levenstijl.Location = new System.Drawing.Point(349, 104);
            this.Levenstijl.Name = "Levenstijl";
            this.Levenstijl.Size = new System.Drawing.Size(200, 100);
            this.Levenstijl.TabIndex = 1;
            this.Levenstijl.TabStop = false;
            this.Levenstijl.Text = "levenstijl";
            // 
            // LsNietActief
            // 
            this.LsNietActief.AutoSize = true;
            this.LsNietActief.Location = new System.Drawing.Point(6, 55);
            this.LsNietActief.Name = "LsNietActief";
            this.LsNietActief.Size = new System.Drawing.Size(71, 17);
            this.LsNietActief.TabIndex = 3;
            this.LsNietActief.TabStop = true;
            this.LsNietActief.Text = "niet actief";
            this.LsNietActief.UseVisualStyleBackColor = true;
            // 
            // LsActief
            // 
            this.LsActief.AutoSize = true;
            this.LsActief.Location = new System.Drawing.Point(6, 32);
            this.LsActief.Name = "LsActief";
            this.LsActief.Size = new System.Drawing.Size(97, 17);
            this.LsActief.TabIndex = 2;
            this.LsActief.TabStop = true;
            this.LsActief.Text = "actief (normaal)";
            this.LsActief.UseVisualStyleBackColor = true;
            // 
            // Leeftijd
            // 
            this.Leeftijd.AutoSize = true;
            this.Leeftijd.Location = new System.Drawing.Point(598, 104);
            this.Leeftijd.Name = "Leeftijd";
            this.Leeftijd.Size = new System.Drawing.Size(37, 13);
            this.Leeftijd.TabIndex = 2;
            this.Leeftijd.Text = "leeftijd";
            // 
            // LeeftijdBox
            // 
            this.LeeftijdBox.Location = new System.Drawing.Point(601, 146);
            this.LeeftijdBox.Name = "LeeftijdBox";
            this.LeeftijdBox.Size = new System.Drawing.Size(100, 20);
            this.LeeftijdBox.TabIndex = 3;
            // 
            // Bereken
            // 
            this.Bereken.Location = new System.Drawing.Point(349, 267);
            this.Bereken.Name = "Bereken";
            this.Bereken.Size = new System.Drawing.Size(153, 51);
            this.Bereken.TabIndex = 4;
            this.Bereken.Text = "bereken";
            this.Bereken.UseVisualStyleBackColor = true;
            this.Bereken.Click += new System.EventHandler(this.Bereken_Click);
            // 
            // Uitkomst
            // 
            this.Uitkomst.AutoSize = true;
            this.Uitkomst.Location = new System.Drawing.Point(598, 255);
            this.Uitkomst.Name = "Uitkomst";
            this.Uitkomst.Size = new System.Drawing.Size(46, 13);
            this.Uitkomst.TabIndex = 6;
            this.Uitkomst.Text = "uitkomst";
            // 
            // TbUitkomst
            // 
            this.TbUitkomst.Location = new System.Drawing.Point(601, 298);
            this.TbUitkomst.Name = "TbUitkomst";
            this.TbUitkomst.Size = new System.Drawing.Size(120, 20);
            this.TbUitkomst.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TbUitkomst);
            this.Controls.Add(this.Uitkomst);
            this.Controls.Add(this.Bereken);
            this.Controls.Add(this.LeeftijdBox);
            this.Controls.Add(this.Leeftijd);
            this.Controls.Add(this.Levenstijl);
            this.Controls.Add(this.Geslacht);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Geslacht.ResumeLayout(false);
            this.Geslacht.PerformLayout();
            this.Levenstijl.ResumeLayout(false);
            this.Levenstijl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TbUitkomst)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox Geslacht;
        private System.Windows.Forms.RadioButton BtnVrouw;
        private System.Windows.Forms.RadioButton BtnMan;
        private System.Windows.Forms.GroupBox Levenstijl;
        private System.Windows.Forms.RadioButton LsNietActief;
        private System.Windows.Forms.RadioButton LsActief;
        private System.Windows.Forms.Label Leeftijd;
        private System.Windows.Forms.TextBox LeeftijdBox;
        private System.Windows.Forms.Button Bereken;
        private System.Windows.Forms.Label Uitkomst;
        private System.Windows.Forms.NumericUpDown TbUitkomst;
    }
}

