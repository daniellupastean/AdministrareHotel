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

        public UCAdaugareClient()
        {
            InitializeComponent();
        }

        private void BtnAdaugaClient_Click(object sender, EventArgs e)
        {
            if (DateValide())
            {
                string line = $"{TxtCNPClient.Text},{TxtNumeClient.Text},{TxtPrenumeClient.Text},0";
                clienti.Add(new Client(line));
                adminClienti.AddClient(new Client(line));

                ResetareControale();
            }
        }

        private void UCAdaugareClient_Load(object sender, EventArgs e)
        {
            clienti = adminClienti.GetClienti();
        }

        bool DateValide()
        {
            if(TxtNumeClient.Text == "" && TxtPrenumeClient.Text == "" && TxtCNPClient.Text == "")
            {
                LblAdaugareClientAvertisment.ForeColor = Color.Firebrick;
                LblAdaugareClientAvertisment.Text = "*Trebuie completate toate campurile";
                return false;
            }
            if(!Functii.OnlyLetters(TxtNumeClient.Text))
            {
                LblAdaugareClientAvertisment.Text = "*Numele poate sa contina doar litere";
                return false;
            }
            if (!Functii.OnlyLetters(TxtPrenumeClient.Text))
            {
                LblAdaugareClientAvertisment.Text = "*Prenumele poate sa contina doar litere";
                return false;
            }
            if (TxtCNPClient.TextLength != 13)
            {
                LblAdaugareClientAvertisment.Text = "CNP-ul trebuie sa aiba lungimea 13";
                return false;
            }
            
            if(!Functii.OnlyDigits(TxtCNPClient.Text))
            {
                LblAdaugareClientAvertisment.Text = "CNP-ul trebuie sa contina doar cifre";
                return false;
            }
            return true;
        }

        void ResetareControale()
        {
            TxtNumeClient.Text = "";
            TxtPrenumeClient.Text = "";
            TxtCNPClient.Text = "";
            LblAdaugareClientAvertisment.Text = "";
        }

    }
}
