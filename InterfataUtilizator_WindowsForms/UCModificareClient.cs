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

        private void BtnCautaClient_Click(object sender, EventArgs e)
        {   
            string nume = TxtNumeClientCautat.Text;
            string prenume = TxtPrenumeClientCautat.Text;

            Client clientAfisare = adminClienti.GetClient(nume, prenume);
            if (clientAfisare == null)
            {
                LblCautareAvertisment.Text = "Acest client nu a fost gasit in baza de date.";
                PnlDateClient.Visible = false;
            }
            else
            {
                LblCautareAvertisment.Text = "";
                PnlDateClient.Visible = true;
                TxtNumeClient.Text = clientAfisare.Nume;
                TxtPrenumeClient.Text = clientAfisare.Prenume;
                TxtCNPClient.Text = clientAfisare.CNP;
            }
        }

        private void BtnModificaClient_Click(object sender, EventArgs e)
        {
            clienti = adminClienti.GetClienti();
            string nume = TxtNumeClientCautat.Text;
            string prenume = TxtPrenumeClientCautat.Text;

            Client clientAfisare = adminClienti.GetClient(nume, prenume);

            if (DateValide())
            {
                int i = 0;

                while (clienti[i].Nume != clientAfisare.Nume && clienti[i].Prenume != clientAfisare.Prenume)
                {
                    i++;
                }

                clienti[i].Nume = TxtNumeClient.Text;
                clienti[i].Prenume = TxtPrenumeClient.Text;
                clienti[i].CNP = TxtCNPClient.Text;

                TxtNumeClient.Text = "";
                TxtPrenumeClient.Text = "";
                TxtNumeClientCautat.Text = "";
                TxtPrenumeClientCautat.Text = "";
                TxtCNPClient.Text = "";
                PnlDateClient.Visible = false;
                LblAvertismentModificare.Text = "";
            }
            
            adminClienti.UpdateFisierClienti(clienti);
        }



        bool DateValide()
        {
            if(TxtNumeClient.Text == "" || TxtPrenumeClient.Text == "" || TxtCNPClient.Text == "")
            {
                LblAvertismentModificare.Text = "*Trebuie completate toate campurile";
                return false;
            }
            if (!Functii.OnlyLetters(TxtNumeClient.Text))
            {
                LblAvertismentModificare.Text = "*Numele poate sa contina doar litere";
                return false;
            }
            if (!Functii.OnlyLetters(TxtPrenumeClient.Text))
            {
                LblAvertismentModificare.Text = "*Prenumele poate sa contina doar litere";
                return false;
            }
            if (TxtCNPClient.TextLength != 13)
            {
                LblAvertismentModificare.Text = "CNP-ul trebuie sa aiba lungimea 13";
                return false;
            }

            if (!Functii.OnlyDigits(TxtCNPClient.Text))
            {
                LblAvertismentModificare.Text = "CNP-ul trebuie sa contina doar cifre";
                return false;
            }
            return true;
        }
    }
}
