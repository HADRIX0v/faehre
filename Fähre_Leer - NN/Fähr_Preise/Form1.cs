using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Fähr_Preise
{
    public partial class Form1
    {
        String[] Art = new String[4];
        int[] Preis = new int[4];
        int[] Pers = { 5, 5, 1, 1 };
        public Form1()
        {
            InitializeComponent();

            Art[0] = "PKW";
            Art[1] = "Wohnmobil";
            Art[2] = "Motorrad";
            Art[3] = "Fußgänger";

            Preis[0] = 185;
            Preis[1] = 339;
            Preis[2] = 90;
            Preis[3] = 70;

            cboTyp.Items.AddRange(Art);
        }
        private void btnBerechne_Click(object sender, EventArgs e)
        {
            int Grundtarif, zusatzTarif, anzahl;

            try
            {
                if (cboTyp.SelectedIndex == -1)
                {
                    MessageBox.Show("Bitte Fahrzeugtyp wählen!");
                    return;
                }

                if (String.IsNullOrEmpty(txtAnzahl.Text))
                {
                    MessageBox.Show("Bitte Anzahl eingeben!");
                    return;
                }

                if (!Information.IsNumeric(txtAnzahl.Text))
                {
                    MessageBox.Show("Anzahl bitte als Zahl eingeben!");
                    return;
                }

                Grundtarif = 0;
                zusatzTarif = 0;

                lstProtokoll.Items.Clear();

                anzahl = Convert.ToInt32(txtAnzahl.Text);

                Grundtarif = Preis[cboTyp.SelectedIndex];

                lstProtokoll.Items.Add(Grundtarif);

                if (anzahl > Pers[cboTyp.SelectedIndex])
                {
                    anzahl = anzahl - Pers[cboTyp.SelectedIndex];

                    zusatzTarif = anzahl * Preis[3];
                } 

                lstProtokoll.Items.Add(zusatzTarif);

                lblSumme.Text = Convert.ToString(Grundtarif + zusatzTarif) + "€";

                lblAusgabe.Text = "zu zahlender Preis:         " + Convert.ToString(Grundtarif + zusatzTarif) + " Euro";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void cboTyp_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtAnzahl.Enabled = true;
            if(cboTyp.SelectedIndex == 3)
            {
                txtAnzahl.Enabled = false;
                txtAnzahl.Text = "1";
            }
        }
        private void btnSchliesse_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}