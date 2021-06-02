using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using LibrarieModele;
using NivelAccesDate;

namespace InterfataUtilizator_WindowsForms
{
    public partial class UCModificareAngajat : UserControl
    {
        List<Angajat> angajati;
        IStocareAngajati adminAngajati = StocareFactory.GetAdministratorStocareAngajati();

        public UCModificareAngajat()
        {
            InitializeComponent();
        }

        private void UCModificareAngajat_Load(object sender, EventArgs e)
        {
            angajati = adminAngajati.GetAngajati();
        }

        private void BtnCautaAngajat_Click(object sender, EventArgs e)
        {
            string nume = TxtNumeAngajatCautat.Text;
            string prenume = TxtPrenumeAngajatCautat.Text;

            Angajat angajatAfisare = adminAngajati.GetAngajat(nume, prenume);
            if (angajatAfisare == null)
            {
                LblCautareAvertisment.Text = "Acest angajat nu a fost gasit in baza de date.";
                PnlDateAngajat.Visible = false;
            }
            else
            {
                LblCautareAvertisment.Text = "";
                PnlDateAngajat.Visible = true;
                TxtNumeAngajat.Text = angajatAfisare.Nume;
                TxtPrenumeAngajat.Text = angajatAfisare.Prenume;
                TxtCNPAngajat.Text = angajatAfisare.CNP;
                CbxFunctieAngajat.SelectedItem = angajatAfisare.Functie;
                TxtSalariuAngajat.Text = angajatAfisare.Salariu.ToString();
            }
        }

        private void BtnModificaAngajat_Click(object sender, EventArgs e)
        {
            angajati = adminAngajati.GetAngajati();
            string nume = TxtNumeAngajatCautat.Text;
            string prenume = TxtPrenumeAngajatCautat.Text;

            Angajat angajatAfisare = adminAngajati.GetAngajat(nume, prenume);

            if (TxtNumeAngajat.Text != "" && TxtPrenumeAngajat.Text != "" && TxtCNPAngajat.Text != "")
            {
                int i = 0;

                while (angajati[i].Nume != angajatAfisare.Nume && angajati[i].Prenume != angajatAfisare.Prenume)
                {
                    i++;
                }

                angajati[i].Nume = TxtNumeAngajat.Text;
                angajati[i].Prenume = TxtPrenumeAngajat.Text;
                angajati[i].CNP = TxtCNPAngajat.Text;
                angajati[i].Functie = CbxFunctieAngajat.SelectedItem.ToString();
                angajati[i].Salariu = float.Parse(TxtSalariuAngajat.Text);
                angajati[i].DataActualizare = DateTime.Now;

                TxtNumeAngajatCautat.Text = "";
                TxtPrenumeAngajatCautat.Text = "";
                TxtNumeAngajat.Text = "";
                TxtPrenumeAngajat.Text = "";
                TxtCNPAngajat.Text = "";
                TxtSalariuAngajat.Text = "";
                CbxFunctieAngajat.SelectedIndex = 0;
                PnlDateAngajat.Visible = false;
                LblAvertismentModificare.Text = "";
            }
            else
            {
                LblAvertismentModificare.Text = "*Trebuie completate toate campurile pentru a putea realiza modificarea";
            }
            adminAngajati.UpdateFisierAngajati(angajati);
        }
    }
}
