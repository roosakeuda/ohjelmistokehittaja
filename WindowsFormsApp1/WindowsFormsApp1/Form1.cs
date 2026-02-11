using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private Stopwatch sekkari = new Stopwatch();
        public Form1()
        {
            InitializeComponent();


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void StartBT_Click(object sender, EventArgs e)
        {
            sekkari.Start();
        }

        private void StopBT_Click(object sender, EventArgs e)
        {
            sekkari.Stop();
        }

        private void ResetBT_Click(object sender, EventArgs e)
        {
            sekkari.Reset();
        }

        private void AjastinTR_Tick(object sender, EventArgs e)
        {
            KelloLB.Text = String.Format("{0:hh\\:mm\\:ss\\:fff}");
        }
    }
}
