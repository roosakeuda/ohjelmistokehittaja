namespace Hotellihallintajärjestelmä
{
    partial class VaraustenHallinta
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
            this.VarauksetDG = new System.Windows.Forms.DataGridView();
            this.VarausNroTB = new System.Windows.Forms.TextBox();
            this.AsiakasNroCB = new System.Windows.Forms.ComboBox();
            this.HuoneTyyppiCB = new System.Windows.Forms.ComboBox();
            this.HuoneNroCB = new System.Windows.Forms.ComboBox();
            this.SisäänDTP = new System.Windows.Forms.DateTimePicker();
            this.UlosDTP = new System.Windows.Forms.DateTimePicker();
            this.LisaaBT = new System.Windows.Forms.Button();
            this.MuokkaaBT = new System.Windows.Forms.Button();
            this.PoistaBT = new System.Windows.Forms.Button();
            this.TyhjennaBT = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VarauksetDG)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CadetBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1477, 100);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.CadetBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(555, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(457, 59);
            this.label1.TabIndex = 0;
            this.label1.Text = "Varausten hallinta";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // VarauksetDG
            // 
            this.VarauksetDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.VarauksetDG.Location = new System.Drawing.Point(583, 136);
            this.VarauksetDG.Name = "VarauksetDG";
            this.VarauksetDG.RowHeadersWidth = 62;
            this.VarauksetDG.RowTemplate.Height = 28;
            this.VarauksetDG.Size = new System.Drawing.Size(859, 483);
            this.VarauksetDG.TabIndex = 2;
            this.VarauksetDG.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.VarauksetDG_CellClick);
            // 
            // VarausNroTB
            // 
            this.VarausNroTB.BackColor = System.Drawing.Color.LightSalmon;
            this.VarausNroTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VarausNroTB.ForeColor = System.Drawing.Color.Sienna;
            this.VarausNroTB.Location = new System.Drawing.Point(282, 145);
            this.VarausNroTB.Name = "VarausNroTB";
            this.VarausNroTB.Size = new System.Drawing.Size(268, 39);
            this.VarausNroTB.TabIndex = 3;
            // 
            // AsiakasNroCB
            // 
            this.AsiakasNroCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AsiakasNroCB.FormattingEnabled = true;
            this.AsiakasNroCB.Location = new System.Drawing.Point(282, 201);
            this.AsiakasNroCB.Name = "AsiakasNroCB";
            this.AsiakasNroCB.Size = new System.Drawing.Size(268, 37);
            this.AsiakasNroCB.TabIndex = 4;
            this.AsiakasNroCB.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // HuoneTyyppiCB
            // 
            this.HuoneTyyppiCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HuoneTyyppiCB.FormattingEnabled = true;
            this.HuoneTyyppiCB.Items.AddRange(new object[] {
            "Yksilö",
            "Pari",
            "Perhe"});
            this.HuoneTyyppiCB.Location = new System.Drawing.Point(282, 254);
            this.HuoneTyyppiCB.Name = "HuoneTyyppiCB";
            this.HuoneTyyppiCB.Size = new System.Drawing.Size(268, 37);
            this.HuoneTyyppiCB.TabIndex = 5;
            this.HuoneTyyppiCB.SelectedIndexChanged += new System.EventHandler(this.HuoneTyyppiCB_SelectedIndexChanged);
            // 
            // HuoneNroCB
            // 
            this.HuoneNroCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HuoneNroCB.FormattingEnabled = true;
            this.HuoneNroCB.Location = new System.Drawing.Point(282, 307);
            this.HuoneNroCB.Name = "HuoneNroCB";
            this.HuoneNroCB.Size = new System.Drawing.Size(268, 37);
            this.HuoneNroCB.TabIndex = 6;
            // 
            // SisäänDTP
            // 
            this.SisäänDTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SisäänDTP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.SisäänDTP.Location = new System.Drawing.Point(282, 365);
            this.SisäänDTP.Name = "SisäänDTP";
            this.SisäänDTP.Size = new System.Drawing.Size(268, 35);
            this.SisäänDTP.TabIndex = 7;
            // 
            // UlosDTP
            // 
            this.UlosDTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UlosDTP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.UlosDTP.Location = new System.Drawing.Point(282, 419);
            this.UlosDTP.Name = "UlosDTP";
            this.UlosDTP.Size = new System.Drawing.Size(268, 35);
            this.UlosDTP.TabIndex = 8;
            // 
            // LisaaBT
            // 
            this.LisaaBT.BackColor = System.Drawing.Color.DarkRed;
            this.LisaaBT.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.LisaaBT.FlatAppearance.BorderSize = 0;
            this.LisaaBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LisaaBT.ForeColor = System.Drawing.Color.LightSalmon;
            this.LisaaBT.Location = new System.Drawing.Point(12, 506);
            this.LisaaBT.Name = "LisaaBT";
            this.LisaaBT.Size = new System.Drawing.Size(238, 34);
            this.LisaaBT.TabIndex = 10;
            this.LisaaBT.Text = "Lisää uusi varaus";
            this.LisaaBT.UseVisualStyleBackColor = false;
            this.LisaaBT.Click += new System.EventHandler(this.LisaaBT_Click);
            // 
            // MuokkaaBT
            // 
            this.MuokkaaBT.BackColor = System.Drawing.Color.DarkRed;
            this.MuokkaaBT.FlatAppearance.BorderSize = 0;
            this.MuokkaaBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MuokkaaBT.ForeColor = System.Drawing.Color.LightSalmon;
            this.MuokkaaBT.Location = new System.Drawing.Point(327, 509);
            this.MuokkaaBT.Name = "MuokkaaBT";
            this.MuokkaaBT.Size = new System.Drawing.Size(111, 32);
            this.MuokkaaBT.TabIndex = 13;
            this.MuokkaaBT.Text = "Muokkaa";
            this.MuokkaaBT.UseVisualStyleBackColor = false;
            this.MuokkaaBT.Click += new System.EventHandler(this.MuokkaaBT_Click);
            // 
            // PoistaBT
            // 
            this.PoistaBT.BackColor = System.Drawing.Color.DarkRed;
            this.PoistaBT.FlatAppearance.BorderSize = 0;
            this.PoistaBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PoistaBT.ForeColor = System.Drawing.Color.LightSalmon;
            this.PoistaBT.Location = new System.Drawing.Point(455, 508);
            this.PoistaBT.Name = "PoistaBT";
            this.PoistaBT.Size = new System.Drawing.Size(95, 33);
            this.PoistaBT.TabIndex = 14;
            this.PoistaBT.Text = "Poista";
            this.PoistaBT.UseVisualStyleBackColor = false;
            this.PoistaBT.Click += new System.EventHandler(this.PoistaBT_Click);
            // 
            // TyhjennaBT
            // 
            this.TyhjennaBT.BackColor = System.Drawing.Color.DarkRed;
            this.TyhjennaBT.FlatAppearance.BorderSize = 0;
            this.TyhjennaBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TyhjennaBT.ForeColor = System.Drawing.Color.LightSalmon;
            this.TyhjennaBT.Location = new System.Drawing.Point(327, 568);
            this.TyhjennaBT.Name = "TyhjennaBT";
            this.TyhjennaBT.Size = new System.Drawing.Size(223, 32);
            this.TyhjennaBT.TabIndex = 15;
            this.TyhjennaBT.Text = "Tyhjennä kentät";
            this.TyhjennaBT.UseVisualStyleBackColor = false;
            this.TyhjennaBT.Click += new System.EventHandler(this.TyhjennaBT_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.ForestGreen;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LightGreen;
            this.label2.Location = new System.Drawing.Point(79, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 32);
            this.label2.TabIndex = 16;
            this.label2.Text = "Varaus nro:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.ForestGreen;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.LightGreen;
            this.label3.Location = new System.Drawing.Point(68, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 32);
            this.label3.TabIndex = 17;
            this.label3.Text = "Asiakas nro:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.ForestGreen;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.LightGreen;
            this.label4.Location = new System.Drawing.Point(57, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(193, 32);
            this.label4.TabIndex = 18;
            this.label4.Text = "Huonetyyppi:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.ForestGreen;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.LightGreen;
            this.label5.Location = new System.Drawing.Point(52, 307);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(198, 32);
            this.label5.TabIndex = 19;
            this.label5.Text = "Huoneen nro:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.ForestGreen;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.LightGreen;
            this.label6.Location = new System.Drawing.Point(133, 367);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 32);
            this.label6.TabIndex = 20;
            this.label6.Text = "Sisään:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.ForestGreen;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.LightGreen;
            this.label7.Location = new System.Drawing.Point(166, 421);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 32);
            this.label7.TabIndex = 21;
            this.label7.Text = "Ulos:";
            // 
            // VaraustenHallinta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.ForestGreen;
            this.ClientSize = new System.Drawing.Size(1465, 633);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TyhjennaBT);
            this.Controls.Add(this.PoistaBT);
            this.Controls.Add(this.MuokkaaBT);
            this.Controls.Add(this.LisaaBT);
            this.Controls.Add(this.UlosDTP);
            this.Controls.Add(this.SisäänDTP);
            this.Controls.Add(this.HuoneNroCB);
            this.Controls.Add(this.HuoneTyyppiCB);
            this.Controls.Add(this.AsiakasNroCB);
            this.Controls.Add(this.VarausNroTB);
            this.Controls.Add(this.VarauksetDG);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1487, 689);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1487, 689);
            this.Name = "VaraustenHallinta";
            this.Text = "VaraustenHallinta";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.VaraustenHallinta_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VarauksetDG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView VarauksetDG;
        private System.Windows.Forms.TextBox VarausNroTB;
        private System.Windows.Forms.ComboBox AsiakasNroCB;
        private System.Windows.Forms.ComboBox HuoneTyyppiCB;
        private System.Windows.Forms.ComboBox HuoneNroCB;
        private System.Windows.Forms.DateTimePicker SisäänDTP;
        private System.Windows.Forms.DateTimePicker UlosDTP;
        private System.Windows.Forms.Button LisaaBT;
        private System.Windows.Forms.Button MuokkaaBT;
        private System.Windows.Forms.Button PoistaBT;
        private System.Windows.Forms.Button TyhjennaBT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}