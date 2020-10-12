namespace Calorieen_tracker
{
    partial class UserControl1
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Man = new System.Windows.Forms.RadioButton();
            this.Vrouw = new System.Windows.Forms.RadioButton();
            this.actief = new System.Windows.Forms.RadioButton();
            this.inactief = new System.Windows.Forms.RadioButton();
            this.leeftijd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Bereken = new System.Windows.Forms.Button();
            this.Antwoord = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Man
            // 
            this.Man.AutoSize = true;
            this.Man.Location = new System.Drawing.Point(131, 136);
            this.Man.Name = "Man";
            this.Man.Size = new System.Drawing.Size(56, 21);
            this.Man.TabIndex = 0;
            this.Man.TabStop = true;
            this.Man.Text = "man";
            this.Man.UseVisualStyleBackColor = true;
            this.Man.CheckedChanged += new System.EventHandler(this.Man_CheckedChanged);
            // 
            // Vrouw
            // 
            this.Vrouw.AutoSize = true;
            this.Vrouw.Location = new System.Drawing.Point(131, 223);
            this.Vrouw.Name = "Vrouw";
            this.Vrouw.Size = new System.Drawing.Size(66, 21);
            this.Vrouw.TabIndex = 1;
            this.Vrouw.TabStop = true;
            this.Vrouw.Text = "vrouw";
            this.Vrouw.UseVisualStyleBackColor = true;
            // 
            // actief
            // 
            this.actief.AutoSize = true;
            this.actief.Location = new System.Drawing.Point(351, 136);
            this.actief.Name = "actief";
            this.actief.Size = new System.Drawing.Size(63, 21);
            this.actief.TabIndex = 2;
            this.actief.TabStop = true;
            this.actief.Text = "actief";
            this.actief.UseVisualStyleBackColor = true;
            // 
            // inactief
            // 
            this.inactief.AutoSize = true;
            this.inactief.Location = new System.Drawing.Point(351, 223);
            this.inactief.Name = "inactief";
            this.inactief.Size = new System.Drawing.Size(74, 21);
            this.inactief.TabIndex = 3;
            this.inactief.TabStop = true;
            this.inactief.Text = "inactief";
            this.inactief.UseVisualStyleBackColor = true;
            // 
            // leeftijd
            // 
            this.leeftijd.Location = new System.Drawing.Point(536, 174);
            this.leeftijd.Name = "leeftijd";
            this.leeftijd.Size = new System.Drawing.Size(100, 22);
            this.leeftijd.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(533, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "leeftijd";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(348, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "levenstijl";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(128, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "geslacht";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Bereken
            // 
            this.Bereken.Location = new System.Drawing.Point(327, 309);
            this.Bereken.Name = "Bereken";
            this.Bereken.Size = new System.Drawing.Size(148, 82);
            this.Bereken.TabIndex = 8;
            this.Bereken.Text = "Bereken";
            this.Bereken.UseVisualStyleBackColor = true;
            this.Bereken.Click += new System.EventHandler(this.Bereken_Click);
            // 
            // Antwoord
            // 
            this.Antwoord.Location = new System.Drawing.Point(578, 339);
            this.Antwoord.Name = "Antwoord";
            this.Antwoord.Size = new System.Drawing.Size(100, 22);
            this.Antwoord.TabIndex = 9;
            this.Antwoord.TextChanged += new System.EventHandler(this.Antwoord_TextChanged);
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Antwoord);
            this.Controls.Add(this.Bereken);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.leeftijd);
            this.Controls.Add(this.inactief);
            this.Controls.Add(this.actief);
            this.Controls.Add(this.Vrouw);
            this.Controls.Add(this.Man);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(800, 450);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton Man;
        private System.Windows.Forms.RadioButton Vrouw;
        private System.Windows.Forms.RadioButton actief;
        private System.Windows.Forms.RadioButton inactief;
        private System.Windows.Forms.TextBox leeftijd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Bereken;
        private System.Windows.Forms.TextBox Antwoord;
    }
}
