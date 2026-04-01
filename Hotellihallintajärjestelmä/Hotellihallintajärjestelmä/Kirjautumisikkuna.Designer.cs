namespace Hotellihallintajärjestelmä
{
    partial class KirjautumisikkunaFM
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
            this.label1 = new System.Windows.Forms.Label();
            this.kirjauduGB = new System.Windows.Forms.GroupBox();
            this.KirjauduBT = new System.Windows.Forms.Button();
            this.SalasanaTB = new System.Windows.Forms.TextBox();
            this.kayttajaTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.kirjauduGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.CadetBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(16, 244);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(80, 15, 80, 15);
            this.label1.Size = new System.Drawing.Size(512, 85);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kirjaudu sisään";
            // 
            // kirjauduGB
            // 
            this.kirjauduGB.Controls.Add(this.label3);
            this.kirjauduGB.Controls.Add(this.label2);
            this.kirjauduGB.Controls.Add(this.kayttajaTB);
            this.kirjauduGB.Controls.Add(this.SalasanaTB);
            this.kirjauduGB.Controls.Add(this.KirjauduBT);
            this.kirjauduGB.Location = new System.Drawing.Point(12, 345);
            this.kirjauduGB.Name = "kirjauduGB";
            this.kirjauduGB.Size = new System.Drawing.Size(524, 255);
            this.kirjauduGB.TabIndex = 1;
            this.kirjauduGB.TabStop = false;
            // 
            // KirjauduBT
            // 
            this.KirjauduBT.BackColor = System.Drawing.Color.DarkRed;
            this.KirjauduBT.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.KirjauduBT.FlatAppearance.BorderSize = 0;
            this.KirjauduBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.KirjauduBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KirjauduBT.ForeColor = System.Drawing.Color.DarkSalmon;
            this.KirjauduBT.Location = new System.Drawing.Point(19, 177);
            this.KirjauduBT.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.KirjauduBT.Name = "KirjauduBT";
            this.KirjauduBT.Size = new System.Drawing.Size(447, 54);
            this.KirjauduBT.TabIndex = 0;
            this.KirjauduBT.Text = "Kirjaudu";
            this.KirjauduBT.UseVisualStyleBackColor = false;
            this.KirjauduBT.Click += new System.EventHandler(this.KirjauduBT_Click);
            // 
            // SalasanaTB
            // 
            this.SalasanaTB.BackColor = System.Drawing.Color.LightSalmon;
            this.SalasanaTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalasanaTB.ForeColor = System.Drawing.Color.Sienna;
            this.SalasanaTB.Location = new System.Drawing.Point(184, 113);
            this.SalasanaTB.Name = "SalasanaTB";
            this.SalasanaTB.Size = new System.Drawing.Size(282, 37);
            this.SalasanaTB.TabIndex = 1;
            this.SalasanaTB.Text = "ssana";
            // 
            // kayttajaTB
            // 
            this.kayttajaTB.BackColor = System.Drawing.Color.LightSalmon;
            this.kayttajaTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kayttajaTB.ForeColor = System.Drawing.Color.Sienna;
            this.kayttajaTB.Location = new System.Drawing.Point(184, 47);
            this.kayttajaTB.Name = "kayttajaTB";
            this.kayttajaTB.Size = new System.Drawing.Size(282, 37);
            this.kayttajaTB.TabIndex = 2;
            this.kayttajaTB.Text = "roosavaa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.label2.Location = new System.Drawing.Point(14, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Käyttäjä:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.label3.Location = new System.Drawing.Point(14, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "Salasana:";
            // 
            // KirjautumisikkunaFM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.ForestGreen;
            this.ClientSize = new System.Drawing.Size(548, 627);
            this.Controls.Add(this.kirjauduGB);
            this.Controls.Add(this.label1);
            this.Name = "KirjautumisikkunaFM";
            this.Text = "Kirjautumisikkuna";
            this.kirjauduGB.ResumeLayout(false);
            this.kirjauduGB.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox kirjauduGB;
        private System.Windows.Forms.TextBox kayttajaTB;
        private System.Windows.Forms.TextBox SalasanaTB;
        private System.Windows.Forms.Button KirjauduBT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}

