namespace Ampere_opdracht
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
            this.Stroom = new System.Windows.Forms.TextBox();
            this.Spanning = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Bereken = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Stroom
            // 
            this.Stroom.Location = new System.Drawing.Point(20, 34);
            this.Stroom.Name = "Stroom";
            this.Stroom.Size = new System.Drawing.Size(100, 23);
            this.Stroom.TabIndex = 0;
            this.Stroom.TextChanged += new System.EventHandler(this.Stroom_TextChanged);
            // 
            // Spanning
            // 
            this.Spanning.Location = new System.Drawing.Point(20, 102);
            this.Spanning.Name = "Spanning";
            this.Spanning.Size = new System.Drawing.Size(100, 23);
            this.Spanning.TabIndex = 0;
            this.Spanning.TextChanged += new System.EventHandler(this.Spanning_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Stroom);
            this.groupBox1.Controls.Add(this.Spanning);
            this.groupBox1.Location = new System.Drawing.Point(70, 88);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(257, 163);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "stroom A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "spanning V";
            // 
            // Bereken
            // 
            this.Bereken.Location = new System.Drawing.Point(368, 182);
            this.Bereken.Name = "Bereken";
            this.Bereken.Size = new System.Drawing.Size(75, 23);
            this.Bereken.TabIndex = 3;
            this.Bereken.Text = "Bereken";
            this.Bereken.UseVisualStyleBackColor = true;
            this.Bereken.Click += new System.EventHandler(this.Bereken_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Bereken);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Stroom;
        private System.Windows.Forms.TextBox Spanning;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Bereken;
    }
}

