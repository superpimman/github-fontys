namespace pincode2
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
            this.Gebruikersnaam = new System.Windows.Forms.TextBox();
            this.Wachtwoord = new System.Windows.Forms.TextBox();
            this.Pin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Gebruikersnaam
            // 
            this.Gebruikersnaam.Location = new System.Drawing.Point(180, 125);
            this.Gebruikersnaam.Name = "Gebruikersnaam";
            this.Gebruikersnaam.Size = new System.Drawing.Size(100, 22);
            this.Gebruikersnaam.TabIndex = 0;
            // 
            // Wachtwoord
            // 
            this.Wachtwoord.Location = new System.Drawing.Point(180, 169);
            this.Wachtwoord.Name = "Wachtwoord";
            this.Wachtwoord.Size = new System.Drawing.Size(100, 22);
            this.Wachtwoord.TabIndex = 1;
            // 
            // Pin
            // 
            this.Pin.Location = new System.Drawing.Point(444, 125);
            this.Pin.Name = "Pin";
            this.Pin.Size = new System.Drawing.Size(143, 53);
            this.Pin.TabIndex = 2;
            this.Pin.Text = "krijg pincode";
            this.Pin.UseVisualStyleBackColor = true;
            this.Pin.Click += new System.EventHandler(this.Pin_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Pin);
            this.Controls.Add(this.Wachtwoord);
            this.Controls.Add(this.Gebruikersnaam);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Gebruikersnaam;
        private System.Windows.Forms.TextBox Wachtwoord;
        private System.Windows.Forms.Button Pin;
    }
}

