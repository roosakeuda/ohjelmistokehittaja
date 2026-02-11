namespace Harjoitus12
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
            this.VastausGB = new System.Windows.Forms.GroupBox();
            this.näkymätönRB = new System.Windows.Forms.RadioButton();
            this.ARB = new System.Windows.Forms.RadioButton();
            this.BRB = new System.Windows.Forms.RadioButton();
            this.CRB = new System.Windows.Forms.RadioButton();
            this.DRB = new System.Windows.Forms.RadioButton();
            this.VastausLB = new System.Windows.Forms.Label();
            this.VastausGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // OtsikkoLB
            // 
            this.OtsikkoLB.AutoSize = true;
            this.OtsikkoLB.Location = new System.Drawing.Point(42, 37);
            this.OtsikkoLB.Name = "OtsikkoLB";
            this.OtsikkoLB.Size = new System.Drawing.Size(275, 20);
            this.OtsikkoLB.TabIndex = 0;
            this.OtsikkoLB.Text = "Vastaus ensimmäiseen kysymykseen:";
            this.OtsikkoLB.Click += new System.EventHandler(this.OtsikkoLB_Click);
            // 
            // VastausGB
            // 
            this.VastausGB.Controls.Add(this.DRB);
            this.VastausGB.Controls.Add(this.CRB);
            this.VastausGB.Controls.Add(this.BRB);
            this.VastausGB.Controls.Add(this.ARB);
            this.VastausGB.Controls.Add(this.näkymätönRB);
            this.VastausGB.Location = new System.Drawing.Point(348, 37);
            this.VastausGB.Name = "VastausGB";
            this.VastausGB.Size = new System.Drawing.Size(92, 190);
            this.VastausGB.TabIndex = 1;
            this.VastausGB.TabStop = false;
            this.VastausGB.Text = "Vastaus";
            // 
            // näkymätönRB
            // 
            this.näkymätönRB.AutoCheck = false;
            this.näkymätönRB.AutoSize = true;
            this.näkymätönRB.Location = new System.Drawing.Point(6, 25);
            this.näkymätönRB.Name = "näkymätönRB";
            this.näkymätönRB.Size = new System.Drawing.Size(38, 24);
            this.näkymätönRB.TabIndex = 0;
            this.näkymätönRB.TabStop = true;
            this.näkymätönRB.Text = " ";
            this.näkymätönRB.UseVisualStyleBackColor = true;
            this.näkymätönRB.Visible = false;
            // 
            // ARB
            // 
            this.ARB.AutoSize = true;
            this.ARB.Location = new System.Drawing.Point(6, 25);
            this.ARB.Name = "ARB";
            this.ARB.Size = new System.Drawing.Size(45, 24);
            this.ARB.TabIndex = 1;
            this.ARB.TabStop = true;
            this.ARB.Text = "A";
            this.ARB.UseVisualStyleBackColor = true;
            // 
            // BRB
            // 
            this.BRB.AutoSize = true;
            this.BRB.Location = new System.Drawing.Point(6, 64);
            this.BRB.Name = "BRB";
            this.BRB.Size = new System.Drawing.Size(45, 24);
            this.BRB.TabIndex = 2;
            this.BRB.TabStop = true;
            this.BRB.Text = "B";
            this.BRB.UseVisualStyleBackColor = true;
            // 
            // CRB
            // 
            this.CRB.AutoSize = true;
            this.CRB.Location = new System.Drawing.Point(6, 103);
            this.CRB.Name = "CRB";
            this.CRB.Size = new System.Drawing.Size(45, 24);
            this.CRB.TabIndex = 3;
            this.CRB.TabStop = true;
            this.CRB.Text = "C";
            this.CRB.UseVisualStyleBackColor = true;
            // 
            // DRB
            // 
            this.DRB.AutoSize = true;
            this.DRB.Location = new System.Drawing.Point(6, 144);
            this.DRB.Name = "DRB";
            this.DRB.Size = new System.Drawing.Size(46, 24);
            this.DRB.TabIndex = 4;
            this.DRB.TabStop = true;
            this.DRB.Text = "D";
            this.DRB.UseVisualStyleBackColor = true;
            // 
            // VastausLB
            // 
            this.VastausLB.AutoSize = true;
            this.VastausLB.Location = new System.Drawing.Point(46, 181);
            this.VastausLB.Name = "VastausLB";
            this.VastausLB.Size = new System.Drawing.Size(64, 20);
            this.VastausLB.TabIndex = 2;
            this.VastausLB.Text = "vastaus";
            this.VastausLB.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.VastausLB);
            this.Controls.Add(this.VastausGB);
            this.Controls.Add(this.OtsikkoLB);
            this.Name = "Form1";
            this.Text = "10 kysymystä";
            this.VastausGB.ResumeLayout(false);
            this.VastausGB.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label OtsikkoLB;
        private System.Windows.Forms.GroupBox VastausGB;
        private System.Windows.Forms.RadioButton näkymätönRB;
        private System.Windows.Forms.RadioButton DRB;
        private System.Windows.Forms.RadioButton CRB;
        private System.Windows.Forms.RadioButton BRB;
        private System.Windows.Forms.RadioButton ARB;
        private System.Windows.Forms.Label VastausLB;
    }
}

