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
    public partial class UCAfisareClienti : UserControl
    {
        List<Client> clienti;
        IStocareClienti adminClienti = StocareFactory.GetAdministratorStocareClienti();
        int nrClienti;

        public UCAfisareClienti()
        {
            InitializeComponent();
        }

        private void UCAfisareClienti_Load(object sender, EventArgs e)
        {
            clienti = adminClienti.GetClienti();
            nrClienti = clienti.Count;
            Client.IdUltimClient = nrClienti;
        }

        private void PnlAfisareClienti_VisibleChanged(object sender, EventArgs e)
        {

            if (PnlAfisareClienti.Visible == true)
            {
                clienti = adminClienti.GetClienti();
                LsBxAfisareClienti.Items.Clear();
                LsBxAfisareClienti.Items.Add(Client.HeaderInfo());
                foreach (Client client in clienti)
                {
                    LsBxAfisareClienti.Items.Add(client.ConversieLaSir());
                }
            }
        }
    }
}
