using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp2
{
    public partial class Menu : Form
    {

        TILAUS tilaus = new TILAUS();
        List<decimal> hinnat = new List<decimal>();

        public Menu()
        {
            InitializeComponent();
            MenuPL.Visible = true;
            MaksuPL.Visible = false;
            TarkastusPL.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e) //VahvistaBT
        {
            SiirryTarkastusIkkunaan();
            PaivitaListView();
        }


        private void TyhjennaBT_Click(object sender, EventArgs e)
        {
            foreach (var c in TaytteetPL.Controls)
            {
                if (c is CheckBox cb)
                    cb.Checked = false;
            }
            foreach (var c in JuomatPL.Controls)
            {
                if (c is RadioButton rb)
                    rb.Checked = false;
            }
            foreach (var c in KokoPL.Controls)
            {
                if (c is RadioButton rb)
                    rb.Checked = false;
            }
            foreach (var c in PaaTaytePL.Controls)
            {
                if (c is RadioButton rb)
                    rb.Checked = false;
            }

        }
        private void Menu_Load(object sender, EventArgs e)
        {
            TyhjennaBT.PerformClick();
        }

        private void TaytteetPL_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LisaaJuomaBT_Click(object sender, EventArgs e)
        {
            string juoma = "";

            foreach (Control c in JuomatPL.Controls)
            {
                if (c is RadioButton rb &&
                   rb.Checked)
                {
                    juoma = rb.Text;
                }
            }

            if (juoma == "")
                return;

            TILAUSRIVI uusi =
                new TILAUSRIVI();

            uusi.Nimi = juoma;

            uusi.Maara = 1;

            uusi.Yksikkohinta = 2.50m;

            tilaus.LisaaRivi(uusi);

            PaivitaListView();
            TyhjennaBT.PerformClick();
        }

        private void LisaaPizzaBT_Click(object sender, EventArgs e)
        {
            string koko = HaeKoko();

            string pizza = HaePizza();


            decimal pohjahinta = 0;

            switch (koko)
            {
                case "Pieni":
                    pohjahinta = 8;
                    break;

                case "Medium":
                    pohjahinta = 11;
                    break;

                case "Perhe":
                    pohjahinta = 13;
                    break;
            }

            int tayteLkm = //laskee täytteiden lukumäärän 
                TaytteetPL.Controls
                .OfType<CheckBox>()
                .Count(x => x.Checked);

            decimal loppuhinta =
                pohjahinta + (tayteLkm * 0.75m); // lisää hintaan täytteiden hinnan

            TILAUSRIVI uusi = new TILAUSRIVI();

            uusi.Nimi =
                koko + " " + pizza + " pizza";

            uusi.Maara = 1;

            uusi.Yksikkohinta = loppuhinta;

            foreach (Control c in TaytteetPL.Controls) //lisää valitut täytteet listalle
            {
                if (c is CheckBox cb && cb.Checked)
                {
                    uusi.Taytteet.Add(cb.Text);
                }
            }

            tilaus.LisaaRivi(uusi);
            PaivitaListView();
            TyhjennaBT.PerformClick();
        }

        private void PeruutaBT_Click(object sender, EventArgs e)
        {
            DialogResult vastaus = MessageBox.Show("Oletko varma että haluat peruuttaa tilauksen?", "Vahvista peruutus", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (vastaus == DialogResult.Yes)
            {
                TyhjennaTilaus();
                TyhjennaBT.PerformClick();
            }

        }

        private void TilaaLisääBT_Click(object sender, EventArgs e)
        {
            SiirryMenuIkkunaan();
        }

        private void SiirryMaksamaanBT_Click(object sender, EventArgs e)
        {
            SiirryMaksuIkkunaan();
        }


        public void SiirryMenuIkkunaan() // Funktio joka näyttää menu paneelin
        {
            MenuPL.Visible = true;
            TarkastusPL.Visible = false;
            MaksuPL.Visible = false;
        }

        public void SiirryTarkastusIkkunaan() // funktio näyttää tarkastus paneelin
        {

            MenuPL.Visible = false;
            TarkastusPL.Visible = true;
            MaksuPL.Visible = false;

        }

        public void SiirryMaksuIkkunaan() // funktio näyttää maksu paneelin
        {
            MenuPL.Visible = false;
            TarkastusPL.Visible = false;
            MaksuPL.Visible = true;
            MaksettavaMaaraTB.Text = tilaus.LaskeLoppusumma().ToString("0.00€");
        }

        private void TarkastaTilausBT_Click(object sender, EventArgs e)
        {
            SiirryTarkastusIkkunaan();
        }

        private void TarkastusPL_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TilausLV_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        string HaeKoko()
        {
            foreach (Control c in KokoPL.Controls)
            {
                if (c is RadioButton rb && rb.Checked)
                {
                    return rb.Text;
                }
            }
            return "";
        }

        string HaePizza()
        {
            foreach (Control c in PaaTaytePL.Controls)
            {
                if (c is RadioButton rb && rb.Checked)
                {
                    return rb.Text;
                }
            }
            return "";
        }


        void PaivitaListView()
        {
            TilausLV.Items.Clear(); // vanhat rivit pois

            foreach (var rivi in tilaus.Rivit)
            {
                ListViewItem item =
                    new ListViewItem(rivi.Nimi);

                item.Tag = rivi; // lisätään koko olio
                item.SubItems.Add(
                    rivi.Maara.ToString()); //lisätään määrä

                item.SubItems.Add(
                    rivi.Yhteensa.ToString("0.00€")); //lisätään hinta

                TilausLV.Items.Add(item);
                foreach (string tayte in rivi.Taytteet)
                {
                    ListViewItem tayteItem =
                        new ListViewItem("   └ " + tayte); // tällä tuo täyteiden hakaviiva
                    tayteItem.SubItems.Add(""); // tyhjä määräsarake
                    tayteItem.SubItems.Add(""); //tyhjät hintasarake

                    TilausLV.Items.Add(tayteItem);
                }
            }

            EnnenVerojaLB.Text =
                tilaus.LaskeVälisumma()
                .ToString("0.00€");
            VerojenJalkeenLB.Text =
                tilaus.LaskeVero()
                .ToString("0.00€");
            YhteensaLB.Text =
                tilaus.LaskeLoppusumma()
                .ToString("0.00€");
            YhteensaLB.Visible = true;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        void TyhjennaTilaus()
        {
            tilaus.Rivit.Clear();
            TilausLV.Items.Clear();
            YhteensaLB.Text = "0,00€";
            EnnenVerojaLB.Text = "0,00€";
            VerojenJalkeenLB.Text = "0,00€";
        }

        private void PlusBT_Click(object sender, EventArgs e)
        {
            if (TilausLV.SelectedItems.Count == 0) //onko valittu mitään
                return;

            ListViewItem item =
                TilausLV.SelectedItems[0];

            if (item.Tag == null)
                return;

            TILAUSRIVI rivi =
                (TILAUSRIVI)item.Tag; // nämä jotta täytteet pysyvät mukana kun ovat erillisillä riveillä

            rivi.Maara++;
            PaivitaListView();
        }

        private void MiinusBT_Click(object sender, EventArgs e)
        {
            if (TilausLV.SelectedItems.Count == 0)
                return;

            ListViewItem item =
                TilausLV.SelectedItems[0];

            if (item.Tag == null)
                return;

            TILAUSRIVI rivi =
                (TILAUSRIVI)item.Tag;

            rivi.Maara--;

            if (rivi.Maara <= 0)
            {
                tilaus.Rivit.Remove(rivi); //jos määrä 0, poistetaan rivi
            }

            PaivitaListView();
        }

        private void PoistaTilauksestaBT_Click(object sender, EventArgs e)
        {
            if (TilausLV.SelectedItems.Count == 0)
                return;

            ListViewItem item =
                TilausLV.SelectedItems[0];

            if (item.Tag == null)
                return;

            TILAUSRIVI rivi =
                (TILAUSRIVI)item.Tag;

            tilaus.Rivit.Remove(rivi);

            PaivitaListView();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void PeruutaBT2_Click(object sender, EventArgs e)
        {
            DialogResult vastaus = MessageBox.Show("Oletko varma että haluat peruuttaa tilauksen?", "Vahvista peruutus", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (vastaus == DialogResult.Yes)
            {
                TyhjennaTilaus();
                TyhjennaBT.PerformClick();
            }

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) // muuttaa sen tarviiko kortin numero kirjoittaa
        {
            if (comboBox1.SelectedIndex == 1)
            {
                kortinNumeroTB.Enabled = true;
                kortinNumeroTB.ReadOnly = false;
            }
            else
            {
                kortinNumeroTB.Enabled = false;
                kortinNumeroTB.ReadOnly = true;
            }
        }

        private void MaksettuTB_TextChanged(object sender, EventArgs e)
        {
            decimal maksettu;
            
            if (decimal.TryParse(MaksettuTB.Text, out maksettu))
            {
                decimal loppusumma = tilaus.LaskeLoppusumma();

                decimal vaihtoraha = maksettu - loppusumma;

                VaihtorahaTB.Text = vaihtoraha.ToString("0.00€");
            }
            else
            {
                VaihtorahaTB.Text = "";
            }
        }

        private void VahvistaMaksuBT_Click(object sender, EventArgs e)
        {
            decimal maksettu;
            decimal vaihtoraha;


            if (enimiTb.Text == "" || snimiTB.Text == "" || OsoiteTB.Text == "" || comboBox1.SelectedIndex == -1 || (kortinNumeroTB.Text == ""  && comboBox1.SelectedIndex == 1))
            {
                MessageBox.Show("Täytäthän vaaditut kentät, kiitos");
            }
            else
            {
                if (decimal.TryParse(MaksettuTB.Text, out maksettu))
                {
                    decimal loppusumma = tilaus.LaskeLoppusumma();

                    vaihtoraha = maksettu - loppusumma;
                }
                else
                {
                    MessageBox.Show("Syötä kelvollinen maksusumma");
                    return;
                }
                if (vaihtoraha < 0)
                {
                    MessageBox.Show("Maksathan lopunkin tilauksesta");

                }

                else
                {
                    lahetaTilausBT.Enabled = true;
                    MessageBox.Show("Tilaus kunnossa, voit halutessasi lähettää tilauksen");
                    
                }


            }
        }
    }
}





