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
    public partial class UCCautareClient : UserControl
    {
        List<Client> clienti;
        IStocareClienti adminClienti = StocareFactory.GetAdministratorStocareClienti();
        int nrClienti;

        public UCCautareClient()
        {
            InitializeComponent();
        }

        private void UCCautareClient_Load(object sender, EventArgs e)
        {
            clienti = adminClienti.GetClienti();
            nrClienti = clienti.Count;
            Client.IdUltimClient = nrClienti;
        }

        private void BtnCautaClient_Click(object sender, EventArgs e)
        {
            string nume = TxtNumeClientCautat.Text;
            string prenume = TxtPrenumeClientCautat.Text;

            Client clientAfisare = adminClienti.GetClient(nume, prenume);
            if (clientAfisare == null)
            {
                LblAvertismentCautare.Text = "Acest client nu a fost gasit in baza de date.";
                PnlAfisareClientCautat.Visible = false;
            }
            else
            {
                LblAvertismentCautare.Text = "";
                PnlAfisareClientCautat.Visible = true;
                LblHeaderInfo.Text = Client.HeaderInfo() + "   ";
                LblClientCautat.Text = clientAfisare.ConversieLaSir();
            }
        }
    }
}
