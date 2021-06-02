using System;
namespace LibrarieModele
{
    public class Rezervare
    {
        public static int IdUltimaRezervare { get; set; } = 0;
        public int ID_rezervare { get; set; }
        public string CNP_client { get; set; }
        public int ID_camera { get; set; }
        public DateTime Checkin_date { get; set; }
        public DateTime Checkout_date { get; set; }

        private const char SEPARATOR_PRINCIPAL_FISIER = ',';
        private const int ID_REZERVARE = 0;
        private const int CNP_CLIENT = 1;
        private const int ID_CAMERA = 2;
        private const int CHECKIN_DATE = 3;
        private const int CHECKOUT_DATE = 4;

        public Rezervare(string _date)
        {
            string[] dateAsArrayOfStrings = _date.Split(SEPARATOR_PRINCIPAL_FISIER);
            ID_rezervare = int.Parse(dateAsArrayOfStrings[ID_REZERVARE]);
            CNP_client = dateAsArrayOfStrings[CNP_CLIENT];

            if(int.TryParse(dateAsArrayOfStrings[ID_CAMERA], out int id))
            {
                ID_camera = id;
            }
            Checkin_date = DateTime.Parse(dateAsArrayOfStrings[CHECKIN_DATE]);
            Checkout_date = DateTime.Parse(dateAsArrayOfStrings[CHECKOUT_DATE]);
        }

        static public string HeaderInfo()
        {
            string sf = "{0,-15} {1,-20} {2,-15} {3,-15} {4, -15}";

            return string.Format(sf, "ID Rezervare", "CNP Client", "ID Camera", "Data Check-In", "Data Check-Out");
        }

        public string ConversieLaSir()
        {
            string sf = "{0,-15} {1,-20} {2,-15} {3,-15} {4, -15}";
            string dateForDisplay = string.Format(sf, ID_rezervare,CNP_client, ID_camera, Checkin_date.ToShortDateString(),Checkout_date.ToShortDateString());

            return dateForDisplay;
        }


        public string ConversieLaSir_PentruScriereInFisier()
        {
            string dateForDisplay = $"{ID_rezervare},{CNP_client},{ID_camera},{Checkin_date.ToShortDateString()},{Checkout_date.ToShortDateString()}";

            return dateForDisplay;
        }
    }
}
