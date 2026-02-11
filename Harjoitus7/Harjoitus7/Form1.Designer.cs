namespace Harjoitus7
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
            this.OtsikkoLB = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.VastausLB = new System.Windows.Forms.Label();
            this.TB1 = new System.Windows.Forms.TextBox();
            this.TB2 = new System.Windows.Forms.TextBox();
            this.TB3 = new System.Windows.Forms.TextBox();
            this.TB4 = new System.Windows.Forms.TextBox();
            this.TB5 = new System.Windows.Forms.TextBox();
            this.TB6 = new System.Windows.Forms.TextBox();
            this.TB7 = new System.Windows.Forms.TextBox();
            this.TB8 = new System.Windows.Forms.TextBox();
            this.KilometritCB = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // OtsikkoLB
            // 
            this.OtsikkoLB.AutoSize = true;
            this.OtsikkoLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OtsikkoLB.Location = new System.Drawing.Point(319, 34);
            this.OtsikkoLB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.OtsikkoLB.Name = "OtsikkoLB";
            this.OtsikkoLB.Size = new System.Drawing.Size(331, 32);
            this.OtsikkoLB.TabIndex = 0;
            this.OtsikkoLB.Text = "Auton kustannuslaskuri";
            this.OtsikkoLB.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 134);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lainan lyhennys korkoineen:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 188);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Lisättävät nesteet yms:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 241);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Vakuutusmaksut:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 298);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Muut kulut:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 351);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "Polttonesteet:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(478, 134);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 25);
            this.label6.TabIndex = 6;
            this.label6.Text = "Pesut:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(478, 188);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 25);
            this.label7.TabIndex = 7;
            this.label7.Text = "Huollot: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(478, 241);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 25);
            this.label8.TabIndex = 8;
            this.label8.Text = "Renkaat:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(478, 298);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(160, 25);
            this.label9.TabIndex = 9;
            this.label9.Text = "Kilometrit / vuosi:";
            // 
            // VastausLB
            // 
            this.VastausLB.AutoSize = true;
            this.VastausLB.Location = new System.Drawing.Point(51, 433);
            this.VastausLB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.VastausLB.Name = "VastausLB";
            this.VastausLB.Size = new System.Drawing.Size(22, 25);
            this.VastausLB.TabIndex = 10;
            this.VastausLB.Text = "x";
            this.VastausLB.Visible = false;
            // 
            // TB1
            // 
            this.TB1.Location = new System.Drawing.Point(325, 131);
            this.TB1.Name = "TB1";
            this.TB1.Size = new System.Drawing.Size(100, 30);
            this.TB1.TabIndex = 11;
            // 
            // TB2
            // 
            this.TB2.Location = new System.Drawing.Point(325, 183);
            this.TB2.Name = "TB2";
            this.TB2.Size = new System.Drawing.Size(100, 30);
            this.TB2.TabIndex = 12;
            this.TB2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // TB3
            // 
            this.TB3.Location = new System.Drawing.Point(325, 236);
            this.TB3.Name = "TB3";
            this.TB3.Size = new System.Drawing.Size(100, 30);
            this.TB3.TabIndex = 13;
            // 
            // TB4
            // 
            this.TB4.Location = new System.Drawing.Point(325, 293);
            this.TB4.Name = "TB4";
            this.TB4.Size = new System.Drawing.Size(100, 30);
            this.TB4.TabIndex = 14;
            // 
            // TB5
            // 
            this.TB5.Location = new System.Drawing.Point(325, 346);
            this.TB5.Name = "TB5";
            this.TB5.Size = new System.Drawing.Size(100, 30);
            this.TB5.TabIndex = 15;
            // 
            // TB6
            // 
            this.TB6.Location = new System.Drawing.Point(758, 134);
            this.TB6.Name = "TB6";
            this.TB6.Size = new System.Drawing.Size(100, 30);
            this.TB6.TabIndex = 16;
            // 
            // TB7
            // 
            this.TB7.Location = new System.Drawing.Point(758, 191);
            this.TB7.Name = "TB7";
            this.TB7.Size = new System.Drawing.Size(100, 30);
            this.TB7.TabIndex = 17;
            // 
            // TB8
            // 
            this.TB8.Location = new System.Drawing.Point(758, 244);
            this.TB8.Name = "TB8";
            this.TB8.Size = new System.Drawing.Size(100, 30);
            this.TB8.TabIndex = 18;
            // 
            // KilometritCB
            // 
            this.KilometritCB.FormattingEnabled = true;
            this.KilometritCB.Items.AddRange(new object[] {
            "5000",
            "10000",
            "15000",
            "20000",
            "25000",
            "30000",
            "35000",
            "40000",
            "45000",
            "50000",
            "55000",
            "60000",
            "65000",
            "70000",
            "75000",
            "80000",
            "85000",
            "90000",
            "95000",
            "100000",
            "105000",
            "110000",
            "115000",
            "120000",
            "125000",
            "130000",
            "135000",
            "140000",
            "145000",
            "150000"});
            this.KilometritCB.Location = new System.Drawing.Point(758, 290);
            this.KilometritCB.Name = "KilometritCB";
            this.KilometritCB.Size = new System.Drawing.Size(121, 33);
            this.KilometritCB.TabIndex = 19;
            this.KilometritCB.SelectedIndexChanged += new System.EventHandler(this.KilometritCB_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 562);
            this.Controls.Add(this.KilometritCB);
            this.Controls.Add(this.TB8);
            this.Controls.Add(this.TB7);
            this.Controls.Add(this.TB6);
            this.Controls.Add(this.TB5);
            this.Controls.Add(this.TB4);
            this.Controls.Add(this.TB3);
            this.Controls.Add(this.TB2);
            this.Controls.Add(this.TB1);
            this.Controls.Add(this.VastausLB);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OtsikkoLB);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label OtsikkoLB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label VastausLB;
        private System.Windows.Forms.TextBox TB1;
        private System.Windows.Forms.TextBox TB2;
        private System.Windows.Forms.TextBox TB3;
        private System.Windows.Forms.TextBox TB4;
        private System.Windows.Forms.TextBox TB5;
        private System.Windows.Forms.TextBox TB6;
        private System.Windows.Forms.TextBox TB7;
        private System.Windows.Forms.TextBox TB8;
        private System.Windows.Forms.ComboBox KilometritCB;
    }
}

