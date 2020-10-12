namespace Pincode
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
            this.Gebruikersnaam = new System.Windows.Forms.Label();
            this.Wachtwoord = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.ToonPin = new System.Windows.Forms.Button();
            this.Waar = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Gebruikersnaam
            // 
            this.Gebruikersnaam.AutoSize = true;
            this.Gebruikersnaam.Location = new System.Drawing.Point(143, 129);
            this.Gebruikersnaam.Name = "Gebruikersnaam";
            this.Gebruikersnaam.Size = new System.Drawing.Size(113, 17);
            this.Gebruikersnaam.TabIndex = 1;
            this.Gebruikersnaam.Text = "Gebruikersnaam";
            this.Gebruikersnaam.Click += new System.EventHandler(this.label2_Click);
            // 
            // Wachtwoord
            // 
            this.Wachtwoord.AutoSize = true;
            this.Wachtwoord.Cursor = System.Windows.Forms.Cursors.Default;
            this.Wachtwoord.Location = new System.Drawing.Point(143, 193);
            this.Wachtwoord.Name = "Wachtwoord";
            this.Wachtwoord.Size = new System.Drawing.Size(86, 17);
            this.Wachtwoord.TabIndex = 2;
            this.Wachtwoord.Text = "Wachtwoord";
            this.Wachtwoord.Click += new System.EventHandler(this.label3_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(262, 126);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(262, 188);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 4;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // ToonPin
            // 
            this.ToonPin.Location = new System.Drawing.Point(529, 163);
            this.ToonPin.Name = "ToonPin";
            this.ToonPin.Size = new System.Drawing.Size(75, 23);
            this.ToonPin.TabIndex = 5;
            this.ToonPin.Text = "ToonPin";
            this.ToonPin.UseVisualStyleBackColor = true;
            this.ToonPin.Click += new System.EventHandler(this.ToonPin_Click);
            // 
            // Waar
            // 
            this.Waar.AutoSize = true;
            this.Waar.Location = new System.Drawing.Point(210, 270);
            this.Waar.Name = "Waar";
            this.Waar.Size = new System.Drawing.Size(42, 17);
            this.Waar.TabIndex = 6;
            this.Waar.Text = "Waar";
            this.Waar.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(210, 322);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Waar);
            this.Controls.Add(this.ToonPin);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Wachtwoord);
            this.Controls.Add(this.Gebruikersnaam);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Gebruikersnaam;
        private System.Windows.Forms.Label Wachtwoord;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button ToonPin;
        private System.Windows.Forms.Label Waar;
        private System.Windows.Forms.Label label2;
    }
}

