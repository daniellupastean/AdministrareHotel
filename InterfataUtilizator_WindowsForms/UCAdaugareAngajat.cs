using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using LibrarieModele;
using NivelAccesDate;

namespace InterfataUtilizator_WindowsForms
{
    public partial class UCAdaugareAngajat : UserControl
    {
        List<Angajat> angajati;
        IStocareAngajati adminAngajati = StocareFactory.GetAdministratorStocareAngajati();

        public UCAdaugareAngajat()
        {
            InitializeComponent();
            cbxFunctieAngajat.SelectedItem = null;
        }

        private void UCAdaugareAngajat_Load(object sender, EventArgs e)
        {
            angajati = adminAngajati.GetAngajati();
        }

        private void BtnAdaugaAngajat_Click(object sender, EventArgs e)
        {
            angajati = adminAngajati.GetAngajati();
            if (DateValide())
            {
                string line = $"{TxtCNPAngajat.Text},{TxtNumeAngajat.Text},{TxtPrenumeAngajat.Text},{cbxFunctieAngajat.SelectedItem},{TxtSalariuAngajat.Text},{DateTime.Now.ToString()}";
                angajati.Add(new Angajat(line));
                adminAngajati.AddAngajat(new Angajat(line));
                ResetareControale();
                LblAdaugareAngajatAvertisment.Text = "Angajatul a fost adaugat cu succes";
            }
            
        }

        bool DateValide()
        {
            LblAdaugareAngajatAvertisment.ForeColor = Color.Firebrick;
            if (TxtNumeAngajat.Text == "" || TxtPrenumeAngajat.Text == "" || TxtCNPAngajat.Text == "" || TxtSalariuAngajat.Text == "" || cbxFunctieAngajat.SelectedItem == null)
            {
                LblAdaugareAngajatAvertisment.Text = "*Trebuie completate toate campurile";
                return false;
            }
            if (!Functii.OnlyLetters(TxtNumeAngajat.Text))
            {
                LblAdaugareAngajatAvertisment.Text = "Numele trebuie sa contina doar litere";
                return false;
            }
            if(!Functii.OnlyLetters(TxtPrenumeAngajat.Text))
            {
                LblAdaugareAngajatAvertisment.Text = "Prenumele trebuie sa contina doar litere";
                return false;
            }
            if (TxtCNPAngajat.TextLength != 13)
            {
                LblAdaugareAngajatAvertisment.Text = "CNP-ul trebuie sa aiba lungimea 13";
                return false;
            }
            if(!Functii.OnlyDigits(TxtCNPAngajat.Text))
            {
                LblAdaugareAngajatAvertisment.Text = "CNP-ul trebuie sa contina doar cifre";
                return false;
            }
            if(!Functii.IsFloatNumber(TxtSalariuAngajat.Text))
            {
                LblAdaugareAngajatAvertisment.Text = "Salariul introdus este invalid";
                return false;
            }
            LblAdaugareAngajatAvertisment.ForeColor = Color.Green;
            return true;
        }

        void ResetareControale()
        {
            TxtNumeAngajat.Text = "";
            TxtPrenumeAngajat.Text = "";
            TxtCNPAngajat.Text = "";
            TxtSalariuAngajat.Text = "";
            cbxFunctieAngajat.SelectedItem = null;
        }

        private void PnlAddCamera_VisibleChanged(object sender, EventArgs e)
        {
            LblAdaugareAngajatAvertisment.Text = "";
        }
    }
}
