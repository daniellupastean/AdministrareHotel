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
        FacilitatiCamera facilitatiSelectate = new FacilitatiCamera();

        public UCModificareCamera()
        {
            InitializeComponent();
            
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
                else ChBxTV.Checked = false;
                if (facilitatiString.Contains(ChBxInternet.Text))
                    ChBxInternet.Checked = true;
                else ChBxInternet.Checked = false;
                if (facilitatiString.Contains(ChBxSeif.Text))
                    ChBxSeif.Checked = true;
                else ChBxSeif.Checked = false;
                if (facilitatiString.Contains(ChBxJacuzzi.Text))
                    ChBxJacuzzi.Checked = true;
                else ChBxJacuzzi.Checked = false;
                if (facilitatiString.Contains(ChBxFrigider.Text))
                    ChBxFrigider.Checked = true;
                else ChBxFrigider.Checked = false;


            }
        }

        private void BtnModificaCamera_Click(object sender, EventArgs e)
        {
            camere = adminCamere.GetCamere();
            int id = int.Parse(TxtIDCamera.Text);
            Camera cameraAfisare = adminCamere.GetCamera(id);

            if (TxtDenumireCamera.Text != "" && TxtDimensiuneCamera.Text != "" && TxtEtajCamera.Text != "" && TxtPretCamera.Text != "")
            {
                TipCamera t = new TipCamera();
                if (RBtnSingle.Checked)
                    t = TipCamera.Single;
                else if (RBtnDubla.Checked)
                    t = TipCamera.Dubla;
                else if (RBtnTwin.Checked)
                    t = TipCamera.Twin;
                else if (RBtnMatrimoniala.Checked)
                    t = TipCamera.Matrimoniala;
                else if (RBtnTripla.Checked)
                    t = TipCamera.Tripla;
                else if (RBtnQuad.Checked)
                    t = TipCamera.Quad;

                int i = 0;

                while (camere[i].ID_camera != cameraAfisare.ID_camera)
                {
                    i++;
                }

                camere[i].Denumire = TxtDenumireCamera.Text;
                camere[i].Dimensiune = float.Parse(TxtDimensiuneCamera.Text);
                camere[i].Etaj = int.Parse(TxtEtajCamera.Text);
                camere[i].Facilitati = facilitatiSelectate;
                camere[i].Tip = t;
                camere[i].Pret = float.Parse(TxtPretCamera.Text);

                TxtDenumireCamera.Text = "";
                TxtDimensiuneCamera.Text = "";
                TxtEtajCamera.Text = "";
                TxtPretCamera.Text = "";
                PnlDateCamera.Visible = false;
                LblAvertismentModificare.Text = "";
            }
            else
            {
                LblAvertismentModificare.Text = "*Trebuie completate toate campurile pentru a putea realiza modificarea";
            }
            adminCamere.UpdateFisierCamere(camere);
        }


        private void CkbFacilitati_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBoxControl = sender as CheckBox; //operator 'as'
                                                           //sau
                                                           //CheckBox checkBoxControl = (CheckBox)sender; //operator cast

            int facilitateSelectata = (int)Enum.Parse(typeof(FacilitatiCamera), checkBoxControl.Text);
            //verificare daca checkbox-ul asupra caruia s-a actionat este selectat
            if (checkBoxControl.Checked == true)
                facilitatiSelectate = (FacilitatiCamera)((int)facilitatiSelectate + facilitateSelectata);
            else
                facilitatiSelectate = (FacilitatiCamera)((int)facilitatiSelectate - facilitateSelectata);
        }

        private void UCModificareCamera_Load(object sender, EventArgs e)
        {
            camere = adminCamere.GetCamere();
            nrCamere = camere.Count;
            Camera.IdUltimaCamera = nrCamere;
            facilitatiSelectate = (FacilitatiCamera)0;
        }
    }
}
