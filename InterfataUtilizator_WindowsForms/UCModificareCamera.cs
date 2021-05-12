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
    public partial class UCModificareCamera : UserControl
    {

        List<Camera> camere;
        IStocareCamere adminCamere = StocareFactory.GetAdministratorStocareCamere();
        int nrCamere;

        public UCModificareCamera()
        {
            InitializeComponent();
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
                LblCautareAvertisment.Text = "*Aceasta camera nu a fost gasita in baza de date.";
                PnlDateCamera.Visible = false;
            }
            else
            {
                LblCautareAvertisment.Text = "";
                PnlDateCamera.Visible = true;
                TxtDenumireCamera.Text = cameraAfisare.Denumire;
                TxtDimensiuneCamera.Text ="" + cameraAfisare.Dimensiune;
                TxtEtajCamera.Text ="" + cameraAfisare.Etaj;
                TxtPretCamera.Text ="" + cameraAfisare.Pret;



                if (cameraAfisare.Tip.ToString() == RBtnSingle.Text)
                    RBtnSingle.Checked = true;
                else if (cameraAfisare.Tip.ToString() == RBtnDubla.Text)
                    RBtnDubla.Checked = true;
                else if (cameraAfisare.Tip.ToString() == RBtnTwin.Text)
                    RBtnTwin.Checked = true;
                else if (cameraAfisare.Tip.ToString() == RBtnMatrimoniala.Text)
                    RBtnMatrimoniala.Checked = true;
                else if (cameraAfisare.Tip.ToString() == RBtnTripla.Text)
                    RBtnTripla.Checked = true;
                else if (cameraAfisare.Tip.ToString() == RBtnQuad.Text)
                    RBtnQuad.Checked = true;

                string facilitatiString = cameraAfisare.Facilitati.ToString();
                if (facilitatiString.Contains(ChBxTV.Text))
                    ChBxTV.Checked = true;
                if (facilitatiString.Contains(ChBxInternet.Text))
                    ChBxInternet.Checked = true;
                if (facilitatiString.Contains(ChBxSeif.Text))
                    ChBxSeif.Checked = true;
                if (facilitatiString.Contains(ChBxJacuzzi.Text))
                    ChBxJacuzzi.Checked = true;
                if (facilitatiString.Contains(ChBxFrigider.Text))
                    ChBxFrigider.Checked = true;
                

            }
        }

        private void BtnModificaCamera_Click(object sender, EventArgs e)
        {

        }
    }
}
