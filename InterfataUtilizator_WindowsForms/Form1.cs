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
        IStocareParola adminParola = StocareFactory.GetAdministratorStocareParola();

        string Password { set; get; }


        public MainForm()
        {
            InitializeComponent();

            SetareAcasa();

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
            


            PanelAcasa.Visible = true;
            PanelCamere.Visible = false;
            PanelRezervari.Visible = false;
            PanelClienti.Visible = false;
            PanelAngajati.Visible = false;
            PanelSetari.Visible = false;

            if (adminParola.GetPassword() != null)
            {
                Password = adminParola.GetPassword();
            }
            else
            { 
                Password = "password";
                adminParola.SetPassword(Password);
            }
        }

        int mov;
        int movX;
        int movY;

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
                if (TxtBxParola.Text == Password)
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
            PanelAcasa.Visible = false;
            PanelSetari.Visible = false;
        }

        private void BtnRezervari_Click(object sender, EventArgs e)
        {
            PanelCamere.Visible = false;
            PanelRezervari.Visible = true;
            PanelClienti.Visible = false;
            PanelAngajati.Visible = false;
            PanelAcasa.Visible = false;
            PanelSetari.Visible = false;
        }

        private void BtnClienti_Click(object sender, EventArgs e)
        {
            PanelCamere.Visible = false;
            PanelRezervari.Visible = false;
            PanelClienti.Visible = true;
            PanelAngajati.Visible = false;
            PnlAdaugareClient.Visible = true;
            PanelAcasa.Visible = false;
            PanelSetari.Visible = false;
        }

        private void BtnAngajati_Click(object sender, EventArgs e)
        {
            PanelCamere.Visible = false;
            PanelRezervari.Visible = false;
            PanelClienti.Visible = false;
            PanelAngajati.Visible = true;
            PanelAcasa.Visible = false;
            PanelSetari.Visible = false;
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

        private void BtnSetari_Click(object sender, EventArgs e)
        {
            PanelCamere.Visible = false;
            PanelRezervari.Visible = false;
            PanelClienti.Visible = false;
            PanelAngajati.Visible = false;
            PanelAcasa.Visible = false;
            PanelSetari.Visible = true;
        }

        private void BtnAcasa_Click(object sender, EventArgs e)
        {
            PanelCamere.Visible = false;
            PanelRezervari.Visible = false;
            PanelClienti.Visible = false;
            PanelAngajati.Visible = false;
            PanelAcasa.Visible = true;
            PanelSetari.Visible = false;
        }

        private void PanelAcasa_VisibleChanged(object sender, EventArgs e)
        {
            if(PanelAcasa.Visible == true)
            {
                SetareAcasa();
            }
        }

        void SetareAcasa()
        {
            clienti = adminClienti.GetClienti();
            angajati = adminAngajati.GetAngajati();
            camere = adminCamere.GetCamere();
            rezervari = adminRezervari.GetRezervari();

            LblNrAngajati.Text = angajati.Count.ToString();
            if (angajati.Count == 1)
                LblAngajati.Text = "Angajat";
            else
                LblAngajati.Text = "Angajati";

            LblNrClienti.Text = clienti.Count.ToString();
            if (clienti.Count == 1)
                LblClienti.Text = "Client";
            else
                LblClienti.Text = "Clienti";

            LblNrCamere.Text = camere.Count.ToString();
            if (camere.Count == 1)
                LblCamere.Text = "Camera";
            else
                LblCamere.Text = "Camere";
        }

        

        private void BtnActualizeazaParola_Click(object sender, EventArgs e)
        {
            if(DateValide())
            {
                Password = TxtNouaParola.Text;
                adminParola.SetPassword(Password);
                ResetareControale();
            }
        }

        void ResetareControale()
        {
            TxtActualaParola.Text = "";
            TxtNouaParola.Text = "";
            TxtRepetaNouaParola.Text = "";
            LblModificareParolaAvertisment.Text = "";
        }

        bool DateValide()
        {
            Password = adminParola.GetPassword();
            if(TxtActualaParola.Text == "" || TxtNouaParola.Text == "" || TxtRepetaNouaParola.Text == "")
            {
                LblModificareParolaAvertisment.Text = "*Trebuie completate toate campurile";
                return false;
            }
            if (TxtActualaParola.Text == TxtNouaParola.Text)
            {
                LblModificareParolaAvertisment.Text = "*Noua parola trebuie sa fie diferita de cea actuala";
                return false;
            }
            if (TxtNouaParola.Text != TxtRepetaNouaParola.Text)
            {
                LblModificareParolaAvertisment.Text = "*Noua parola introdusa a doua oara nu coincide cu prima";
                return false;
            }
            if (TxtActualaParola.Text != Password)
            {
                LblModificareParolaAvertisment.Text = "*Parola actuala introdusa gresit";
                return false;
            }
            return true;
        }
    }
}
