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
    public partial class UCAdaugareCamera : UserControl
    {

        List<Camera> camere;
        IStocareCamere adminCamere = StocareFactory.GetAdministratorStocareCamere();
        int nrCamere;
        FacilitatiCamera facilitatiSelectate = new FacilitatiCamera();

        public UCAdaugareCamera()
        {
            InitializeComponent();
            
        }

        private void BtnAdaugaCamera_Click(object sender, EventArgs e)
        {
            if (TxtDenumireCamera.Text != "" && TxtDimensiuneCamera.Text != "" && TxtEtajCamera.Text != "" && TxtBxPret.Text != "")
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

                LblAdaugareCameraAvertisment.ForeColor = Color.Green;
                string line = $"1,{TxtDenumireCamera.Text},{TxtDimensiuneCamera.Text},{TxtEtajCamera.Text},{(int)facilitatiSelectate},{(int)t},{TxtBxPret.Text}";
                camere.Add(new Camera(line));
                adminCamere.AddCamera(new Camera(line));

                TxtDenumireCamera.Text = "";
                TxtDimensiuneCamera.Text = "";
                TxtEtajCamera.Text = "";
                TxtBxPret.Text = "";
                LblAdaugareCameraAvertisment.Text = "Camera a fost adaugata cu succes";
            }
            else
            { 
                LblAdaugareCameraAvertisment.ForeColor = Color.Firebrick;
                LblAdaugareCameraAvertisment.Text = "*Trebuie completate toate campurile pentru a finaliza actiunea";
            }
        }

        private void CkbFacilitati_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBoxControl = sender as CheckBox; //operator 'as'
                                                           //sau
                                                           //CheckBox checkBoxControl = (CheckBox)sender; //operator cast

            int facilitateSelectata = (int)Enum.Parse(typeof(FacilitatiCamera),checkBoxControl.Text);
            //verificare daca checkbox-ul asupra caruia s-a actionat este selectat
            if (checkBoxControl.Checked == true)
                facilitatiSelectate = (FacilitatiCamera)((int)facilitatiSelectate + facilitateSelectata);
            else
                facilitatiSelectate = (FacilitatiCamera)((int)facilitatiSelectate - facilitateSelectata);
        }

        private void PnlAddCamera_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible == false)
                LblAdaugareCameraAvertisment.Text = "";
        }

        private void UCAdaugareCamera_Load(object sender, EventArgs e)
        {
            camere = adminCamere.GetCamere();
            nrCamere = camere.Count;
            Camera.IdUltimaCamera = nrCamere;
            facilitatiSelectate = 0;
        }
    }
}
