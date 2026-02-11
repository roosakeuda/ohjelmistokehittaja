namespace Harjoitus8
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
            this.MuutaBT = new System.Windows.Forms.Button();
            this.NumeroTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.VastausLB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // OtsikkoLB
            // 
            this.OtsikkoLB.AutoSize = true;
            this.OtsikkoLB.Font = new System.Drawing.Font("Matura MT Script Capitals", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OtsikkoLB.Location = new System.Drawing.Point(307, 9);
            this.OtsikkoLB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.OtsikkoLB.Name = "OtsikkoLB";
            this.OtsikkoLB.Size = new System.Drawing.Size(475, 64);
            this.OtsikkoLB.TabIndex = 0;
            this.OtsikkoLB.Text = "Roomalaiset numerot";
            this.OtsikkoLB.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.OtsikkoLB.Click += new System.EventHandler(this.label1_Click);
            // 
            // MuutaBT
            // 
            this.MuutaBT.Font = new System.Drawing.Font("Matura MT Script Capitals", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MuutaBT.Location = new System.Drawing.Point(855, 308);
            this.MuutaBT.Margin = new System.Windows.Forms.Padding(4);
            this.MuutaBT.Name = "MuutaBT";
            this.MuutaBT.Size = new System.Drawing.Size(142, 41);
            this.MuutaBT.TabIndex = 1;
            this.MuutaBT.Text = "Muuta";
            this.MuutaBT.UseVisualStyleBackColor = true;
            this.MuutaBT.Click += new System.EventHandler(this.MuutaBT_Click);
            // 
            // NumeroTB
            // 
            this.NumeroTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumeroTB.Location = new System.Drawing.Point(855, 164);
            this.NumeroTB.Margin = new System.Windows.Forms.Padding(4);
            this.NumeroTB.Name = "NumeroTB";
            this.NumeroTB.Size = new System.Drawing.Size(132, 35);
            this.NumeroTB.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Matura MT Script Capitals", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(42, 164);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(645, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "Anna numero välillä 0-3999 niin muutan sen roomalaiseksi:";
            // 
            // VastausLB
            // 
            this.VastausLB.AutoSize = true;
            this.VastausLB.Font = new System.Drawing.Font("Matura MT Script Capitals", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VastausLB.Location = new System.Drawing.Point(51, 301);
            this.VastausLB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.VastausLB.Name = "VastausLB";
            this.VastausLB.Size = new System.Drawing.Size(107, 48);
            this.VastausLB.TabIndex = 4;
            this.VastausLB.Text = "label3";
            this.VastausLB.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.ClientSize = new System.Drawing.Size(1067, 562);
            this.Controls.Add(this.VastausLB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NumeroTB);
            this.Controls.Add(this.MuutaBT);
            this.Controls.Add(this.OtsikkoLB);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label OtsikkoLB;
        private System.Windows.Forms.Button MuutaBT;
        private System.Windows.Forms.TextBox NumeroTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label VastausLB;
    }
}

