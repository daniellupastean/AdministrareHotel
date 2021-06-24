using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using LibrarieModele;
using NivelAccesDate;
using System.Text.RegularExpressions;

namespace InterfataUtilizator_WindowsForms
{
    public partial class UCAdaugareRezervare : UserControl
    {
        List<Rezervare> rezervari = new List<Rezervare>();
        List<Client> clienti = new List<Client>();
        List<Camera> camere = new List<Camera>();
        IStocareRezervari adminRezervari = StocareFactory.GetAdministratorStocareRezervari();
        IStocareClienti adminClienti = StocareFactory.GetAdministratorStocareClienti();
        IStocareCamere adminCamere = StocareFactory.GetAdministratorStocareCamere();

        public UCAdaugareRezervare()
        {
            InitializeComponent();
        }

        private void UCAdaugareRezervare_Load(object sender, EventArgs e)
        {
            rezervari = adminRezervari.GetRezervari();
            DtpCheckIn.MinDate = DateTime.Now;
            DtpCheckOut.MinDate = DateTime.Now;
        }

        private void BtnAdaugaRezervare_Click(object sender, EventArgs e)
        {
            if(DateValide())
            {
                rezervari = adminRezervari.GetRezervari();
                Rezervare.IdUltimaRezervare++;
                string line = $"{Rezervare.IdUltimaRezervare},{TxtCNPClient.Text},{TxtIDCamera.Text},{DtpCheckIn.Value},{DtpCheckOut.Value}";
                rezervari.Add(new Rezervare(line));
                adminRezervari.AddRezervare(new Rezervare(line));

                ResetareControale();
            }
        }
        
        bool DateValide()
        {
            LblAvertisment.ForeColor = Color.Firebrick;
            if(TxtCNPClient.Text == "" || TxtIDCamera.Text == "" || DtpCheckIn.Value == null || DtpCheckOut.Value == null)
            {
                LblAvertisment.Text = "*Trebuie completate toate campurile";
                return false;
            }
            if(!Functii.OnlyDigits(TxtCNPClient.Text))
            {
                LblAvertisment.Text = "*CNP-ul trebuie sa contina doar cifre";
                return false;
            }

            if(TxtCNPClient.Text.Length != 13)
            {
                LblAvertisment.Text = "*CNP-ul trebuie sa contina 13 cifre";
                return false;
            }

            if(!ExistaClient(TxtCNPClient.Text))
            {
                LblAvertisment.Text = "*Clientul cu CNP-ul introdus nu este in baza de date";
                return false;
            }

            if(!Functii.IsIntNumber(TxtIDCamera.Text))
            {
                LblAvertisment.Text = "*ID-ul camerei trebuie sa fie un numar intreg";
                return false;
            }

            if (!ExistaCamera(TxtIDCamera.Text))
            {
                LblAvertisment.Text = "*Camera cu ID-ul introdus nu este in baza de date";
                return false;
            }

            if (DtpCheckIn.Value.Date >= DtpCheckOut.Value.Date)
            {
                LblAvertisment.Text = "*Data check-in trebuie sa fie inainte de data check-out";
                return false;
            }

            return true;
        }

        void ResetareControale()
        {
            TxtCNPClient.Text = "";
            TxtIDCamera.Text = "";
            DtpCheckIn.Value = DateTime.Now;
            DtpCheckOut.Value = DateTime.Now;
            LblAvertisment.Text = "";
        }

        bool ExistaClient(string s)
        {
            clienti = adminClienti.GetClienti();
            if (clienti.Find(r => r.CNP == s) != null)
                return true;
            else
                return false;
        }

        bool ExistaCamera(string s)
        {
            camere = adminCamere.GetCamere();
            if (camere.Find(r => r.ID_camera == int.Parse(s)) != null)
                return true;
            else
                return false;
        }


    }
}
