using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using LibrarieModele;
using NivelAccesDate;

namespace InterfataUtilizator_WindowsForms
{
    public partial class UCModificareRezervare : UserControl
    {

        List<Rezervare> rezervari = new List<Rezervare>();
        IStocareRezervari adminRezervari = StocareFactory.GetAdministratorStocareRezervari();

        public UCModificareRezervare()
        {
            InitializeComponent();
        }

        private void UCModificareRezervare_Load(object sender, EventArgs e)
        {
            rezervari = adminRezervari.GetRezervari();
            //DtpCheckIn.MinDate = DateTime.Now;
           // DtpCheckOut.MinDate = DateTime.Now;
        }

        private void BtnCautaRezervare_Click(object sender, EventArgs e)
        {
            if (DateValideCautare())
            {
                int id = int.Parse(TxtIDRezervare.Text);

                Rezervare rezervareAfisare = adminRezervari.GetRezervare(id);

                if (rezervareAfisare == null)
                {
                    LblCautareAvertisment.Text = "Rezervarea nu a fost gasita in baza de date.";
                    PnlDateRezervare.Visible = false;
                }
                else
                {
                    LblCautareAvertisment.Text = "";
                    PnlDateRezervare.Visible = true;
                    TxtCNPClient.Text = rezervareAfisare.CNP_client;
                    TxtIDCamera.Text = rezervareAfisare.ID_camera.ToString();
                    DtpCheckIn.Value = rezervareAfisare.Checkin_date;
                    DtpCheckOut.Value = rezervareAfisare.Checkout_date;
                }
            }
        }

        
        bool DateValideCautare()
        {
            if (TxtIDRezervare.Text == "")
            {
                LblCautareAvertisment.Text = "Trebuie completat campul pentru ID";
                return false;
            }

            if (!int.TryParse(TxtIDRezervare.Text, out _))
            {
                LblCautareAvertisment.Text = "ID-ul trebuie sa fie un numar intreg";
                return false;
            }


            return true;
        }

        bool DateValideModificare()
        {
            LblAvertisment.ForeColor = Color.Firebrick;
            if (TxtCNPClient.Text == "" || TxtIDCamera.Text == "" || DtpCheckIn.Value == null || DtpCheckOut.Value == null)
            {
                LblAvertisment.Text = "*Trebuie completate toate campurile";
                return false;
            }
            if (!OnlyDigits(TxtCNPClient.Text))
            {
                LblAvertisment.Text = "*CNP-ul trebuie sa contina doar cifre";
                return false;
            }

            if (TxtCNPClient.Text.Length != 13)
            {
                LblAvertisment.Text = "*CNP-ul trebuie sa contina 13 cifre";
                return false;
            }

            if (!int.TryParse(TxtIDCamera.Text, out _))
            {
                LblAvertisment.Text = "*ID-ul camerei trebuie sa fie un numar intreg";
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


        bool OnlyDigits(string s)
        {
            foreach (char c in s)
            {
                if (c < '0' || c > '9')
                    return false;
            }
            return true;
        }

        bool OnlyLetters(string s)
        {
            return Regex.IsMatch(s, @"^[\p{L}]+$");
        }

        bool IsFloatNumber(string s)
        {
            return float.TryParse(s, out _);
        }

        private void BtnModificaRezervare_Click(object sender, EventArgs e)
        {
            rezervari = adminRezervari.GetRezervari();
            int id = int.Parse(TxtIDRezervare.Text);
            Rezervare rezervareAfisare = adminRezervari.GetRezervare(id);

            if (DateValideModificare())
            {
                int i = 0;

                while (rezervari[i].ID_rezervare != rezervareAfisare.ID_rezervare)
                {
                    i++;
                }

                rezervari[i].CNP_client = TxtCNPClient.Text;
                rezervari[i].ID_camera = int.Parse(TxtIDCamera.Text);
                rezervari[i].Checkin_date = DtpCheckIn.Value;
                rezervari[i].Checkout_date = DtpCheckOut.Value;


                ResetareControale();
                PnlDateRezervare.Visible = false;
            }
            else
            {
                LblAvertisment.Text = "*Trebuie completate toate campurile pentru a putea realiza modificarea";
            }
            adminRezervari.UpdateFisierRezervari(rezervari);
        }
    }
}
