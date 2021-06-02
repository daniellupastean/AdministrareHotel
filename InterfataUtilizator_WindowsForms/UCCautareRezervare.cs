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
    public partial class UCCautareRezervare : UserControl
    {

        List<Rezervare> rezervari = new List<Rezervare>();
        IStocareRezervari adminRezervari = StocareFactory.GetAdministratorStocareRezervari();

        public UCCautareRezervare()
        {
            InitializeComponent();
        }

        private void UCCautareRezervare_Load(object sender, EventArgs e)
        {
            rezervari = adminRezervari.GetRezervari();
        }

        private void BtnCautaRezervare_Click(object sender, EventArgs e)
        {
            if (DateValide())
            {
                int id = int.Parse(TxtIDRezervare.Text);

                Rezervare rezervareAfisare = adminRezervari.GetRezervare(id);
                if (rezervareAfisare == null)
                {
                    LblCautareAvertisment.Text = "Rezervarea nu a fost gasita in baza de date.";
                    PnlAfisareRezervareCautata.Visible = false;
                }
                else
                {
                    LblCautareAvertisment.Text = "";
                    PnlAfisareRezervareCautata.Visible = true;
                    LblHeaderInfo.Text = Rezervare.HeaderInfo() + "   ";
                    LblRezervareCautata.Text = rezervareAfisare.ConversieLaSir();
                }
            }
            else PnlAfisareRezervareCautata.Visible = false;
        }

        bool DateValide()
        {
            if(TxtIDRezervare.Text == "")
            {
                LblCautareAvertisment.Text = "Trebuie completat campul pentru ID";
                return false;
            }

            if(!int.TryParse(TxtIDRezervare.Text, out _))
            {
                LblCautareAvertisment.Text = "ID-ul trebuie sa fie un numar intreg";
                return false;
            }


            return true;
        }
    }
}
