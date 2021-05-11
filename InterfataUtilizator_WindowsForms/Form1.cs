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
        UCAdaugareCamera PnlAdaugareCamera;
        UCAfisareCamere PnlAfisareCamere;
        UCModificareCamera PnlModificareCamera;
        UCCautareCamera PnlCautareCamera;
        Point locatie = new Point(32, 51);

        ///Legatura cu backend-ul
        List<Client> clienti;
        List<Angajat> angajati;
        List<Camera> camere;
        List<Rezervare> rezervari;

        IStocareClienti adminClienti = StocareFactory.GetAdministratorStocareClienti();
        IStocareAngajati adminAngajati = StocareFactory.GetAdministratorStocareAngajati();
        IStocareCamere adminCamere = StocareFactory.GetAdministratorStocareCamere();
        IStocareRezervari adminRezervari = StocareFactory.GetAdministratorStocareRezervari();
        //
        

        public MainForm()
        {
            InitializeComponent();

            PnlAdaugareCamera = new UCAdaugareCamera();
            PanelCamere.Controls.Add(PnlAdaugareCamera);
            PnlAdaugareCamera.Location = locatie;
            PnlAdaugareCamera.Visible = true;

            PnlAfisareCamere = new UCAfisareCamere();
            PanelCamere.Controls.Add(PnlAfisareCamere);
            PnlAfisareCamere.Location = locatie;
            PnlAfisareCamere.Visible = false;

            PnlCautareCamera = new UCCautareCamera();
            PanelCamere.Controls.Add(PnlCautareCamera);
            PnlCautareCamera.Location = locatie;
            PnlCautareCamera.Visible = false;

            PnlModificareCamera = new UCModificareCamera();
            PanelCamere.Controls.Add(PnlModificareCamera);
            PnlModificareCamera.Location = locatie;
            PnlModificareCamera.Visible = false;


            clienti = adminClienti.GetClienti();
            angajati = adminAngajati.GetAngajati();
            camere = adminCamere.GetCamere();
            rezervari = adminRezervari.GetRezervari();

            int nrClienti = clienti.Count;
            Client.IdUltimClient = nrClienti;

            int nrAngajati = angajati.Count;
            Angajat.IdUltimAngajat = nrAngajati;

            int nrCamere = camere.Count;
            Camera.IdUltimaCamera = nrCamere;

            int nrRezervari = rezervari.Count;
            Rezervare.IdUltimaRezervare = nrRezervari;
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
    }
}
