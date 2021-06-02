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
    public partial class UCAfisareRezervari : UserControl
    {
        List<Rezervare> rezervari = new List<Rezervare>();
        IStocareRezervari adminRezervari = StocareFactory.GetAdministratorStocareRezervari();

        public UCAfisareRezervari()
        {
            InitializeComponent();
        }

        private void UCAfisareRezervari_Load(object sender, EventArgs e)
        {
            rezervari = adminRezervari.GetRezervari();
        }

        private void PnlAfisareRezervari_VisibleChanged(object sender, EventArgs e)
        {
            if (PnlAfisareRezervari.Visible == true)
            {
                rezervari = adminRezervari.GetRezervari();
                LsBxAfisareRezervari.Items.Clear();
                LsBxAfisareRezervari.Items.Add(Rezervare.HeaderInfo());
                foreach (Rezervare rezervare in rezervari)
                {
                    LsBxAfisareRezervari.Items.Add(rezervare.ConversieLaSir());
                }
            }
        }

        private void LsBxAfisareRezervari_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LsBxAfisareRezervari.SelectedIndex == 0)
                BtnStergeRezervare.Enabled = false;
            else
            {
                BtnStergeRezervare.Enabled = true;
            }
        }

        private void BtnStergeRezervare_Click(object sender, EventArgs e)
        {
            rezervari = adminRezervari.GetRezervari();
            rezervari.RemoveAll(r => r.ConversieLaSir() == LsBxAfisareRezervari.SelectedItem.ToString());
            adminRezervari.UpdateFisierRezervari(rezervari);
            LsBxAfisareRezervari.Items.Clear();
            LsBxAfisareRezervari.Items.Add(Angajat.HeaderInfo());
            foreach (Rezervare rezervare in rezervari)
            {
                LsBxAfisareRezervari.Items.Add(rezervare.ConversieLaSir());
            }
        }
    }
}
