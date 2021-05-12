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
    public partial class UCCautareCamera : UserControl
    {
        List<Camera> camere = new List<Camera>();
        IStocareCamere adminCamere;
        int nrCamere;

        public UCCautareCamera()
        {
            InitializeComponent();
            
        }

        private void UCCautareCamera_Load(object sender, EventArgs e)
        {
            adminCamere = StocareFactory.GetAdministratorStocareCamere();
            camere = adminCamere.GetCamere();
            nrCamere = camere.Count;
            Camera.IdUltimaCamera = nrCamere;
        }

        private void BtnCautaCamera_Click(object sender, EventArgs e)
        {
            int id = int.Parse(TxtIDCamera.Text);

            Camera cameraAfisare = adminCamere.GetCamera(id);
            if (cameraAfisare == null)
            {    
                LblCautareAvertisment.Text = "Aceasta camera nu a fost gasita in baza de date.";
                PnlAfisareCameraCautata.Visible = false;
            }
            else
            {
                LblCautareAvertisment.Text = "";
                PnlAfisareCameraCautata.Visible = true;
                LblHeaderInfo.Text = Camera.HeaderInfo() + "   ";
                LblCameraCautata.Text = cameraAfisare.ConversieLaSir();
            }
        }

    }
}
