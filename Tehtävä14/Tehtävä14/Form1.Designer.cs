namespace Tehtävä14
{
    partial class PaivakirjaFM
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
            this.PaivakirjaTB = new System.Windows.Forms.TextBox();
            this.LisaaBT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PaivakirjaTB
            // 
            this.PaivakirjaTB.Location = new System.Drawing.Point(34, 24);
            this.PaivakirjaTB.Multiline = true;
            this.PaivakirjaTB.Name = "PaivakirjaTB";
            this.PaivakirjaTB.Size = new System.Drawing.Size(727, 399);
            this.PaivakirjaTB.TabIndex = 0;
            // 
            // LisaaBT
            // 
            this.LisaaBT.Location = new System.Drawing.Point(34, 442);
            this.LisaaBT.Name = "LisaaBT";
            this.LisaaBT.Size = new System.Drawing.Size(727, 36);
            this.LisaaBT.TabIndex = 1;
            this.LisaaBT.Text = "Lisää päiväkirjaan";
            this.LisaaBT.UseVisualStyleBackColor = true;
            this.LisaaBT.Click += new System.EventHandler(this.LisaaBT_Click);
            // 
            // PaivakirjaFM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 508);
            this.Controls.Add(this.LisaaBT);
            this.Controls.Add(this.PaivakirjaTB);
            this.Name = "PaivakirjaFM";
            this.Text = "Päiväkirja";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PaivakirjaTB;
        private System.Windows.Forms.Button LisaaBT;
    }
}

