namespace worpengenerator
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
            this.worpennumericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.ogennumericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.AantalWorpen = new System.Windows.Forms.Label();
            this.AantalOgen = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.GooiDobbelsteen = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Aantal = new System.Windows.Forms.Label();
            this.Reset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.worpennumericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogennumericUpDown2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // worpennumericUpDown1
            // 
            this.worpennumericUpDown1.Location = new System.Drawing.Point(135, 64);
            this.worpennumericUpDown1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.worpennumericUpDown1.Name = "worpennumericUpDown1";
            this.worpennumericUpDown1.Size = new System.Drawing.Size(160, 22);
            this.worpennumericUpDown1.TabIndex = 0;
            this.worpennumericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // ogennumericUpDown2
            // 
            this.ogennumericUpDown2.Location = new System.Drawing.Point(135, 135);
            this.ogennumericUpDown2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ogennumericUpDown2.Name = "ogennumericUpDown2";
            this.ogennumericUpDown2.Size = new System.Drawing.Size(160, 22);
            this.ogennumericUpDown2.TabIndex = 1;
            this.ogennumericUpDown2.ValueChanged += new System.EventHandler(this.ogennumericUpDown2_ValueChanged);
            // 
            // AantalWorpen
            // 
            this.AantalWorpen.AutoSize = true;
            this.AantalWorpen.Location = new System.Drawing.Point(8, 66);
            this.AantalWorpen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AantalWorpen.Name = "AantalWorpen";
            this.AantalWorpen.Size = new System.Drawing.Size(98, 17);
            this.AantalWorpen.TabIndex = 2;
            this.AantalWorpen.Text = "AantalWorpen";
            // 
            // AantalOgen
            // 
            this.AantalOgen.AutoSize = true;
            this.AantalOgen.Location = new System.Drawing.Point(8, 138);
            this.AantalOgen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AantalOgen.Name = "AantalOgen";
            this.AantalOgen.Size = new System.Drawing.Size(83, 17);
            this.AantalOgen.TabIndex = 3;
            this.AantalOgen.Text = "AantalOgen";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ogennumericUpDown2);
            this.groupBox1.Controls.Add(this.AantalOgen);
            this.groupBox1.Controls.Add(this.worpennumericUpDown1);
            this.groupBox1.Controls.Add(this.AantalWorpen);
            this.groupBox1.Location = new System.Drawing.Point(51, 137);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(303, 187);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "instellingen";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listBox1);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(640, 203);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(348, 302);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "resultaat";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Items.AddRange(new object[] {
            "listbox1"});
            this.listBox1.Location = new System.Drawing.Point(12, 71);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(276, 228);
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Worpen:";
            // 
            // GooiDobbelsteen
            // 
            this.GooiDobbelsteen.Location = new System.Drawing.Point(113, 331);
            this.GooiDobbelsteen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GooiDobbelsteen.Name = "GooiDobbelsteen";
            this.GooiDobbelsteen.Size = new System.Drawing.Size(211, 28);
            this.GooiDobbelsteen.TabIndex = 7;
            this.GooiDobbelsteen.Text = "GooiDobbelsteen";
            this.GooiDobbelsteen.UseVisualStyleBackColor = true;
            this.GooiDobbelsteen.Click += new System.EventHandler(this.GooiDobbelsteen_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(648, 508);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "totaal aantal ogen";
            // 
            // Aantal
            // 
            this.Aantal.AutoSize = true;
            this.Aantal.Location = new System.Drawing.Point(881, 508);
            this.Aantal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Aantal.Name = "Aantal";
            this.Aantal.Size = new System.Drawing.Size(16, 17);
            this.Aantal.TabIndex = 9;
            this.Aantal.Text = "0";
            // 
            // Reset
            // 
            this.Reset.Location = new System.Drawing.Point(113, 393);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(211, 26);
            this.Reset.TabIndex = 10;
            this.Reset.Text = "Reset";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.Aantal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.GooiDobbelsteen);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.worpennumericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogennumericUpDown2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown worpennumericUpDown1;
        private System.Windows.Forms.NumericUpDown ogennumericUpDown2;
        private System.Windows.Forms.Label AantalWorpen;
        private System.Windows.Forms.Label AantalOgen;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button GooiDobbelsteen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Aantal;
        private System.Windows.Forms.Button Reset;
    }
}

