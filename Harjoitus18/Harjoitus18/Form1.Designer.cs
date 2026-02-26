namespace Harjoitus18
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.oppilaitoksetCB = new System.Windows.Forms.ComboBox();
            this.vastuuhenkilotCB = new System.Windows.Forms.ComboBox();
            this.osoiteLB = new System.Windows.Forms.Label();
            this.postinroLB = new System.Windows.Forms.Label();
            this.kaupunkiLB = new System.Windows.Forms.Label();
            this.puhoLB = new System.Windows.Forms.Label();
            this.titteliLB = new System.Windows.Forms.Label();
            this.osastoLB = new System.Windows.Forms.Label();
            this.spostiLB = new System.Windows.Forms.Label();
            this.puhvLB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(135, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(569, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "Oppilaitosten avainhenkilöt";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Valitse oppilaitos:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(526, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(243, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Valitse vastuuhenkilö:";
            // 
            // oppilaitoksetCB
            // 
            this.oppilaitoksetCB.FormattingEnabled = true;
            this.oppilaitoksetCB.Location = new System.Drawing.Point(41, 211);
            this.oppilaitoksetCB.Name = "oppilaitoksetCB";
            this.oppilaitoksetCB.Size = new System.Drawing.Size(197, 28);
            this.oppilaitoksetCB.TabIndex = 3;
            this.oppilaitoksetCB.SelectedIndexChanged += new System.EventHandler(this.oppilaitoksetCB_SelectedIndexChanged);
            // 
            // vastuuhenkilotCB
            // 
            this.vastuuhenkilotCB.FormattingEnabled = true;
            this.vastuuhenkilotCB.Location = new System.Drawing.Point(531, 211);
            this.vastuuhenkilotCB.Name = "vastuuhenkilotCB";
            this.vastuuhenkilotCB.Size = new System.Drawing.Size(238, 28);
            this.vastuuhenkilotCB.TabIndex = 4;
            this.vastuuhenkilotCB.SelectedIndexChanged += new System.EventHandler(this.vastuuhenkilotCB_SelectedIndexChanged);
            // 
            // osoiteLB
            // 
            this.osoiteLB.AutoSize = true;
            this.osoiteLB.Location = new System.Drawing.Point(41, 271);
            this.osoiteLB.Name = "osoiteLB";
            this.osoiteLB.Size = new System.Drawing.Size(13, 20);
            this.osoiteLB.TabIndex = 5;
            this.osoiteLB.Text = " ";
            // 
            // postinroLB
            // 
            this.postinroLB.AutoSize = true;
            this.postinroLB.Location = new System.Drawing.Point(41, 319);
            this.postinroLB.Name = "postinroLB";
            this.postinroLB.Size = new System.Drawing.Size(13, 20);
            this.postinroLB.TabIndex = 6;
            this.postinroLB.Text = " ";
            // 
            // kaupunkiLB
            // 
            this.kaupunkiLB.AutoSize = true;
            this.kaupunkiLB.Location = new System.Drawing.Point(41, 369);
            this.kaupunkiLB.Name = "kaupunkiLB";
            this.kaupunkiLB.Size = new System.Drawing.Size(13, 20);
            this.kaupunkiLB.TabIndex = 7;
            this.kaupunkiLB.Text = " ";
            // 
            // puhoLB
            // 
            this.puhoLB.AutoSize = true;
            this.puhoLB.Location = new System.Drawing.Point(45, 414);
            this.puhoLB.Name = "puhoLB";
            this.puhoLB.Size = new System.Drawing.Size(13, 20);
            this.puhoLB.TabIndex = 8;
            this.puhoLB.Text = " ";
            // 
            // titteliLB
            // 
            this.titteliLB.AutoSize = true;
            this.titteliLB.Location = new System.Drawing.Point(527, 271);
            this.titteliLB.Name = "titteliLB";
            this.titteliLB.Size = new System.Drawing.Size(13, 20);
            this.titteliLB.TabIndex = 9;
            this.titteliLB.Text = " ";
            // 
            // osastoLB
            // 
            this.osastoLB.AutoSize = true;
            this.osastoLB.Location = new System.Drawing.Point(527, 319);
            this.osastoLB.Name = "osastoLB";
            this.osastoLB.Size = new System.Drawing.Size(13, 20);
            this.osastoLB.TabIndex = 10;
            this.osastoLB.Text = " ";
            // 
            // spostiLB
            // 
            this.spostiLB.AutoSize = true;
            this.spostiLB.Location = new System.Drawing.Point(527, 369);
            this.spostiLB.Name = "spostiLB";
            this.spostiLB.Size = new System.Drawing.Size(13, 20);
            this.spostiLB.TabIndex = 11;
            this.spostiLB.Text = " ";
            // 
            // puhvLB
            // 
            this.puhvLB.AutoSize = true;
            this.puhvLB.Location = new System.Drawing.Point(531, 413);
            this.puhvLB.Name = "puhvLB";
            this.puhvLB.Size = new System.Drawing.Size(13, 20);
            this.puhvLB.TabIndex = 12;
            this.puhvLB.Text = " ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 525);
            this.Controls.Add(this.puhvLB);
            this.Controls.Add(this.spostiLB);
            this.Controls.Add(this.osastoLB);
            this.Controls.Add(this.titteliLB);
            this.Controls.Add(this.puhoLB);
            this.Controls.Add(this.kaupunkiLB);
            this.Controls.Add(this.postinroLB);
            this.Controls.Add(this.osoiteLB);
            this.Controls.Add(this.vastuuhenkilotCB);
            this.Controls.Add(this.oppilaitoksetCB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox oppilaitoksetCB;
        private System.Windows.Forms.ComboBox vastuuhenkilotCB;
        private System.Windows.Forms.Label osoiteLB;
        private System.Windows.Forms.Label postinroLB;
        private System.Windows.Forms.Label kaupunkiLB;
        private System.Windows.Forms.Label puhoLB;
        private System.Windows.Forms.Label titteliLB;
        private System.Windows.Forms.Label osastoLB;
        private System.Windows.Forms.Label spostiLB;
        private System.Windows.Forms.Label puhvLB;
    }
}

