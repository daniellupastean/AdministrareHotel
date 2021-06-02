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

        public UCAfisareClienti()
        {
            InitializeComponent();
        }

        private void UCAfisareClienti_Load(object sender, EventArgs e)
        {
            clienti = adminClienti.GetClienti();
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

        private void LsBxAfisareClienti_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LsBxAfisareClienti.SelectedIndex == 0)
                BtnStergeClient.Enabled = false;
            else
            {
                BtnStergeClient.Enabled = true;
            }
        }

        private void BtnStergeClient_Click(object sender, EventArgs e)
        {
            clienti = adminClienti.GetClienti();
            clienti.RemoveAll(r => r.ConversieLaSir() == LsBxAfisareClienti.SelectedItem.ToString());
            adminClienti.UpdateFisierClienti(clienti);
            LsBxAfisareClienti.Items.Clear();
            LsBxAfisareClienti.Items.Add(Client.HeaderInfo());
            foreach (Client client in clienti)
            {
                LsBxAfisareClienti.Items.Add(client.ConversieLaSir());
            }
        }
    }
}
