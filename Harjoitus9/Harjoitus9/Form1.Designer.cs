namespace Harjoitus9
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
            this.label1 = new System.Windows.Forms.Label();
            this.AsteetTB = new System.Windows.Forms.TextBox();
            this.MuuntoGB = new System.Windows.Forms.GroupBox();
            this.CelciusRB = new System.Windows.Forms.RadioButton();
            this.FarenhaitRB = new System.Windows.Forms.RadioButton();
            this.MuunnaBT = new System.Windows.Forms.Button();
            this.VastausLB = new System.Windows.Forms.Label();
            this.MuuntoGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Anna asteet: ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // AsteetTB
            // 
            this.AsteetTB.Location = new System.Drawing.Point(228, 146);
            this.AsteetTB.Name = "AsteetTB";
            this.AsteetTB.Size = new System.Drawing.Size(100, 26);
            this.AsteetTB.TabIndex = 1;
            // 
            // MuuntoGB
            // 
            this.MuuntoGB.Controls.Add(this.FarenhaitRB);
            this.MuuntoGB.Controls.Add(this.CelciusRB);
            this.MuuntoGB.Location = new System.Drawing.Point(422, 115);
            this.MuuntoGB.Name = "MuuntoGB";
            this.MuuntoGB.Size = new System.Drawing.Size(200, 100);
            this.MuuntoGB.TabIndex = 2;
            this.MuuntoGB.TabStop = false;
            this.MuuntoGB.Text = "Miten muunnat?";
            // 
            // CelciusRB
            // 
            this.CelciusRB.AutoSize = true;
            this.CelciusRB.Location = new System.Drawing.Point(7, 26);
            this.CelciusRB.Name = "CelciusRB";
            this.CelciusRB.Size = new System.Drawing.Size(85, 24);
            this.CelciusRB.TabIndex = 0;
            this.CelciusRB.TabStop = true;
            this.CelciusRB.Text = "Celcius";
            this.CelciusRB.UseVisualStyleBackColor = true;
            // 
            // FarenhaitRB
            // 
            this.FarenhaitRB.AutoSize = true;
            this.FarenhaitRB.Location = new System.Drawing.Point(7, 57);
            this.FarenhaitRB.Name = "FarenhaitRB";
            this.FarenhaitRB.Size = new System.Drawing.Size(102, 24);
            this.FarenhaitRB.TabIndex = 1;
            this.FarenhaitRB.TabStop = true;
            this.FarenhaitRB.Text = "Farenhait";
            this.FarenhaitRB.UseVisualStyleBackColor = true;
            // 
            // MuunnaBT
            // 
            this.MuunnaBT.Location = new System.Drawing.Point(675, 148);
            this.MuunnaBT.Name = "MuunnaBT";
            this.MuunnaBT.Size = new System.Drawing.Size(75, 23);
            this.MuunnaBT.TabIndex = 3;
            this.MuunnaBT.Text = "Muunna";
            this.MuunnaBT.UseVisualStyleBackColor = true;
            this.MuunnaBT.Click += new System.EventHandler(this.MuunnaBT_Click);
            // 
            // VastausLB
            // 
            this.VastausLB.AutoSize = true;
            this.VastausLB.Location = new System.Drawing.Point(80, 274);
            this.VastausLB.Name = "VastausLB";
            this.VastausLB.Size = new System.Drawing.Size(16, 20);
            this.VastausLB.TabIndex = 4;
            this.VastausLB.Text = "x";
            this.VastausLB.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.VastausLB);
            this.Controls.Add(this.MuunnaBT);
            this.Controls.Add(this.MuuntoGB);
            this.Controls.Add(this.AsteetTB);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.MuuntoGB.ResumeLayout(false);
            this.MuuntoGB.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox AsteetTB;
        private System.Windows.Forms.GroupBox MuuntoGB;
        private System.Windows.Forms.RadioButton FarenhaitRB;
        private System.Windows.Forms.RadioButton CelciusRB;
        private System.Windows.Forms.Button MuunnaBT;
        private System.Windows.Forms.Label VastausLB;
    }
}

