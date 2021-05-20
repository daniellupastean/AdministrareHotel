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
    public partial class UCModificareClient : UserControl
    {
        List<Client> clienti;
        IStocareClienti adminClienti = StocareFactory.GetAdministratorStocareClienti();
        int nrClienti;

        public UCModificareClient()
        {
            InitializeComponent();
        }

        private void UCModificareClient_Load(object sender, EventArgs e)
        {
            clienti = adminClienti.GetClienti();
            nrClienti = clienti.Count;
            Client.IdUltimClient = nrClienti;
        }


    }
}
