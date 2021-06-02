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
    public partial class UCCautareAngajat : UserControl
    {
        List<Angajat> angajati;
        IStocareAngajati adminAngajati = StocareFactory.GetAdministratorStocareAngajati();

        public UCCautareAngajat()
        {
            InitializeComponent();
        }


        private void UCCautareAngajat_Load(object sender, EventArgs e)
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
                LblAvertismentCautare.Text = "Acest angajat nu a fost gasit in baza de date.";
                PnlAfisareAngajatCautat.Visible = false;
            }
            else
            {
                LblAvertismentCautare.Text = "";
                PnlAfisareAngajatCautat.Visible = true;
                LblHeaderInfo.Text = Angajat.HeaderInfo() + "   ";
                LblAngajatCautat.Text = angajatAfisare.ConversieLaSir();
            }
        }

        private void UCCautareAngajat_VisibleChanged(object sender, EventArgs e)
        {
            LblAvertismentCautare.Text = "";
        }

        private void PnlCautareAngajat_VisibleChanged(object sender, EventArgs e)
        {
            LblAvertismentCautare.Text = "";
        }
    }
}
