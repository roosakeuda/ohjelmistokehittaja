namespace harjoitus6
{
    partial class SalasananTarkastusFM
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
            this.SalasanaPL = new System.Windows.Forms.Panel();
            this.SalasanaOikeinPL = new System.Windows.Forms.Panel();
            this.KayttajaLB = new System.Windows.Forms.Label();
            this.SalasanaLB = new System.Windows.Forms.Label();
            this.KayttajaTB = new System.Windows.Forms.TextBox();
            this.SalasanaTB = new System.Windows.Forms.TextBox();
            this.TarkistaBT = new System.Windows.Forms.Button();
            this.VirheviestiLB = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SalasanaPL.SuspendLayout();
            this.SalasanaOikeinPL.SuspendLayout();
            this.SuspendLayout();
            // 
            // SalasanaPL
            // 
            this.SalasanaPL.BackColor = System.Drawing.Color.MidnightBlue;
            this.SalasanaPL.Controls.Add(this.VirheviestiLB);
            this.SalasanaPL.Controls.Add(this.TarkistaBT);
            this.SalasanaPL.Controls.Add(this.SalasanaTB);
            this.SalasanaPL.Controls.Add(this.KayttajaTB);
            this.SalasanaPL.Controls.Add(this.SalasanaLB);
            this.SalasanaPL.Controls.Add(this.KayttajaLB);
            this.SalasanaPL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SalasanaPL.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalasanaPL.ForeColor = System.Drawing.Color.Goldenrod;
            this.SalasanaPL.Location = new System.Drawing.Point(0, 0);
            this.SalasanaPL.Name = "SalasanaPL";
            this.SalasanaPL.Size = new System.Drawing.Size(800, 450);
            this.SalasanaPL.TabIndex = 0;
            // 
            // SalasanaOikeinPL
            // 
            this.SalasanaOikeinPL.BackColor = System.Drawing.Color.DarkRed;
            this.SalasanaOikeinPL.Controls.Add(this.label1);
            this.SalasanaOikeinPL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SalasanaOikeinPL.Font = new System.Drawing.Font("Segoe Script", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalasanaOikeinPL.ForeColor = System.Drawing.Color.Snow;
            this.SalasanaOikeinPL.Location = new System.Drawing.Point(0, 0);
            this.SalasanaOikeinPL.Name = "SalasanaOikeinPL";
            this.SalasanaOikeinPL.Size = new System.Drawing.Size(800, 450);
            this.SalasanaOikeinPL.TabIndex = 1;
            this.SalasanaOikeinPL.Visible = false;
            // 
            // KayttajaLB
            // 
            this.KayttajaLB.AutoSize = true;
            this.KayttajaLB.Location = new System.Drawing.Point(63, 13);
            this.KayttajaLB.Name = "KayttajaLB";
            this.KayttajaLB.Size = new System.Drawing.Size(275, 40);
            this.KayttajaLB.TabIndex = 0;
            this.KayttajaLB.Text = "Käyttäjätunnus: ";
            this.KayttajaLB.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // SalasanaLB
            // 
            this.SalasanaLB.AutoSize = true;
            this.SalasanaLB.Location = new System.Drawing.Point(152, 71);
            this.SalasanaLB.Name = "SalasanaLB";
            this.SalasanaLB.Size = new System.Drawing.Size(177, 40);
            this.SalasanaLB.TabIndex = 1;
            this.SalasanaLB.Text = "Salasana:";
            this.SalasanaLB.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // KayttajaTB
            // 
            this.KayttajaTB.Location = new System.Drawing.Point(370, 10);
            this.KayttajaTB.Name = "KayttajaTB";
            this.KayttajaTB.Size = new System.Drawing.Size(418, 48);
            this.KayttajaTB.TabIndex = 2;
            // 
            // SalasanaTB
            // 
            this.SalasanaTB.Location = new System.Drawing.Point(370, 71);
            this.SalasanaTB.Name = "SalasanaTB";
            this.SalasanaTB.Size = new System.Drawing.Size(418, 48);
            this.SalasanaTB.TabIndex = 3;
            // 
            // TarkistaBT
            // 
            this.TarkistaBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TarkistaBT.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TarkistaBT.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.TarkistaBT.Location = new System.Drawing.Point(574, 147);
            this.TarkistaBT.Name = "TarkistaBT";
            this.TarkistaBT.Size = new System.Drawing.Size(214, 43);
            this.TarkistaBT.TabIndex = 4;
            this.TarkistaBT.Text = "Tarkista";
            this.TarkistaBT.UseVisualStyleBackColor = true;
            this.TarkistaBT.Click += new System.EventHandler(this.TarkistaBT_Click);
            // 
            // VirheviestiLB
            // 
            this.VirheviestiLB.AutoSize = true;
            this.VirheviestiLB.Location = new System.Drawing.Point(63, 252);
            this.VirheviestiLB.Name = "VirheviestiLB";
            this.VirheviestiLB.Size = new System.Drawing.Size(35, 40);
            this.VirheviestiLB.TabIndex = 5;
            this.VirheviestiLB.Text = "x";
            this.VirheviestiLB.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(165, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(444, 60);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tervetuloa sivuilleni!";
            // 
            // SalasananTarkastusFM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SalasanaPL);
            this.Controls.Add(this.SalasanaOikeinPL);
            this.Name = "SalasananTarkastusFM";
            this.Text = "Salasanan tarkastus";
            this.SalasanaPL.ResumeLayout(false);
            this.SalasanaPL.PerformLayout();
            this.SalasanaOikeinPL.ResumeLayout(false);
            this.SalasanaOikeinPL.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel SalasanaPL;
        private System.Windows.Forms.Panel SalasanaOikeinPL;
        private System.Windows.Forms.Label SalasanaLB;
        private System.Windows.Forms.Label KayttajaLB;
        private System.Windows.Forms.Label VirheviestiLB;
        private System.Windows.Forms.Button TarkistaBT;
        private System.Windows.Forms.TextBox SalasanaTB;
        private System.Windows.Forms.TextBox KayttajaTB;
        private System.Windows.Forms.Label label1;
    }
}

