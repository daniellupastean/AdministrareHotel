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
    public partial class UCAfisareCamere : UserControl
    {

        List<Camera> camere;
        IStocareCamere adminCamere = StocareFactory.GetAdministratorStocareCamere();

        public UCAfisareCamere()
        {
            InitializeComponent();
            if (LsBxAfisareCamere.SelectedItem == null || LsBxAfisareCamere.SelectedIndex == 0)
                BtnStergeCamera.Enabled = false;


        }

        private void PnlAfisareCamere_VisibleChanged(object sender, EventArgs e)
        {
            if(PnlAfisareCamere.Visible == true)
            {
                camere = adminCamere.GetCamere();
                LsBxAfisareCamere.Items.Clear();
                LsBxAfisareCamere.Items.Add(Camera.HeaderInfo());
                foreach(Camera camera in camere)
                {
                    LsBxAfisareCamere.Items.Add(camera.ConversieLaSir());
                }
            }
        }

        private void UCAfisareCamere_Load(object sender, EventArgs e)
        {
            camere = adminCamere.GetCamere();
        }

        private void LsBxAfisareCamere_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LsBxAfisareCamere.SelectedIndex == 0)
                BtnStergeCamera.Enabled = false;
            else
            {
                BtnStergeCamera.Enabled = true;
            }
        }

        private void BtnStergeCamera_Click(object sender, EventArgs e)
        {
            camere = adminCamere.GetCamere();
            string[] date = LsBxAfisareCamere.SelectedItem.ToString().Split(' ');
            int id = int.Parse(date[0]);
            camere.RemoveAll(r => r.ID_camera == id);
            adminCamere.UpdateFisierCamere(camere);
            LsBxAfisareCamere.Items.Clear();
            LsBxAfisareCamere.Items.Add(Camera.HeaderInfo());
            foreach (Camera camera in camere)
            {
                LsBxAfisareCamere.Items.Add(camera.ConversieLaSir());
            }
        }
    }
}
