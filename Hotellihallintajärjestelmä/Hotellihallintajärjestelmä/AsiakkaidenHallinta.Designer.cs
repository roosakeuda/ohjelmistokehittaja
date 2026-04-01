namespace Hotellihallintajärjestelmä
{
    partial class AsiakkaidenHallinta
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
            this.asiakkaatDG = new System.Windows.Forms.DataGridView();
            this.enimiTB = new System.Windows.Forms.TextBox();
            this.postinTB = new System.Windows.Forms.TextBox();
            this.ppaikkaTB = new System.Windows.Forms.TextBox();
            this.KtunnusTB = new System.Windows.Forms.TextBox();
            this.ssanaTB = new System.Windows.Forms.TextBox();
            this.OsoiteTB = new System.Windows.Forms.TextBox();
            this.snimiTB = new System.Windows.Forms.TextBox();
            this.LisaaBT = new System.Windows.Forms.Button();
            this.TyhjennaBT = new System.Windows.Forms.Button();
            this.PoistaBT = new System.Windows.Forms.Button();
            this.MuokkaaBT = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.asiakkaatDG)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CadetBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1594, 96);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.CadetBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(566, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(502, 59);
            this.label1.TabIndex = 0;
            this.label1.Text = "Asiakkaiden hallinta";
            // 
            // asiakkaatDG
            // 
            this.asiakkaatDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.asiakkaatDG.Location = new System.Drawing.Point(575, 145);
            this.asiakkaatDG.Name = "asiakkaatDG";
            this.asiakkaatDG.RowHeadersWidth = 62;
            this.asiakkaatDG.RowTemplate.Height = 28;
            this.asiakkaatDG.Size = new System.Drawing.Size(998, 493);
            this.asiakkaatDG.TabIndex = 1;
            this.asiakkaatDG.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.asiakkaatDG_CellClick);
            this.asiakkaatDG.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.asiakkaatDG_CellContentClick);
            // 
            // enimiTB
            // 
            this.enimiTB.BackColor = System.Drawing.Color.LightSalmon;
            this.enimiTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enimiTB.ForeColor = System.Drawing.Color.Sienna;
            this.enimiTB.Location = new System.Drawing.Point(285, 145);
            this.enimiTB.Name = "enimiTB";
            this.enimiTB.Size = new System.Drawing.Size(268, 39);
            this.enimiTB.TabIndex = 2;
            this.enimiTB.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // postinTB
            // 
            this.postinTB.BackColor = System.Drawing.Color.LightSalmon;
            this.postinTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.postinTB.ForeColor = System.Drawing.Color.Sienna;
            this.postinTB.Location = new System.Drawing.Point(285, 321);
            this.postinTB.Name = "postinTB";
            this.postinTB.Size = new System.Drawing.Size(268, 39);
            this.postinTB.TabIndex = 3;
            // 
            // ppaikkaTB
            // 
            this.ppaikkaTB.BackColor = System.Drawing.Color.LightSalmon;
            this.ppaikkaTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ppaikkaTB.ForeColor = System.Drawing.Color.Sienna;
            this.ppaikkaTB.Location = new System.Drawing.Point(285, 376);
            this.ppaikkaTB.Name = "ppaikkaTB";
            this.ppaikkaTB.Size = new System.Drawing.Size(268, 39);
            this.ppaikkaTB.TabIndex = 4;
            // 
            // KtunnusTB
            // 
            this.KtunnusTB.BackColor = System.Drawing.Color.LightSalmon;
            this.KtunnusTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KtunnusTB.ForeColor = System.Drawing.Color.Sienna;
            this.KtunnusTB.Location = new System.Drawing.Point(285, 432);
            this.KtunnusTB.Name = "KtunnusTB";
            this.KtunnusTB.Size = new System.Drawing.Size(268, 39);
            this.KtunnusTB.TabIndex = 5;
            // 
            // ssanaTB
            // 
            this.ssanaTB.BackColor = System.Drawing.Color.LightSalmon;
            this.ssanaTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ssanaTB.ForeColor = System.Drawing.Color.Sienna;
            this.ssanaTB.Location = new System.Drawing.Point(285, 488);
            this.ssanaTB.Name = "ssanaTB";
            this.ssanaTB.Size = new System.Drawing.Size(268, 39);
            this.ssanaTB.TabIndex = 6;
            // 
            // OsoiteTB
            // 
            this.OsoiteTB.BackColor = System.Drawing.Color.LightSalmon;
            this.OsoiteTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OsoiteTB.ForeColor = System.Drawing.Color.Sienna;
            this.OsoiteTB.Location = new System.Drawing.Point(285, 261);
            this.OsoiteTB.Name = "OsoiteTB";
            this.OsoiteTB.Size = new System.Drawing.Size(268, 39);
            this.OsoiteTB.TabIndex = 7;
            // 
            // snimiTB
            // 
            this.snimiTB.BackColor = System.Drawing.Color.LightSalmon;
            this.snimiTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.snimiTB.ForeColor = System.Drawing.Color.Sienna;
            this.snimiTB.Location = new System.Drawing.Point(285, 200);
            this.snimiTB.Name = "snimiTB";
            this.snimiTB.Size = new System.Drawing.Size(268, 39);
            this.snimiTB.TabIndex = 8;
            // 
            // LisaaBT
            // 
            this.LisaaBT.BackColor = System.Drawing.Color.DarkRed;
            this.LisaaBT.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.LisaaBT.FlatAppearance.BorderSize = 0;
            this.LisaaBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LisaaBT.ForeColor = System.Drawing.Color.LightSalmon;
            this.LisaaBT.Location = new System.Drawing.Point(12, 558);
            this.LisaaBT.Name = "LisaaBT";
            this.LisaaBT.Size = new System.Drawing.Size(238, 34);
            this.LisaaBT.TabIndex = 9;
            this.LisaaBT.Text = "Lisää uusi asiakas";
            this.LisaaBT.UseVisualStyleBackColor = false;
            this.LisaaBT.Click += new System.EventHandler(this.LisaaBT_Click);
            // 
            // TyhjennaBT
            // 
            this.TyhjennaBT.BackColor = System.Drawing.Color.DarkRed;
            this.TyhjennaBT.FlatAppearance.BorderSize = 0;
            this.TyhjennaBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TyhjennaBT.ForeColor = System.Drawing.Color.LightSalmon;
            this.TyhjennaBT.Location = new System.Drawing.Point(330, 606);
            this.TyhjennaBT.Name = "TyhjennaBT";
            this.TyhjennaBT.Size = new System.Drawing.Size(223, 32);
            this.TyhjennaBT.TabIndex = 10;
            this.TyhjennaBT.Text = "Tyhjennä kentät";
            this.TyhjennaBT.UseVisualStyleBackColor = false;
            this.TyhjennaBT.Click += new System.EventHandler(this.TyhjennaBT_Click);
            // 
            // PoistaBT
            // 
            this.PoistaBT.BackColor = System.Drawing.Color.DarkRed;
            this.PoistaBT.FlatAppearance.BorderSize = 0;
            this.PoistaBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PoistaBT.ForeColor = System.Drawing.Color.LightSalmon;
            this.PoistaBT.Location = new System.Drawing.Point(457, 558);
            this.PoistaBT.Name = "PoistaBT";
            this.PoistaBT.Size = new System.Drawing.Size(95, 33);
            this.PoistaBT.TabIndex = 11;
            this.PoistaBT.Text = "Poista";
            this.PoistaBT.UseVisualStyleBackColor = false;
            this.PoistaBT.Click += new System.EventHandler(this.PoistaBT_Click);
            // 
            // MuokkaaBT
            // 
            this.MuokkaaBT.BackColor = System.Drawing.Color.DarkRed;
            this.MuokkaaBT.FlatAppearance.BorderSize = 0;
            this.MuokkaaBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MuokkaaBT.ForeColor = System.Drawing.Color.LightSalmon;
            this.MuokkaaBT.Location = new System.Drawing.Point(330, 558);
            this.MuokkaaBT.Name = "MuokkaaBT";
            this.MuokkaaBT.Size = new System.Drawing.Size(111, 32);
            this.MuokkaaBT.TabIndex = 12;
            this.MuokkaaBT.Text = "Muokkaa";
            this.MuokkaaBT.UseVisualStyleBackColor = false;
            this.MuokkaaBT.Click += new System.EventHandler(this.MuokkaaBT_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.ForestGreen;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LightGreen;
            this.label2.Location = new System.Drawing.Point(124, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 32);
            this.label2.TabIndex = 13;
            this.label2.Text = "Etunimi:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.ForestGreen;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.LightGreen;
            this.label3.Location = new System.Drawing.Point(99, 491);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 32);
            this.label3.TabIndex = 14;
            this.label3.Text = "Salasana:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.ForestGreen;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.LightGreen;
            this.label4.Location = new System.Drawing.Point(23, 435);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(227, 32);
            this.label4.TabIndex = 15;
            this.label4.Text = "Käyttäjätunnus:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.ForestGreen;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.LightGreen;
            this.label5.Location = new System.Drawing.Point(3, 379);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(247, 32);
            this.label5.TabIndex = 16;
            this.label5.Text = "Postitoimipaikka:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.ForestGreen;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.LightGreen;
            this.label6.Location = new System.Drawing.Point(56, 324);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(194, 32);
            this.label6.TabIndex = 17;
            this.label6.Text = "Postinumero:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.ForestGreen;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.LightGreen;
            this.label7.Location = new System.Drawing.Point(85, 264);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(165, 32);
            this.label7.TabIndex = 18;
            this.label7.Text = "Lähiosoite:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.ForestGreen;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.LightGreen;
            this.label8.Location = new System.Drawing.Point(101, 203);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(149, 32);
            this.label8.TabIndex = 19;
            this.label8.Text = "Sukunimi:";
            // 
            // AsiakkaidenHallinta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.ForestGreen;
            this.ClientSize = new System.Drawing.Size(1588, 650);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MuokkaaBT);
            this.Controls.Add(this.PoistaBT);
            this.Controls.Add(this.TyhjennaBT);
            this.Controls.Add(this.LisaaBT);
            this.Controls.Add(this.snimiTB);
            this.Controls.Add(this.OsoiteTB);
            this.Controls.Add(this.ssanaTB);
            this.Controls.Add(this.KtunnusTB);
            this.Controls.Add(this.ppaikkaTB);
            this.Controls.Add(this.postinTB);
            this.Controls.Add(this.enimiTB);
            this.Controls.Add(this.asiakkaatDG);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1610, 706);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1610, 706);
            this.Name = "AsiakkaidenHallinta";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "AsiakkaidenHallinta";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AsiakkaidenHallinta_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.asiakkaatDG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView asiakkaatDG;
        private System.Windows.Forms.TextBox enimiTB;
        private System.Windows.Forms.TextBox postinTB;
        private System.Windows.Forms.TextBox ppaikkaTB;
        private System.Windows.Forms.TextBox KtunnusTB;
        private System.Windows.Forms.TextBox ssanaTB;
        private System.Windows.Forms.TextBox OsoiteTB;
        private System.Windows.Forms.TextBox snimiTB;
        private System.Windows.Forms.Button LisaaBT;
        private System.Windows.Forms.Button TyhjennaBT;
        private System.Windows.Forms.Button PoistaBT;
        private System.Windows.Forms.Button MuokkaaBT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}