namespace Hotellihallintajärjestelmä
{
    partial class HuoneidenHallinta
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.enimiTB = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.LisaaBT = new System.Windows.Forms.Button();
            this.MuokkaaBT = new System.Windows.Forms.Button();
            this.PoistaBT = new System.Windows.Forms.Button();
            this.TyhjennaBT = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CadetBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1248, 96);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.CadetBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(404, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(457, 59);
            this.label1.TabIndex = 0;
            this.label1.Text = "Varausten hallinta";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(557, 152);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(681, 352);
            this.dataGridView1.TabIndex = 3;
            // 
            // enimiTB
            // 
            this.enimiTB.BackColor = System.Drawing.Color.LightSalmon;
            this.enimiTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enimiTB.ForeColor = System.Drawing.Color.Sienna;
            this.enimiTB.Location = new System.Drawing.Point(251, 152);
            this.enimiTB.Name = "enimiTB";
            this.enimiTB.Size = new System.Drawing.Size(268, 39);
            this.enimiTB.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.LightSalmon;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Sienna;
            this.textBox1.Location = new System.Drawing.Point(251, 269);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(268, 39);
            this.textBox1.TabIndex = 5;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(251, 210);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(268, 37);
            this.comboBox1.TabIndex = 6;
            // 
            // LisaaBT
            // 
            this.LisaaBT.BackColor = System.Drawing.Color.DarkRed;
            this.LisaaBT.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.LisaaBT.FlatAppearance.BorderSize = 0;
            this.LisaaBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LisaaBT.ForeColor = System.Drawing.Color.LightSalmon;
            this.LisaaBT.Location = new System.Drawing.Point(12, 390);
            this.LisaaBT.Name = "LisaaBT";
            this.LisaaBT.Size = new System.Drawing.Size(238, 34);
            this.LisaaBT.TabIndex = 11;
            this.LisaaBT.Text = "Lisää uusi varaus";
            this.LisaaBT.UseVisualStyleBackColor = false;
            // 
            // MuokkaaBT
            // 
            this.MuokkaaBT.BackColor = System.Drawing.Color.DarkRed;
            this.MuokkaaBT.FlatAppearance.BorderSize = 0;
            this.MuokkaaBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MuokkaaBT.ForeColor = System.Drawing.Color.LightSalmon;
            this.MuokkaaBT.Location = new System.Drawing.Point(296, 392);
            this.MuokkaaBT.Name = "MuokkaaBT";
            this.MuokkaaBT.Size = new System.Drawing.Size(111, 32);
            this.MuokkaaBT.TabIndex = 14;
            this.MuokkaaBT.Text = "Muokkaa";
            this.MuokkaaBT.UseVisualStyleBackColor = false;
            // 
            // PoistaBT
            // 
            this.PoistaBT.BackColor = System.Drawing.Color.DarkRed;
            this.PoistaBT.FlatAppearance.BorderSize = 0;
            this.PoistaBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PoistaBT.ForeColor = System.Drawing.Color.LightSalmon;
            this.PoistaBT.Location = new System.Drawing.Point(424, 391);
            this.PoistaBT.Name = "PoistaBT";
            this.PoistaBT.Size = new System.Drawing.Size(95, 33);
            this.PoistaBT.TabIndex = 15;
            this.PoistaBT.Text = "Poista";
            this.PoistaBT.UseVisualStyleBackColor = false;
            // 
            // TyhjennaBT
            // 
            this.TyhjennaBT.BackColor = System.Drawing.Color.DarkRed;
            this.TyhjennaBT.FlatAppearance.BorderSize = 0;
            this.TyhjennaBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TyhjennaBT.ForeColor = System.Drawing.Color.LightSalmon;
            this.TyhjennaBT.Location = new System.Drawing.Point(296, 451);
            this.TyhjennaBT.Name = "TyhjennaBT";
            this.TyhjennaBT.Size = new System.Drawing.Size(223, 32);
            this.TyhjennaBT.TabIndex = 16;
            this.TyhjennaBT.Text = "Tyhjennä kentät";
            this.TyhjennaBT.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.ForestGreen;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LightGreen;
            this.label2.Location = new System.Drawing.Point(123, 333);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 32);
            this.label2.TabIndex = 17;
            this.label2.Text = "Vapaa:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.ForestGreen;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.LightGreen;
            this.label3.Location = new System.Drawing.Point(107, 272);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 32);
            this.label3.TabIndex = 18;
            this.label3.Text = "Puhelin:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.ForestGreen;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.LightGreen;
            this.label4.Location = new System.Drawing.Point(41, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(193, 32);
            this.label4.TabIndex = 19;
            this.label4.Text = "Huonetyyppi:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.ForestGreen;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.LightGreen;
            this.label5.Location = new System.Drawing.Point(36, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(198, 32);
            this.label5.TabIndex = 20;
            this.label5.Text = "Huoneen nro:";
            // 
            // HuoneidenHallinta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.ForestGreen;
            this.ClientSize = new System.Drawing.Size(1250, 531);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TyhjennaBT);
            this.Controls.Add(this.PoistaBT);
            this.Controls.Add(this.MuokkaaBT);
            this.Controls.Add(this.LisaaBT);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.enimiTB);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "HuoneidenHallinta";
            this.Text = "HuoneidenHallinta";
            this.Load += new System.EventHandler(this.HuoneidenHallinta_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox enimiTB;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button LisaaBT;
        private System.Windows.Forms.Button MuokkaaBT;
        private System.Windows.Forms.Button PoistaBT;
        private System.Windows.Forms.Button TyhjennaBT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}