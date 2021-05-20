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
    public partial class UCAdaugareClient : UserControl
    {


        List<Client> clienti;
        IStocareClienti adminClienti = StocareFactory.GetAdministratorStocareClienti();
        int nrClienti;

        public UCAdaugareClient()
        {
            InitializeComponent();
        }

        private void BtnAdaugaClient_Click(object sender, EventArgs e)
        {
            if (TxtNumeClient.Text != "" && TxtPrenumeClient.Text != "" && TxtCNPClient.Text != "")
            {
                LblAdaugareClientAvertisment.ForeColor = Color.Green;
                string line = $"{TxtCNPClient.Text},{TxtNumeClient.Text},{TxtPrenumeClient.Text},0";
                clienti.Add(new Client(line));
                adminClienti.AddClient(new Client(line));

                TxtNumeClient.Text = "";
                TxtPrenumeClient.Text = "";
                TxtCNPClient.Text = "";
                LblAdaugareClientAvertisment.Text = "Clientul a fost adaugat cu succes";
            }
            else
            {
                LblAdaugareClientAvertisment.ForeColor = Color.Firebrick;
                LblAdaugareClientAvertisment.Text = "*Trebuie completate toate campurile";
            }
        }

        private void UCAdaugareClient_Load(object sender, EventArgs e)
        {
            clienti = adminClienti.GetClienti();
            nrClienti = clienti.Count;
            Client.IdUltimClient = nrClienti;
        }
    }
}
