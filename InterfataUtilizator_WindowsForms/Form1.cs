using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using NivelAccesDate;
using LibrarieModele;

namespace InterfataUtilizator_WindowsForms
{


    public partial class MainForm : Form
    {
        int mov;
        int movX;
        int movY;

        ///Adaugare controale in Form
        Point locatie = new Point(32, 51);

        UCAdaugareCamera PnlAdaugareCamera = new UCAdaugareCamera();
        UCAfisareCamere PnlAfisareCamere = new UCAfisareCamere();
        UCModificareCamera PnlModificareCamera = new UCModificareCamera();
        UCCautareCamera PnlCautareCamera = new UCCautareCamera();

        UCAdaugareRezervare PnlAdaugareRezervare = new UCAdaugareRezervare();
        UCAfisareRezervari PnlAfisareRezervari = new UCAfisareRezervari();
        UCModificareRezervare PnlModificareRezervare = new UCModificareRezervare();
        UCCautareRezervare PnlCautareRezervare = new UCCautareRezervare();

        UCAdaugareClient PnlAdaugareClient = new UCAdaugareClient();
        UCAfisareClienti PnlAfisareClienti = new UCAfisareClienti();
        UCModificareClient PnlModificareClient = new UCModificareClient();
        UCCautareClient PnlCautareClient = new UCCautareClient();

        UCAdaugareAngajat PnlAdaugareAngajat = new UCAdaugareAngajat();
        UCAfisareAngajati PnlAfisareAngajati = new UCAfisareAngajati();
        UCModificareAngajat PnlModificareAngajat = new UCModificareAngajat();
        UCCautareAngajat PnlCautareAngajat = new UCCautareAngajat();


        ///Legatura cu backend-ul
        List<Client> clienti;
        List<Angajat> angajati;
        List<Camera> camere;
        List<Rezervare> rezervari;

        IStocareClienti adminClienti = StocareFactory.GetAdministratorStocareClienti();
        IStocareAngajati adminAngajati = StocareFactory.GetAdministratorStocareAngajati();
        IStocareCamere adminCamere = StocareFactory.GetAdministratorStocareCamere();
        IStocareRezervari adminRezervari = StocareFactory.GetAdministratorStocareRezervari();

        int nrClienti;
        int nrAngajati;
        int nrCamere;
        int nrRezervari;

        public MainForm()
        {
            InitializeComponent();
            
            clienti = adminClienti.GetClienti();
            angajati = adminAngajati.GetAngajati();
            camere = adminCamere.GetCamere();
            rezervari = adminRezervari.GetRezervari();

            nrClienti = clienti.Count;
            Client.IdUltimClient = nrClienti;

            nrAngajati = angajati.Count;
            Angajat.IdUltimAngajat = nrAngajati;

            nrCamere = camere.Count;
            Camera.IdUltimaCamera = nrCamere;

            nrRezervari = rezervari.Count;
            Rezervare.IdUltimaRezervare = nrRezervari;


            PnlAdaugareCamera.Location = locatie;
            PnlAfisareCamere.Location = locatie;
            PnlModificareCamera.Location = locatie;
            PnlCautareCamera.Location = locatie;

            PnlAdaugareRezervare.Location = locatie;
            PnlAfisareRezervari.Location = locatie;
            PnlModificareRezervare.Location = locatie;
            PnlCautareRezervare.Location = locatie;

            PnlAdaugareClient.Location = locatie;
            PnlAfisareClienti.Location = locatie;
            PnlModificareClient.Location = locatie;
            PnlCautareClient.Location = locatie;

            PnlAdaugareAngajat.Location = locatie;
            PnlAfisareAngajati.Location = locatie;
            PnlModificareAngajat.Location = locatie;
            PnlCautareAngajat.Location = locatie;

            
            PnlAdaugareCamera.Visible = true;
            PnlAfisareCamere.Visible = false;
            PnlModificareCamera.Visible = false;
            PnlCautareCamera.Visible = false;

            PnlAdaugareRezervare.Visible = true;
            PnlAfisareRezervari.Visible = false;
            PnlModificareRezervare.Visible = false;
            PnlCautareRezervare.Visible = false;

            PnlAdaugareClient.Visible = true;
            PnlAfisareClienti.Visible = false;
            PnlModificareClient.Visible = false;
            PnlCautareClient.Visible = false;

            PnlAdaugareAngajat.Visible = true;
            PnlAfisareAngajati.Visible = false;
            PnlModificareAngajat.Visible = false;
            PnlCautareAngajat.Visible = false;


            PanelCamere.Controls.Add(PnlAdaugareCamera);
            PanelCamere.Controls.Add(PnlAfisareCamere);
            PanelCamere.Controls.Add(PnlCautareCamera);
            PanelCamere.Controls.Add(PnlModificareCamera);

            PanelRezervari.Controls.Add(PnlAdaugareRezervare);
            PanelRezervari.Controls.Add(PnlAfisareRezervari);
            PanelRezervari.Controls.Add(PnlCautareRezervare);
            PanelRezervari.Controls.Add(PnlModificareRezervare);
            
            PanelAngajati.Controls.Add(PnlAdaugareAngajat);
            PanelAngajati.Controls.Add(PnlAfisareAngajati);
            PanelAngajati.Controls.Add(PnlCautareAngajat);
            PanelAngajati.Controls.Add(PnlModificareAngajat);
            

            PanelClienti.Controls.Add(PnlAdaugareClient);
            PanelClienti.Controls.Add(PnlAfisareClienti);
            PanelClienti.Controls.Add(PnlCautareClient);
            PanelClienti.Controls.Add(PnlModificareClient);
            


            PanelCamere.Visible = true;
            PanelRezervari.Visible = false;
            PanelClienti.Visible = false;
            PanelAngajati.Visible = false;
        }

        private void Navbar_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov == 1)
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
        }

        private void Navbar_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX = e.X;
            movY = e.Y;
        }

        private void Navbar_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }

        readonly string password = "daniel";

        private void MainForm_Load(object sender, EventArgs e)
        {
            MainPanel.Visible = false;
        }


        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TxtBxParola_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (TxtBxParola.Text == password)
                {
                    AuthPanel.Visible = false;
                    MainPanel.Visible = true;
                    PanelCamere.Visible = true;
                }
                else
                {
                    MesajParola.Text = "*Parola incorecta";
                    TxtBxParola.Text = "";
                }
            }
        }


        private void ButonAdaugareCamera_Click(object sender, EventArgs e)
        {
            PnlAdaugareCamera.Visible = true;
            PnlAfisareCamere.Visible = false;
            PnlCautareCamera.Visible = false;
            PnlModificareCamera.Visible = false;
        }

        private void ButonAfisareCamere_Click(object sender, EventArgs e)
        {
            PnlAdaugareCamera.Visible = false;
            PnlAfisareCamere.Visible = true;
            PnlCautareCamera.Visible = false;
            PnlModificareCamera.Visible = false;
        }

        private void ButonCautareCamera_Click(object sender, EventArgs e)
        {
            PnlAdaugareCamera.Visible = false;
            PnlAfisareCamere.Visible = false;
            PnlCautareCamera.Visible = true;
            PnlModificareCamera.Visible = false;
        }

        private void ButonModificareCamera_Click(object sender, EventArgs e)
        {
            PnlAdaugareCamera.Visible = false;
            PnlAfisareCamere.Visible = false;
            PnlCautareCamera.Visible = false;
            PnlModificareCamera.Visible = true;
        }

        private void BtnCamere_Click(object sender, EventArgs e)
        {
            PanelCamere.Visible = true;
            PanelRezervari.Visible = false;
            PanelClienti.Visible = false;
            PanelAngajati.Visible = false;
        }

        private void BtnRezervari_Click(object sender, EventArgs e)
        {
            PanelCamere.Visible = false;
            PanelRezervari.Visible = true;
            PanelClienti.Visible = false;
            PanelAngajati.Visible = false;
        }

        private void BtnClienti_Click(object sender, EventArgs e)
        {
            PanelCamere.Visible = false;
            PanelRezervari.Visible = false;
            PanelClienti.Visible = true;
            PanelAngajati.Visible = false;
            PnlAdaugareClient.Visible = true;
        }

        private void BtnAngajati_Click(object sender, EventArgs e)
        {
            PanelCamere.Visible = false;
            PanelRezervari.Visible = false;
            PanelClienti.Visible = false;
            PanelAngajati.Visible = true;
        }

        private void BtnAdaugareRezervare_Click(object sender, EventArgs e)
        {
            PnlAdaugareRezervare.Visible = true;
            PnlAfisareRezervari.Visible = false;
            PnlCautareRezervare.Visible = false;
            PnlModificareRezervare.Visible = false;
        }

        private void BtnAfisareRezervari_Click(object sender, EventArgs e)
        {
            PnlAdaugareRezervare.Visible = false;
            PnlAfisareRezervari.Visible = true;
            PnlCautareRezervare.Visible = false;
            PnlModificareRezervare.Visible = false;
        }

        private void BtnCautareRezervare_Click(object sender, EventArgs e)
        {
            PnlAdaugareRezervare.Visible = false;
            PnlAfisareRezervari.Visible = false;
            PnlCautareRezervare.Visible = true;
            PnlModificareRezervare.Visible = false;
        }

        private void BtnModificareRezervare_Click(object sender, EventArgs e)
        {
            PnlAdaugareRezervare.Visible = false;
            PnlAfisareRezervari.Visible = false;
            PnlCautareRezervare.Visible = false;
            PnlModificareRezervare.Visible = true;
        }

        private void BtnAdaugareClient_Click(object sender, EventArgs e)
        {
            PnlAdaugareClient.Visible = true;
            PnlAfisareClienti.Visible = false;
            PnlCautareClient.Visible = false;
            PnlModificareClient.Visible = false;
        }

        private void BtnAfisareClienti_Click(object sender, EventArgs e)
        {
            PnlAdaugareClient.Visible = false;
            PnlAfisareClienti.Visible = true;
            PnlCautareClient.Visible = false;
            PnlModificareClient.Visible = false;
        }

        private void BtnCautareClient_Click(object sender, EventArgs e)
        {
            PnlAdaugareClient.Visible = false;
            PnlAfisareClienti.Visible = false;
            PnlCautareClient.Visible = true;
            PnlModificareClient.Visible = false;
        }

        private void BtnModificareClient_Click(object sender, EventArgs e)
        {
            PnlAdaugareClient.Visible = false;
            PnlAfisareClienti.Visible = false;
            PnlCautareClient.Visible = false;
            PnlModificareClient.Visible = true;
        }

        private void BtnAdaugareAngajat_Click(object sender, EventArgs e)
        {
            PnlAdaugareAngajat.Visible = true;
            PnlAfisareAngajati.Visible = false;
            PnlCautareAngajat.Visible = false;
            PnlModificareAngajat.Visible = false;
        }

        private void BtnAfisareAngajati_Click(object sender, EventArgs e)
        {
            PnlAdaugareAngajat.Visible = false;
            PnlAfisareAngajati.Visible = true;
            PnlCautareAngajat.Visible = false;
            PnlModificareAngajat.Visible = false;
        }

        private void BtnCautareAngajat_Click(object sender, EventArgs e)
        {
            PnlAdaugareAngajat.Visible = false;
            PnlAfisareAngajati.Visible = false;
            PnlCautareAngajat.Visible = true;
            PnlModificareAngajat.Visible = false;
        }

        private void BtnModificareAngajat_Click(object sender, EventArgs e)
        {
            PnlAdaugareAngajat.Visible = false;
            PnlAfisareAngajati.Visible = false;
            PnlCautareAngajat.Visible = false;
            PnlModificareAngajat.Visible = true;
        }
    }
}
