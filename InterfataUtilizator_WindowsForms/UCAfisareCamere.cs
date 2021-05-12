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
        int nrCamere;

        public UCAfisareCamere()
        {
            InitializeComponent();
           

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
            //camere = adminCamere.GetCamere();
            nrCamere = camere.Count;
            Camera.IdUltimaCamera = nrCamere;
        }
    }
}
